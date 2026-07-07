# Danh sách code C / C++ / C# / Java đã sắp xếp theo chức năng

Thư mục này gom toàn bộ file code từ backup Gmail, đổi tên để đọc tên file là biết chức năng — **không cần chạy thử**.

> File gốc vẫn giữ nguyên ở vị trí cũ. Đây là bản **sao có tên mô tả** để tra cứu.

---

## 01-Cpp-Thuat-Toan-Sap-Xep (3 file)

| Tên mới | Tên cũ | Chức năng |
|---------|--------|-----------|
| `BubbleSort_SapXepNoiBot.cpp` | `1BubbleSortAlgorithm.cpp` | Nhập mảng, sắp xếp tăng dần bằng Bubble Sort |
| `SelectionSort_SapXepChon.cpp` | `2SelectionSortAlgorithm.cpp` | Sắp xếp tăng dần bằng Selection Sort |
| `InsertionSort_SapXepChen.cpp` | `3InsertionSortAlgorithm.cpp` | Sắp xếp tăng dần bằng Insertion Sort |

---

## 02-CSharp-Thuat-Toan-Console (7 file)

Tách từ `FPT/Program.cs` (một file chứa nhiều hàm, tên thư mục FPT gây hiểu nhầm).

| Tên file | Chức năng |
|----------|-----------|
| `BubbleSort_SapXepNoiBot.cs` | Sắp xếp nổi bọt trên List<int> |
| `SelectionSort_SapXepChon.cs` | Sắp xếp chọn trên List<int> |
| `InsertionSort_SapXepChen.cs` | Sắp xếp chèn trên List<int> |
| `TimMaxTrongMang.cs` | Tìm phần tử lớn nhất trong mảng |
| `TimMaxThuHaiTrongMang.cs` | Tìm phần tử lớn thứ hai |
| `TimSoNguyenTo.cs` | Liệt kê số nguyên tố từ 1 đến 7 |
| `TimMaxBaSo.cs` | Tìm max trong 3 số a, b, c |

---

## 03-CSharp-WinForm-QuanLyDoiBong (23 file + SQL)

**Ứng dụng:** Quản lý đội bóng (người dùng, HLV, cầu thủ) — SQL Server, WinForms.

| Tên mới | Tên cũ | Chức năng |
|---------|--------|-----------|
| `00_Program_DiemVaoUngDung.cs` | `Program.cs` | Khởi chạy app, mở form đăng nhập |
| `01_DangNhap_XacThucTaiKhoan.cs` | `Form1.cs` | Đăng nhập: kiểm tra id/pass trong CSDL |
| `02_TrangChinh_HienThiNguoiDung_HLV_CauThu.cs` | `Chinh.cs` | Trang chính: 3 bảng + menu CRUD theo quyền |
| `03_ThemNguoiDung.cs` | `ThemND.cs` | Thêm tài khoản người dùng |
| `04_SuaNguoiDung.cs` | `SuaND.cs` | Sửa thông tin người dùng |
| `05_XoaNguoiDung.cs` | `XoaND.cs` | Xóa người dùng |
| `06_ThemHuanLuyenVien.cs` | `ThemHLV.cs` | Thêm huấn luyện viên |
| `07_SuaHuanLuyenVien.cs` | `SuaHLV.cs` | Sửa HLV |
| `08_XoaHuanLuyenVien.cs` | `XoaHLV.cs` | Xóa HLV |
| `09_ThemCauThu.cs` | `ThemCT.cs` | Thêm cầu thủ |
| `10_SuaCauThu.cs` | `SuaCT.cs` | Sửa cầu thủ |
| `11_XoaCauThu.cs` | `XoaCT.cs` | Xóa cầu thủ |
| `QLDOIBONG_CoSoDuLieu.sql` | `QLDOIBONG.sql` | Script tạo CSDL |

File `.Designer.cs` đi kèm = giao diện (nút, textbox, layout).

---

## 04-CSharp-WinForm-QuanLySinhVien

### PhienBan1_QLSV (từ `hetmonwinform/QLSV.rar`)

| Tên mới | Tên cũ | Chức năng |
|---------|--------|-----------|
| `00_Program_DiemVaoUngDung.cs` | `Program.cs` | Điểm vào ứng dụng |
| `01_DangNhap.cs` | `dangnhap.cs` | Form đăng nhập |
| `02_DoiMatKhau.cs` | `doimatkhau.cs` | Đổi mật khẩu |
| `03_KetNoiCSDL.cs` | `KetNoi.cs` | Class kết nối SQL Server |
| `04_TrangChinh_QuanLySinhVien.cs` | `qlsv.cs` | Trang chính quản lý SV |
| `05_ThemSuaXoaSinhVien.cs` | `themsuaxoa.cs` | Thêm / sửa / xóa sinh viên |
| `06_TimKiemSinhVien.cs` | `timkiem.cs` | Tìm kiếm sinh viên |

### PhienBan2_HoanThanh (từ `quanlysinhvienhoanthanh.zip`)

| Tên mới | Tên cũ | Chức năng |
|---------|--------|-----------|
| `00_Program_DiemVaoUngDung.cs` | `Program.cs` | Điểm vào ứng dụng |
| `01_DangNhap.cs` | `fdangnhap.cs` | Đăng nhập |
| `02_DoiMatKhau.cs` | `fdoimatkhau.cs` | Đổi mật khẩu |
| `03_KetNoiCSDL.cs` | `KetNoi.cs` | Kết nối CSDL |
| `04_TrangChinh_QuanLySinhVien.cs` | `fQLSV.cs` | Trang chính |
| `05_CapNhatThongTinSinhVien.cs` | `fcapnhat.cs` | Cập nhật thông tin SV |
| `06_TimKiemSinhVien.cs` | `ftimkiem.cs` | Tìm kiếm SV |

