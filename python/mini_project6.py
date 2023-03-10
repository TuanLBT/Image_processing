import cv2
from PIL import Image #thư viện PIllow hỗ trợ nhiều định dạng ảnh
import numpy as np 

#khai báo đường dẫn file hình
filehinh = r'lena_color.jpg'

#đọc ảnh màu sử dụng thư viện opencv
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)

#sử dụng PILLOW để xử lý tính toán thay cho opencv
imgPIL = Image.open(filehinh)

cyan = Image.new(imgPIL.mode, imgPIL.size)
magenta = Image.new(imgPIL.mode, imgPIL.size)
yellow = Image.new(imgPIL.mode, imgPIL.size)
black = Image.new(imgPIL.mode, imgPIL.size)

#lấy kích thước cao và ngang của ảnh (0 la chieu ngang, 1 la chieu cao)
width = cyan.size[0]
height = cyan.size[1]

for x in range(width):
    for y in range(height):
        r, g, b = imgPIL.getpixel((x,y))
        #nhét giá trị pixel vừa tính ra vào array của từng màu
        cyan.putpixel((x,y),(b,g,0))
        magenta.putpixel((x,y),(b,0,r))
        yellow.putpixel((x,y),(0,g,r))
        K=min(b,g,r)
        black.putpixel((x,y),(K,K,K))

#chuyen anh tu PILLOW sang open cv de mở ảnh bằng opencv
cyan_CV = np.array(cyan)
magenta_CV = np.array(magenta)
yellow_CV = np.array(yellow)
black_CV = np.array(black)

#hien thi anh goc va anh xam        
cv2.imshow('goc', img)
cv2.imshow('cyan', cyan_CV)
cv2.imshow('magenta', magenta_CV)
cv2.imshow('yellow', yellow_CV)
cv2.imshow('black', black_CV)

#bam phim bat ky de tat cua so
cv2.waitKey(0)
#giai phong bo nho sau khi tat cua so
cv2.destroyAllWindows()