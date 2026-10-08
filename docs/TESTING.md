# Kiểm thử — Bài 2 — Form Tiếp nhận & Phân loại sự cố IT

Ngày chạy: 08/10/2026. Môi trường: Windows, .NET SDK 10.0.401.

Đã chạy 13/13 kiểm tra đạt với vi-VN.

Các kiểm tra chạy trên form thật: hiển thị control, gọi handler, nhập/sửa dữ liệu và xử lý MessageBox. Hộp thoại xác nhận được chương trình kiểm tra trả lời Yes/No tự động. Bộ kiểm tra được chạy ngoài repo để không trộn công cụ audit vào bài nộp.

| Kiểm tra đã chạy | Kết quả |
|---|---|
| `ticket_id` | PASS |
| `stretch_image` | PASS |
| `missing_requestor` | PASS |
| `load_image` | PASS |
| `image_file_unlocked` | PASS |
| `image_renders_after_stream_closed` | PASS |
| `summary` | PASS |
| `summary_choices` | PASS |
| `corrupt_image_handled` | PASS |
| `reset` | PASS |
| `file_picker_filename_control` | PASS |
| `open_dialog_loads_png` | PASS |
| `open_dialog_releases_file` | PASS |

Kết quả chi tiết: [test-results.json](./test-results.json).

## Kiểm tra thêm trước khi nộp

- [ ] Mở solution bằng Visual Studio 2026, chọn MainForm.cs → Shift+F7 và kiểm tra kéo thả trong Toolbox.
- [ ] Chạy F5, đi qua các bước ở README bằng bàn phím/chuột.
- [ ] Kiểm tra giao diện ở DPI/cỡ màn hình đang dùng.
- [ ] Đối chiếu ảnh screenshot với kết quả chạy thực tế.
- [ ] Kiểm tra thêm tệp jpg trên máy của bạn; thao tác OpenFileDialog chọn png và xử lý nạp/render/ảnh hỏng đã được kiểm tra tự động.
