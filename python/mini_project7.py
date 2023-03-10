import cv2
from PIL import Image #thư viện PIllow hỗ trợ nhiều định dạng ảnh
import numpy as np 

#khai báo đường dẫn file hình
filehinh = r'lena_color.jpg'

#đọc ảnh màu sử dụng thư viện opencv
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)

#sử dụng PILLOW để xử lý tính toán thay cho opencv
imgPIL = Image.open(filehinh)

hue = Image.new(imgPIL.mode, imgPIL.size)
saturation = Image.new(imgPIL.mode, imgPIL.size)
intensity = Image.new(imgPIL.mode, imgPIL.size)
hsi_img = Image.new(imgPIL.mode, imgPIL.size)

#lấy kích thước cao và ngang của ảnh (0 la chieu ngang, 1 la chieu cao)
width = hue.size[0]
height = hue.size[1]

for x in range(width):
    for y in range(height):
        r, g, b = imgPIL.getpixel((x,y))

        t1 = (2*r -g -b )*0.5
        t2 = np.sqrt(((r - g) * (r - g)) + (r-b)*(g-b))
        theta = np.arccos(t1/t2)
        
        h = 0
        if (b<=g):
            h = theta
        else:
            h = 2*3.14 - theta
        h = np.uint8(h * 180 / 3.14)

        #tinh sat
        s = 1 - ( 3 * min(r,g, b) / (r + g + b) )
        s = s *255

        #tinh intensity
        
        i = (r + b + g) / 3

        #dua gia tri vao cac array
        hue.putpixel((x,y),(h,h,h))
        saturation.putpixel((x,y),(int(s),int(s),int(s)))
        intensity.putpixel((x,y),(int(i),int(i),int(i)))
        hsi_img.putpixel((x,y),(int(i),int(s),int(h)))

#chuyen anh tu PILLOW sang open cv de mở ảnh bằng opencv
hue_CV = np.array(hue)
saturation_CV = np.array(saturation)
instensity_CV = np.array(intensity)
hsi_img_CV = np.array(hsi_img)

#hien thi anh goc va anh xam        
#cv2.imshow('goc', img)
#cv2.imshow('hue', hue_CV)
#cv2.imshow('saturation', saturation_CV)
#cv2.imshow('intensity', instensity_CV)
cv2.imshow('hsi_img', hsi_img_CV)

#bam phim bat ky de tat cua so
cv2.waitKey(0)
#giai phong bo nho sau khi tat cua so
cv2.destroyAllWindows()