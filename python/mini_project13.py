import cv2               #Sử dụng thư viện xử lí ảnh Opencv
from PIL import Image    #Thư viện xử lý ảnh PILLOW hỗ trợ nhiều định dạng ảnh
import numpy as np      #Thư viện toán học, đặc biệt là ma trận

#HÀM TÍNH TRUNG BÌNH MÀU
def trungbinhcackenhmau(imgPIL,x1,y1,x2,y2):

    #tạo mảng chứa 3 giá trị của vector trung bình màu a
    a = []

    #lấy kích thước ảnh
    width = imgPIL.size[0]
    height = imgPIL.size[1]

    #khởi tạo các biến chứa giá trị cộng dồn
    Rs = 0
    Gs = 0 
    Bs = 0

    #quét lấy các điểm ảnh
    for x in range(x1 , x2+1):
        for y in range(y1 , y2+1):
            r , g , b = imgPIL.getpixel((x,y))
            Rs = Rs + r
            Gs = Gs + g
            Bs = Bs + b
    a.append( np.uint8(Rs / ( (x2 - x1)*(y2 - y1) )) )
    a.append( np.uint8(Gs / ( (x2 - x1)*(y2 - y1) )) )
    a.append( np.uint8(Bs / ( (x2 - x1)*(y2 - y1) )) )

    return a

        
def Segmentation(imgPIL, nguong, a):
    #tạo biến chứa ảnh 
    seg_Image = Image.new(imgPIL.mode,imgPIL.size)
    
    # Lấy kích thước ảnh
    width = seg_Image.size[0]
    height = seg_Image.size[1]

    # Tiến hành quét lấy các điểm ảnh
    for x in range(0 , width ):
        for y in range(0 , height ):
            Zr , Zg , Zb = imgPIL.getpixel((x,y))
            D = np.sqrt((Zr - a[0])**2 + (Zg - a[1])**2 + (Zb - a[2])**2)
            if (D <= nguong):
                seg_Image.putpixel ((x,y),(255,255,255))
            else:
                seg_Image.putpixel ((x,y),(Zb , Zg , Zr))

    return seg_Image


#-----------------------------------Chương trình chính -----------------------------------------------------

# Khai báo đường dẫn file hình
filehinh = r'lena_color.jpg'

# Đọc ảnh màu dùng thư viện PIL. Ảnh PIL này sẽ dùng tính toán và xử lý thay vì dùng openCV
imgPIL = Image.open(filehinh)

#Đọc ảnh với opencv
imgGoc = cv2.imread(filehinh,cv2.IMREAD_COLOR)

#tính toán vector ảnh màu trung bình
a = trungbinhcackenhmau(imgPIL,80,400,150,500)

#phân đoạn ảnh
seg_img = Segmentation(imgPIL, 45, a)

# Chuyển ảnh từ PIL sang OpenCV để hiển thị bằng OpenCV
show_seg = np.array(seg_img)

cv2.imshow('Hinh goc',imgGoc)
cv2.imshow('Hinh sau khi lam net',show_seg)

# Bấm phím bất kì để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cập nhật cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()