import cv2
from PIL import Image #thư viện PIllow hỗ trợ nhiều định dạng ảnh
import numpy as np 

#khai báo đường dẫn file hình
filehinh = r'bird_small.jpg'

#đọc ảnh màu sử dụng thư viện opencv
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)

#sử dụng PILLOW để xử lý tính toán thay cho opencv
imgPIL = Image.open(filehinh)

# ảnh dùng chứa kết quả chuyển đổi từ RBG sang binary 
binary = Image.new(imgPIL.mode, imgPIL.size)

#lấy kích thước cao và ngang của ảnh (0 la chieu ngang, 1 la chieu cao)
width = binary.size[0]
height = binary.size[1]
nguong = 100
for x in range(width):
    for y in range(height):
        r, g, b = imgPIL.getpixel((x,y))
        #chuyen sang muc xam
        gray = np.uint8((r+g+b)/3)

        #so sanh mức xám để đổi sang binary
        if (gray < nguong):
            binary.putpixel((x,y),(0,0,0))
        else:
            binary.putpixel((x,y),(255,255,255))
        

#chuyen anh tu PILLOW sang open cv de mở ảnh bằng opencv
anh_binary = np.array(binary)


#hien thi anh goc va anh xam        
cv2.imshow('goc', img)
cv2.imshow('anh nhi phan', anh_binary)

#bam phim bat ky de tat cua so
cv2.waitKey(0)
#giai phong bo nho sau khi tat cua so
cv2.destroyAllWindows()