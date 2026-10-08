# BÁO CÁO BÀI TẬP / ĐỒ ÁN

## THÔNG TIN SINH VIÊN
- **Họ và tên:** Phạm Tuấn Thành
- **Mã số sinh viên:** 24810320264
- **Tên môn học:** Lập trình C# / Windows Forms
- **Tên bài tập:** BT2 - Form Tiếp nhận & Phân loại sự cố IT

---

## MÔ TẢ BÀI TẬP
Form tiếp nhận phiếu yêu cầu hỗ trợ IT sử dụng đa dạng các Control.

**Controls sử dụng:** RadioButton, CheckBox, ComboBox, DateTimePicker, PictureBox, OpenFileDialog

**Tính năng:**
- Nhập thông tin phiếu (mã tự sinh, người yêu cầu, ngày)
- Chọn mức độ ưu tiên bằng RadioButton (Thấp / Trung bình / Khẩn cấp)
- Chọn loại sự cố qua ComboBox
- Tick chọn thiết bị ảnh hưởng qua CheckBox
- Tải ảnh lỗi lên PictureBox (OpenFileDialog lọc .jpg/.png)
- Tóm tắt toàn bộ thông tin qua MessageBox khi Gửi yêu cầu

---

## KẾT QUẢ THỰC HÀNH

### 1. Ảnh màn hình Giao diện chính
![Giao diện chính](./screenshots/main_ui.png)

### 2. Ảnh màn hình Chức năng thực thi / Kết quả
![Thực thi chức năng](./screenshots/execution_result.png)

### 3. Ảnh màn hình Kiểm tra lỗi (Validation)
![Kiểm tra lỗi](./screenshots/validation_error.png)

---

## CÁCH CHẠY
- Yêu cầu: .NET 10.0 SDK + Windows
- Mở file `ITSupportTicket.sln` bằng Visual Studio 2022/2026
- Nhấn **F5** để chạy
