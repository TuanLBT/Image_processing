import cv2               #Sử dụng thư viện xử lí ảnh Opencv
from PIL import Image    #Thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh
import numpy as np      #Thư viện toán học, đặc biệt là ma trận

def EdgeDetection(imgPIL,nguong):

    # Tạo ma trận để nhân tích chập
    matran_x = np.array([-1, -2, -1, 0, 0, 0, 1, 2, 1])
    matran_y = np.array([-1, 0, 1, -2, 0, 2, -1, 0, 1])

    ketqua = Image.new(imgPIL.mode,imgPIL.size)
    #Lấy kích thước ảnh
    width = imgPIL.size[0]
    height = imgPIL.size[1]
    #Mỗi hình là một ma trận 2 chiều nên dùng 2 vòng for quét tất cả pixel
    for x in range(1, width-1):
        for y in range(1, height-1):
            #Tạo 3 list rỗng chứa 3 kênh
            gx_r = []
            gx_g = []
            gx_b = []

            gy_r = []
            gy_g = []
            gy_b = []


            for i in range (x-1,x+2):
                for j in range (y-1, y+2):
                    R, G, B = imgPIL.getpixel((i,j))
                    gx_r.append(R)
                    gx_g.append(G)
                    gx_b.append(B)

                    gy_r.append(R)
                    gy_g.append(G)
                    gy_b.append(B)
        
            #Chuyển kiểu dữ liệu List sang mảng
            gx_r1 = np.array(gx_r)
            gx_g1 = np.array(gx_g)
            gx_b1 = np.array(gx_b)

            gy_r1 = np.array(gy_r)
            gy_g1 = np.array(gy_g)
            gy_b1 = np.array(gy_b)


            #Nhân tích chập
            gx_r2 = np.dot(gx_r1,matran_x)
            gx_g2 = np.dot(gx_g1,matran_x)
            gx_b2 = np.dot(gx_b1,matran_x)

            gy_r2 = np.dot(gy_r1,matran_y)
            gy_g2 = np.dot(gy_g1,matran_y)
            gy_b2 = np.dot(gy_b1,matran_y)

            #áp dụng công thức 6.7-5 và 6.7-6
            Gxx = gx_r2**2 + gx_g2**2 + gx_b2**2
            Gyy = gy_r2**2 + gy_g2**2 + gy_b2**2
            Gxy = gx_r2*gy_r2 + gx_g2*gy_g2 + gx_b2*gy_b2

            #theo công thức 6.7-8  tính giá trị theta
            theta = (np.arctan2(2 * Gxy,Gxx - Gyy))/2
            #theo công thức 6.7-9 tính F(xy)
            Fo = np.sqrt(((Gxx + Gyy) + (Gxx - Gyy) * np.cos(2 * theta) + 2 * Gxy * np.sin(2 * theta)) / 2)


            if (Fo > nguong):
                ketqua.putpixel((x,y),(int(Fo),int(Fo),int(Fo)))
            else:
                ketqua.putpixel((x,y),(0,0,0))
    return ketqua
#-----------------------------------Chương trình chính -----------------------------------------------------

# Khai báo đường dẫn file hình
filehinh = r'lena_color.jpg'

# Đọc ảnh màu dùng thư viện PIL. Ảnh PIL này sẽ dùng tính toán và xử lý thay vì dùng openCV
imgPIL = Image.open(filehinh)

#Đọc ảnh với opencv
imgGoc = cv2.imread(filehinh,cv2.IMREAD_COLOR)


#tính đường viền
edge_img = EdgeDetection(imgPIL,130)

# Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
edge_img_CV = np.array(edge_img)

cv2.imshow('Hinh goc',imgGoc)
cv2.imshow('Hinh sau khi lam net',edge_img_CV)

# Bấm phím bất kì để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cập nhật cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()