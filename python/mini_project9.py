import cv2
from PIL import Image #thư viện PIllow hỗ trợ nhiều định dạng ảnh
import numpy as np 

#khai báo đường dẫn file hình
filehinh = r'lena_color.jpg'

#đọc ảnh màu sử dụng thư viện opencv
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)

#sử dụng PILLOW để xử lý tính toán thay cho opencv
imgPIL = Image.open(filehinh)

kenh_x = Image.new(imgPIL.mode, imgPIL.size)
kenh_y = Image.new(imgPIL.mode, imgPIL.size)
kenh_z = Image.new(imgPIL.mode, imgPIL.size)
xyz_img = Image.new(imgPIL.mode, imgPIL.size)

#lấy kích thước cao và ngang của ảnh (0 la chieu ngang, 1 la chieu cao)
width = kenh_x.size[0]
height = kenh_x.size[1]

for x in range(width):
    for y in range(height):
        r, g, b = imgPIL.getpixel((x,y))

        Red = np.uint8(0.4124564 * r + 0.3575761 * g  + 0.1804375 * b)
        Green = np.uint8(0.2126729 * r + 0.7151522 * g + 0.0721750 * b)
        Blue = np.uint8(0.0193339 *r  +0.1191920 * g + 0.9503041 * b)

        #dua gia tri vao cac array
        kenh_x.putpixel((x,y),(Red,Red,Red))
        kenh_y.putpixel((x,y),(Green,Green,Green))
        kenh_z.putpixel((x,y),(Blue,Blue,Blue))
        xyz_img.putpixel((x,y),(Blue,Green,Red))

#chuyen anh tu PILLOW sang open cv de mở ảnh bằng opencv
hue_CV = np.array(kenh_x)
saturation_CV = np.array(kenh_y)
instensity_CV = np.array(kenh_z)
hsi_img_CV = np.array(xyz_img)

#hien thi anh goc va anh xam        
cv2.imshow('goc', img)
cv2.imshow('x', hue_CV)
cv2.imshow('y', saturation_CV)
cv2.imshow('z', instensity_CV)
cv2.imshow('xyz_img', hsi_img_CV)

#bam phim bat ky de tat cua so
cv2.waitKey(0)
#giai phong bo nho sau khi tat cua so
cv2.destroyAllWindows()