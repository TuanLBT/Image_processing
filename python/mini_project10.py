import cv2
from PIL import Image #thư viện PIllow hỗ trợ nhiều định dạng ảnh
import numpy as np 

#khai báo đường dẫn file hình
filehinh = r'lena_color.jpg'

#đọc ảnh màu sử dụng thư viện opencv
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)

#sử dụng PILLOW để xử lý tính toán thay cho opencv
imgPIL = Image.open(filehinh)

kenh_y = Image.new(imgPIL.mode, imgPIL.size)
kenh_cr = Image.new(imgPIL.mode, imgPIL.size)
kenh_Cb = Image.new(imgPIL.mode, imgPIL.size)
ycrcb_img = Image.new(imgPIL.mode, imgPIL.size)

#lấy kích thước cao và ngang của ảnh (0 la chieu ngang, 1 la chieu cao)
width = kenh_y.size[0]
height = kenh_y.size[1]

for x in range(width):
    for y in range(height):
        r, g, b = imgPIL.getpixel((x,y))

        Red = np.uint8(16 + (65.738 / 256) * r + (129.057 / 256) * g + (25.064 / 256) * b)
        Green = np.uint8(128 - (37.945 / 256) * r - (74.494 / 256) * g + (112.439 / 256) * b)
        Blue = np.uint8(128 + (112.439 / 256) * r - (94.154 / 256) * g - (18.258 / 256) * b)

        #dua gia tri vao cac array
        kenh_y.putpixel((x,y),(Red,Red,Red))
        kenh_cr.putpixel((x,y),(Green,Green,Green))
        kenh_Cb.putpixel((x,y),(Blue,Blue,Blue))
        ycrcb_img.putpixel((x,y),(Blue,Green,Red))

#chuyen anh tu PILLOW sang open cv de mở ảnh bằng opencv
hue_CV = np.array(kenh_y)
saturation_CV = np.array(kenh_cr)
instensity_CV = np.array(kenh_Cb)
hsi_img_CV = np.array(ycrcb_img)

#hien thi anh goc va anh xam        
cv2.imshow('goc', img)
cv2.imshow('y', hue_CV)
cv2.imshow('cr', saturation_CV)
cv2.imshow('cb', instensity_CV)
cv2.imshow('ycrcb_img', hsi_img_CV)

#bam phim bat ky de tat cua so
cv2.waitKey(0)
#giai phong bo nho sau khi tat cua so
cv2.destroyAllWindows()