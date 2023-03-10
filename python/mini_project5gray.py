import cv2
from PIL import Image #thư viện PIllow hỗ trợ nhiều định dạng ảnh
import numpy as np 
import matplotlib.pyplot as plt



'''
#hien thi anh goc va anh xam        
cv2.imshow('goc', img)
cv2.imshow('average_gray', anhmucxam_average)
cv2.imshow('lightness_gray', anhmucxam2_lightness)
cv2.imshow('luminance_gray', anhmucxam3_luminance)
'''

def tinh_histogram(hinhxampil1):
    his = np.zeros(256)

    #kich thuoc anh //hinhxampil.size[0] 
    w = hinhxampil1.size[0]
    h = hinhxampil1.size[1]
    
    for x in range(w):
        for y in range(h):
            #lay giá trị điểm xám tại x, y
            gR, gG, gB = hinhxampil1.getpixel((x,y))
            his[gR]+= 1

    return his

def VeBieuDoHistogram(his):
    w = 5
    h = 4
    plt.figure('bieu do histogram anh xam', figsize=(((w,h))),dpi=100)
    trucX = np.zeros(256)
    trucX = np.linspace(0,255,256) #từ 0-255; tất cả 256 giá trị
    plt.plot(trucX,his,color = 'orange')
    plt.title('bieu do histogram')
    plt.xlabel('gia tri muc xam')
    plt.ylabel('so diem cung gia tri muc xam')
    plt.show()


#khai báo đường dẫn file hình
filehinh = r'bird_small.jpg'

#đọc ảnh màu sử dụng thư viện opencv
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)

#sử dụng PILLOW để xử lý tính toán thay cho opencv
imgPIL = Image.open(filehinh)

# ảnh dùng chứa kết quả chuyển đổi từ RBG sang gray (phương pháp average)
average = Image.new(imgPIL.mode, imgPIL.size)
#phuong phap lightness
lightness = Image.new(imgPIL.mode, imgPIL.size)
#phuong phap luminance
luminance = Image.new(imgPIL.mode, imgPIL.size)

#lấy kích thước cao và ngang của ảnh (0 la chieu ngang, 1 la chieu cao)
width = average.size[0]
height = average.size[1]

for x in range(width):
    for y in range(height):
        r, g, b = imgPIL.getpixel((x,y))
        #chuyen sang muc xam
        gray_average = np.uint8((r+g+b)/3)
        gray_lightness = np.uint8((max(r,g,b)+min(r,g,b))/2)
        gray_luminance = np.uint8(r*0.2126 + g*0.7152 + 0.0722*b)

        #nhét giá trị pixel vừa tính ra vào ảnh xám
        average.putpixel((x,y),(gray_average,gray_average,gray_average))
        lightness.putpixel((x,y),(gray_lightness,gray_lightness,gray_lightness))
        luminance.putpixel((x,y),(gray_luminance,gray_luminance,gray_luminance))


his = tinh_histogram(luminance)

anhmucxam_average = np.array(average)
anhmucxam2_lightness = np.array(lightness)
anhmucxam3_luminance = np.array(luminance)

cv2.imshow('luminance_gray', anhmucxam3_luminance)

#bieu do histogram
VeBieuDoHistogram(his)

#bam phim bat ky de tat cua so
cv2.waitKey(0)
#giai phong bo nho sau khi tat cua so
cv2.destroyAllWindows()