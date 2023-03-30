import cv2               #Sử dụng thư viện xử lí ảnh Opencv
from PIL import Image    #Thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh
import numpy as np      #Thư viện toán học, đặc biệt là ma trận

#HÀM TÍNH mức xám
def RGB_2_grayscale(imgPIL):
    luminance = Image.new(imgPIL.mode, imgPIL.size)
    width = luminance.size[0]
    height = luminance.size[1]
    for x in range(width):
        for y in range(height):
            r, g, b = imgPIL.getpixel((x,y))
            #chuyen sang muc xam
            gray_luminance = np.uint8(r*0.2126 + g*0.7152 + 0.0722*b)

            #nhét giá trị pixel vừa tính ra vào ảnh xám
            luminance.putpixel((x,y),(gray_luminance,gray_luminance,gray_luminance))

    return luminance
def EdgeDetection(average,nguong):

    # Tạo ma trận để nhân tích chập
    matran_x = np.array([-1, -2, -1, 0, 0, 0, 1, 2, 1])
    matran_y = np.array([-1, 0, 1, -2, 0, 2, -1, 0, 1])

    ketqua = Image.new(average.mode,average.size)
    #Lấy kích thước ảnh
    width = average.size[0]
    height = average.size[1]
    #Mỗi hình là một ma trận 2 chiều nên dùng 2 vòng for quét tất cả pixel
    for x in range(1, width-1):
        for y in range(1, height-1):
            #Tạo 2 list rỗng
            gx = []
            gy = []

            for i in range (x-1,x+2):
                for j in range (y-1, y+2):
                    R, G, B = average.getpixel((i,j))
                    gx.append(R)
        
            #Chuyển kiểu dữ liệu List sang mảng
            gx1 = np.array(gx)
            gy1 = np.array(gx)

            #Nhân tích chập
            gx2 = np.dot(gx1,matran_x)
            gy2 = np.dot(gy1,matran_y)

            D = abs(gx2)  + abs(gy2)

            if (D > nguong):
                ketqua.putpixel((x,y),(255,255,255))
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

#tính toán ảnh xám
luminance = RGB_2_grayscale(imgPIL)
#tính đường viền
edge_img = EdgeDetection(luminance,130)

# Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
edge_img_CV = np.array(edge_img)

cv2.imshow('Hinh goc',imgGoc)
cv2.imshow('Hinh sau khi lam net',edge_img_CV)

# Bấm phím bất kì để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cập nhật cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()