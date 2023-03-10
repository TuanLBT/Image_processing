import cv2                       # sử dụng thư viện xử lý ảnh OpenV cho Python
from PIL import Image            # Thư viện xủ lý ảnh Pillow hỗ trợ nhiều định dạng ảnh
import numpy as np               # Thư viện toán học, đặc biệt là các tính toán ma trận
import matplotlib.pyplot as plt  # Thư viện vẽ biểu đồ


# =========================================================================================
# Tính histogram của ảnh RGB
# =========================================================================================
def TinhHistogram(rgbPIL):
    # Kích thước ảnh
    w = rgbPIL.size[0]
    h = rgbPIL.size[1]

    his_red = np.zeros(256) #numpy.zeros((row,column)), dtype=float, order='C', *, like=None)
    his_green = np.zeros(256)
    his_blue = np.zeros(256)

    for x in range (w):
        for y in range (h):
            # Lấy giá trị RGB tại điểm (x, y)
            R, G, B = rgbPIL.getpixel((x, y))

            his_red[R] +=1
            his_green[G] +=1
            his_blue[B] +=1
    return his_red, his_green, his_blue
# =========================================================================================
# End: TinhHistogram(HinhXamPIL)
# =========================================================================================

# =========================================================================================
# Vẽ biểu đồ Histogram dùng thư viên matplotlib
# =========================================================================================
def VeBieuDoHistogram(his_r, his_g, his_b):
    w = 5
    h = 4
    plt.figure("Biểu đồ histogram ảnh xám", figsize=(((w,h))), dpi=100)
    trucX_red = np.zeros(256) #tạo mảng gồm có 1 hàng 256 phần tử
    trucX_red = np.linspace(0, 256, 256)#np.linspace(begin value, end element, number of element)
    plt.plot(trucX_red, his_r, color ="red")

    trucX_green = np.zeros(256)
    trucX_green = np.linspace(0, 256, 256)
    plt.plot(trucX_green, his_g, color ="green")

    trucX_blue = np.zeros(256)
    trucX_blue = np.linspace(0, 256, 256)
    plt.plot(trucX_blue, his_b, color ="blue")

    plt.title("Biểu đồ Histogram")
    plt.xlabel("Giá trị mức xám")
    plt.ylabel("Số điểm cùng giá trị mức xám")
    plt.show()
# =========================================================================================
# End: VeBieuDoHistogram(his)
# =========================================================================================

# =========================================================================================
# --------------------------------Begin: CHƯƠNG TRÌNH CHÍNH--------------------------------
# Lưu ý các hàm con phải khai báo trước khi chương trình chính gọi
# =========================================================================================
# Khai báo đường dẫn file hình
filehinh = r"bird_small.jpg"

# Đọc ảnh dùng thư viện PIL
rgbPIL = Image.open(filehinh)

# Tính Histogram
his1, his2, his3 = TinhHistogram(rgbPIL)


# Hiển thị biểu đồ Histogram
VeBieuDoHistogram(his1, his2, his3)

# Bấm phím bất kì thoát chương trình
cv2.waitKey(0)

# Giải phóng bộ nhớ đã cấp phát cho các cửa sổ
cv2.destroyAllWindows()

# =========================================================================================
# --------------------------------End: CHƯƠNG TRÌNH CHÍNH--------------------------------
# =========================================================================================