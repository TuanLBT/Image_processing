import cv2
from PIL import Image #thư viện PIllow hỗ trợ nhiều định dạng ảnh
import numpy as np 

#khai báo đường dẫn file hình
filehinh = r'lena_color.jpg'

#đọc ảnh màu sử dụng thư viện opencv
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)

#sử dụng PILLOW để xử lý tính toán thay cho opencv
imgPIL = Image.open(filehinh)

smoothing = Image.new(imgPIL.mode, imgPIL.size)
smoothing3x3 = Image.new(imgPIL.mode, imgPIL.size)
smoothing5x5 = Image.new(imgPIL.mode, imgPIL.size)
smoothing7x7 = Image.new(imgPIL.mode, imgPIL.size)
smoothing9x9 = Image.new(imgPIL.mode, imgPIL.size)

#lấy kích thước cao và ngang của ảnh (0 la chieu ngang, 1 la chieu cao)
width = smoothing.size[0]
height = smoothing.size[1]
#3x3 smooth
for x in range(1, width-1):
    for y in range(1, height-1):
        Rs = 0
        Gs = 0 
        Bs = 0
        for i in range(x-1, x+2):
            for j in range(y-1, y+2):
                r, g, b = imgPIL.getpixel((i,j))
                Rs = Rs + r
                Gs = Gs + g
                Bs = Bs + b

        k = 3*3
        Rs = int(Rs/k)  
        Gs = int(Gs/k)
        Bs = int(Bs/k)

        smoothing3x3.putpixel((x,y),(Bs,Gs,Rs))
#5x5 smooth
for x in range(1, width-3):
    for y in range(1, height-3):
        Rs = 0
        Gs = 0 
        Bs = 0
        for i in range(x-1, x+4):
            for j in range(y-1, y+4):
                r, g, b = imgPIL.getpixel((i,j))
                Rs = Rs + r
                Gs = Gs + g
                Bs = Bs + b

        k = 5*5
        Rs = int(Rs/k)  
        Gs = int(Gs/k)
        Bs = int(Bs/k)

        smoothing5x5.putpixel((x,y),(Bs,Gs,Rs))        
#7x7 smooth
for x in range(1, width-5):
    for y in range(1, height-5):
        Rs = 0
        Gs = 0 
        Bs = 0
        for i in range(x-1, x+6):
            for j in range(y-1, y+6):
                r, g, b = imgPIL.getpixel((i,j))
                Rs = Rs + r
                Gs = Gs + g
                Bs = Bs + b

        k = 7*7
        Rs = int(Rs/k)  
        Gs = int(Gs/k)
        Bs = int(Bs/k)

        smoothing7x7.putpixel((x,y),(Bs,Gs,Rs))

for x in range(1, width-7):
    for y in range(1, height-7):
        Rs = 0
        Gs = 0 
        Bs = 0
        for i in range(x-1, x+8):
            for j in range(y-1, y+8):
                r, g, b = imgPIL.getpixel((i,j))
                Rs = Rs + r
                Gs = Gs + g
                Bs = Bs + b

        k = 9*9
        Rs = int(Rs/k)  
        Gs = int(Gs/k)
        Bs = int(Bs/k)

        smoothing9x9.putpixel((x,y),(Bs,Gs,Rs))

#chuyen anh tu PILLOW sang open cv de mở ảnh bằng opencv
smoothing3x3_CV = np.array(smoothing3x3)
smoothing5x5_CV = np.array(smoothing5x5)
smoothing7x7_CV = np.array(smoothing7x7)
smoothing9x9_CV = np.array(smoothing9x9)


#hien thi anh goc va anh xam        
#cv2.imshow('goc', img)
cv2.imshow('smoothed3x3', smoothing3x3_CV)
cv2.imshow('smoothed5x5', smoothing5x5_CV)
cv2.imshow('smoothed7x7', smoothing7x7_CV)
cv2.imshow('smoothed9x9', smoothing9x9_CV)
#bam phim bat ky de tat cua so
cv2.waitKey(0)
#giai phong bo nho sau khi tat cua so
cv2.destroyAllWindows()