---

## 05-Java-IO-DocGhiFile (4 file)

| Tên mới | Tên cũ | Chức năng |
|---------|--------|-----------|
| `SaoChepFile_ByteStream_CoDinh_vao_ra_txt.java` | `ByteStreamDemo.java` | Sao chép `E:\vao.txt` → `E:\ra.txt` bằng byte stream |
| `SaoChepFile_ByteStream_NhapTenTep.java` | `LuongByte.java` | Nhập tên 2 file, sao chép bằng byte stream |
| `TimDongTrungKhopTrongFile.java` | `temp.java` | Nhập 1 dòng, tìm dòng trùng trong file text |
| `DemTuKhoaTrongFile.java` | `StringFinder.java` | Đếm số lần xuất hiện từ khóa + dòng chứa từ |

---

## 06-Java-Console-ThuatToan (1 file)

| Tên mới | Tên cũ | Chức năng |
|---------|--------|-----------|
| `GiaiPhuongTrinhBacHai.java` | `hht/QuadraticEquation.java` | Giải phương trình ax² + bx + c = 0 |

---

## 07-Java-OOP-KeThua (2 file)

| Tên mới | Tên cũ | Chức năng |
|---------|--------|-----------|
| `LopCoSo_DongVat.java` | `hht/Animal.java` | Lớp cơ sở Animal, method `checkStatus()` |
| `LopCho_KeThuaDongVat.java` | `hht/Dog.java` | Lớp Dog kế thừa Animal: bark, run, getAge |

---

## 08-Java-AWT-Layout (4 file)

Bài tập học **bố cục giao diện** Java AWT.

| Tên mới | Tên cũ | Chức năng |
|---------|--------|-----------|
| `BorderLayout_ViDu5Vung.java` | `hht/Bltest.java` | BorderLayout: North/Center/West/East/South |
| `FlowLayout_ViDuCanGiua.java` | `hht/Fltest.java` | FlowLayout căn giữa 3 nút |
| `GridLayout_ViDuLuoi3x3.java` | `hht/Gltest.java` | GridLayout lưới 3×3 (9 nút số) |
| `GridBagLayout_ViDuPhucTap.java` | `hht/Gbltest.java` | GridBagLayout: TextArea, Button, Checkbox |

---

## 09-Java-AWT-Components (7 file)

Bài tập học **thành phần giao diện** Java AWT.

| Tên mới | Tên cũ | Chức năng |
|---------|--------|-----------|
| `Button_ViDu3Nut.java` | `hht/Buttontest.java` | 3 nút Red/Green/Blue |
| `Label_ViDuNhan.java` | `hht/Labeltest.java` | Hiển thị Label đơn giản |
| `TextField_ViDuONhap.java` | `hht/TextFieldtest.java` | Ô nhập TextField |
| `TextArea_ViDuVungVanBan.java` | `hht/TextAreatest.java` | Vùng nhập nhiều dòng TextArea |
| `Checkbox_RadioButton_ViDu.java` | `hht/Checkboxtest.java` | Checkbox + Radio button |
| `Choice_DropdownChonMau.java` | `hht/Choicetest.java` | Dropdown chọn màu |
| `Panel_ViDuKhungChua.java` | `hht/Paneltest.java` | Panel chứa trong Frame |

---

## 10-Java-AWT-Events-Menu (4 file)

| Tên mới | Tên cũ | Chức năng |
|---------|--------|-----------|
| `XuLySuKien_NhanDoiSo.java` | `hht/evttest.java` | Nhập số → nhấn nút → hiện gấp đôi |
| `Frame_CuaSoDonGian.java` | `hht/FrameDemo.java` | Tạo cửa sổ Frame cơ bản |
| `Menu_PopupMenu_ViDu.java` | `hht/MyFrame.java` | MenuBar + PopupMenu (bài học menu) |
| `Calculator_GridLayout_MenuThoat.java` | `MyFrame.java` (gốc) | Máy tính dạng lưới 4×4 + menu Exit |

---

## 11-Java-AWT-Calculator (3 file)

3 phiên bản **máy tính AWT** (cùng class `MyCalculator`, khác giao diện).

| Tên mới | Tên cũ | Chức năng |
|---------|--------|-----------|
| `MayTinhAWT_PhienBanCoBan_InnerClasses.java` | `MyCalculator.java` | Máy tính cơ bản + inner class cho từng loại nút |
| `MayTinhAWT_PhienBanDarkUI.java` | `MyCalculator1.java` | Giao diện tối, nút CE/C/Backspace |
| `MayTinhAWT_PhienBanDayDu_MenuChuyenDoi.java` | `MyCalculator (1).java` | Đầy đủ nhất: menu Standard/Scientific, bộ nhớ MC/MR/M+ |

---

## Sách PDF Java (chưa đổi tên, ở thư mục gốc)

Trong `java-20260705T144158Z-3-001/java/` còn **5 file PDF** sách học:
- Java 8 The Complete Reference
- Java A Beginner's Guide (nhiều bản)
- OCA/OCP Java SE 7 Study Guide

---

## Lưu ý

- **Không có file `.c` thuần** trong backup đã giải nén — chỉ có **3 file `.cpp`**, **~50 file `.cs`**, **25 file `.java`**.
- File WinForms **đổi tên file** nhưng **tên class bên trong vẫn giữ nguyên** (Form1, Chinh, ThemND...) — đủ để đọc hiểu, không dùng để build lại trực tiếp.
- Nếu cần chạy project gốc, dùng thư mục `Tailieuquantrong` hoặc `hetmonwinform` với tên file cũ.
