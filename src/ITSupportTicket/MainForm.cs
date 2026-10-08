namespace ITSupportTicket
{
    public partial class MainForm : Form
    {
        private string? _selectedImagePath = null;

        public MainForm()
        {
            InitializeComponent();
            dtpDate.Value = DateTime.Now;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            txtTicketId.Text = GenerateTicketId();
        }

        // --- Tải ảnh lỗi ---
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Title = "Chọn ảnh chụp lỗi";
            dlg.Filter = "Hình ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadErrorImage(dlg.FileName);
            }
        }

        private bool LoadErrorImage(string path)
        {
            try
            {
                // Sao chép ảnh để đóng stream mà không khóa tệp gốc.
                using var fs = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                using var source = Image.FromStream(fs);
                var bmp = new Bitmap(source);
                picError.Image?.Dispose();
                picError.Image = bmp;
                _selectedImagePath = path;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Không thể tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // --- Gửi yêu cầu ---
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRequestor.Text))
            {
                MessageBox.Show(this, "Vui lòng nhập Người yêu cầu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRequestor.Focus();
                return;
            }

            // Lấy mức độ ưu tiên
            string priority = rdoLow.Checked ? "Thấp" : rdoMedium.Checked ? "Trung bình" : "Khẩn cấp";

            // Lấy thiết bị ảnh hưởng
            var devices = new System.Text.StringBuilder();
            if (chkDesktop.Checked)  devices.Append("Máy tính bàn, ");
            if (chkLaptop.Checked)   devices.Append("Laptop, ");
            if (chkPrinter.Checked)  devices.Append("Máy in, ");
            if (chkPhone.Checked)    devices.Append("Điện thoại, ");
            string deviceList = devices.Length > 0 ? devices.ToString().TrimEnd(',', ' ') : "(Không chọn)";

            string summary =
                $"Mã phiếu    : {txtTicketId.Text}\n" +
                $"Người yêu cầu: {txtRequestor.Text}\n" +
                $"Ngày ghi nhận: {dtpDate.Value:dd/MM/yyyy}\n" +
                $"Mức độ ưu tiên: {priority}\n" +
                $"Loại sự cố   : {cboIssueType.Text}\n" +
                $"Thiết bị ảnh hưởng: {deviceList}\n" +
                $"Ảnh đính kèm : {(_selectedImagePath != null ? System.IO.Path.GetFileName(_selectedImagePath) : "Không có")}";

            MessageBox.Show(this, summary, "📋 Tóm tắt phiếu yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- Nhập lại ---
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTicketId.Text = GenerateTicketId();
            txtRequestor.Clear();
            dtpDate.Value = DateTime.Now;
            rdoLow.Checked = true;
            cboIssueType.SelectedIndex = 0;
            chkDesktop.Checked = false;
            chkLaptop.Checked = false;
            chkPrinter.Checked = false;
            chkPhone.Checked = false;
            if (picError.Image != null) { picError.Image.Dispose(); picError.Image = null; }
            _selectedImagePath = null;
        }

        private string GenerateTicketId()
        {
            return $"TK-{DateTime.Now:yyyyMMddHHmmss}";
        }
    }
}
