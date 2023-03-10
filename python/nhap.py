import sys
print(sys.executable)
import cv2            # sử dụng thư viện xử lý ảnh OpenV cho Python
from PIL import Image # Thư viện xử lý ảnh Pillow hỗ trợ nhiều định dạng ảnh
import numpy as np    # Thư viện toán học, đặc biệt là các tính toán ma trận
import math 

# Khai báo đường dẫn file hình
filehinh = r'lena_color.jpg'

# Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread(filehinh, cv2.IMREAD_COLOR)

# Đọc ảnh dùng thư viện Pillow. Ảnh PIL này chúng ta sẽ dùng để thực hiện các tác vụ xử lý & tính toán thay vì dùng OpenCV
imgPIL = Image.open(filehinh)

# Tạo một ảnh có cùng kích thước và mode với ảnh imgPIL
# Ảnh này dùng để chứa kết quả chuyển đổi RGB sang Hue
Hue = Image.new(imgPIL.mode, imgPIL.size)

# Ảnh này dùng để chứa kết quả chuyển đổi RGB sang Saturation
Saturation = Image.new(imgPIL.mode, imgPIL.size)

# Ảnh này dùng để chứa kết quả chuyển đổi RGB sang Intensity
Intensity = Image.new(imgPIL.mode, imgPIL.size)

# Ảnh này dùng để chứa kết quả chuyển đổi RGB sang hình HSI
HSI = Image.new(imgPIL.mode, imgPIL.size)

# lấy kích thước của ảnh
height = imgPIL.size[1]
width = imgPIL.size[0]

# Mỗi hình là 1 ma trận 2 chiều nên sẽ dùng 2 vòng for
# để đọc hết tất cả điểm ảnh (pixel) có trong hình
for x in range(width):
    for y in range(height):
        # lấy giá trị điểm ảnh tại vị trí (x,y)
        R = img[y,x,2]
        G = img[y,x,1]
        B = img[y,x,0]
        # R, G, B = imgPIL.getpixel((x, y))

        # Dựa theo công thức trong sách để viết
        # t1 là phần tử số của công thức
        print(R)

# Bấm phím bất kì để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cập nhật cho các cửa sổ hiển thị hình
cv2.destroyAllWindows()