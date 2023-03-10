import cv2                  #opencv lib
import numpy as np          #thu vien tinh toan ma tran
#Võ Ngọc Anh Tuấn 20146543
img = cv2.imread('lena_color.jpg', cv2.IMREAD_COLOR)

height = len(img[0])
width = len(img[1])

#khai báo 3 biến chứa hình 3 kênh rgb
red = np.zeros((height, width, 3), np.uint8) #số 3 đại diện cho 3 lớp kênh RGB, mỗi kênh 8bit
green = np.zeros((height, width, 3), np.uint8)
blue = np.zeros((height, width, 3), np.uint8)

#ĐẶT CÁC GIÁ TRỊ CỦA MA TRẬN VỀ 0 HẾT
red [:] = [0,0,0]
green [:] = [0,0,0]
blue [:] = [0,0,0]

#tương tự bên C#. dùng 2 vòng for
for x in range(width):
    for y in range(height): #red kênh 2, blue kênh 0, green kênh 1
        R = img[x,y,2]
        G = img[x,y,1]
        B = img[x,y,0]
        #thiết lập màu cho các kênh
        red[x,y,2] = R
        green[x,y,1] = G
        blue[x,y,0] = B


cv2.imshow('hinh mau RGB goc', img)
cv2.imshow('red', red)
cv2.imshow('green', green)
cv2.imshow('blue', blue)

#bam phim bat ky de tat cua so
cv2.waitKey(0)
#giai phong bo nho sau khi tat cua so
cv2.destroyAllWindows()