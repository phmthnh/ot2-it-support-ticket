namespace ITSupportTicket
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpTicket      = new System.Windows.Forms.GroupBox();
            this.lblTicketId    = new System.Windows.Forms.Label();
            this.txtTicketId    = new System.Windows.Forms.TextBox();
            this.lblRequestor   = new System.Windows.Forms.Label();
            this.txtRequestor   = new System.Windows.Forms.TextBox();
            this.lblDate        = new System.Windows.Forms.Label();
            this.dtpDate        = new System.Windows.Forms.DateTimePicker();
            this.lblPriority    = new System.Windows.Forms.Label();
            this.rdoLow         = new System.Windows.Forms.RadioButton();
            this.rdoMedium      = new System.Windows.Forms.RadioButton();
            this.rdoUrgent      = new System.Windows.Forms.RadioButton();
            this.grpDetail      = new System.Windows.Forms.GroupBox();
            this.lblIssueType   = new System.Windows.Forms.Label();
            this.cboIssueType   = new System.Windows.Forms.ComboBox();
            this.lblDevices     = new System.Windows.Forms.Label();
            this.chkDesktop     = new System.Windows.Forms.CheckBox();
            this.chkLaptop      = new System.Windows.Forms.CheckBox();
            this.chkPrinter     = new System.Windows.Forms.CheckBox();
            this.chkPhone       = new System.Windows.Forms.CheckBox();
            this.lblImage       = new System.Windows.Forms.Label();
            this.picError       = new System.Windows.Forms.PictureBox();
            this.btnLoadImage   = new System.Windows.Forms.Button();
            this.btnSubmit      = new System.Windows.Forms.Button();
            this.btnReset       = new System.Windows.Forms.Button();
            this.grpTicket.SuspendLayout();
            this.grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            this.SuspendLayout();

            // grpTicket
            this.grpTicket.Controls.Add(this.lblTicketId);
            this.grpTicket.Controls.Add(this.txtTicketId);
            this.grpTicket.Controls.Add(this.lblRequestor);
            this.grpTicket.Controls.Add(this.txtRequestor);
            this.grpTicket.Controls.Add(this.lblDate);
            this.grpTicket.Controls.Add(this.dtpDate);
            this.grpTicket.Controls.Add(this.lblPriority);
            this.grpTicket.Controls.Add(this.rdoLow);
            this.grpTicket.Controls.Add(this.rdoMedium);
            this.grpTicket.Controls.Add(this.rdoUrgent);
            this.grpTicket.Location = new System.Drawing.Point(12, 12);
            this.grpTicket.Name = "grpTicket";
            this.grpTicket.Size = new System.Drawing.Size(440, 200);
            this.grpTicket.TabIndex = 0;
            this.grpTicket.TabStop = false;
            this.grpTicket.Text = "Thông tin phiếu";

            // lblTicketId
            this.lblTicketId.AutoSize = true;
            this.lblTicketId.Location = new System.Drawing.Point(12, 30);
            this.lblTicketId.Name = "lblTicketId";
            this.lblTicketId.TabIndex = 0;
            this.lblTicketId.Text = "Mã phiếu:";

            // txtTicketId
            this.txtTicketId.Location = new System.Drawing.Point(160, 27);
            this.txtTicketId.Name = "txtTicketId";
            this.txtTicketId.ReadOnly = true;
            this.txtTicketId.Size = new System.Drawing.Size(260, 23);
            this.txtTicketId.TabIndex = 1;
            this.txtTicketId.Text = "TK-AUTO";

            // lblRequestor
            this.lblRequestor.AutoSize = true;
            this.lblRequestor.Location = new System.Drawing.Point(12, 65);
            this.lblRequestor.Name = "lblRequestor";
            this.lblRequestor.TabIndex = 2;
            this.lblRequestor.Text = "Người yêu cầu:";

            // txtRequestor
            this.txtRequestor.Location = new System.Drawing.Point(160, 62);
            this.txtRequestor.Name = "txtRequestor";
            this.txtRequestor.Size = new System.Drawing.Size(260, 23);
            this.txtRequestor.TabIndex = 3;

            // lblDate
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 100);
            this.lblDate.Name = "lblDate";
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Ngày ghi nhận:";

            // dtpDate
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(160, 97);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(260, 23);
            this.dtpDate.TabIndex = 5;

            // lblPriority
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(12, 138);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.TabIndex = 6;
            this.lblPriority.Text = "Mức độ ưu tiên:";

            // rdoLow
            this.rdoLow.AutoSize = true;
            this.rdoLow.Checked = true;
            this.rdoLow.Location = new System.Drawing.Point(160, 136);
            this.rdoLow.Name = "rdoLow";
            this.rdoLow.TabIndex = 7;
            this.rdoLow.TabStop = true;
            this.rdoLow.Text = "Thấp";

            // rdoMedium
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Location = new System.Drawing.Point(240, 136);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.TabIndex = 8;
            this.rdoMedium.Text = "Trung bình";

            // rdoUrgent
            this.rdoUrgent.AutoSize = true;
            this.rdoUrgent.Location = new System.Drawing.Point(350, 136);
            this.rdoUrgent.Name = "rdoUrgent";
            this.rdoUrgent.TabIndex = 9;
            this.rdoUrgent.Text = "Khẩn cấp";

            // grpDetail
            this.grpDetail.Controls.Add(this.lblIssueType);
            this.grpDetail.Controls.Add(this.cboIssueType);
            this.grpDetail.Controls.Add(this.lblDevices);
            this.grpDetail.Controls.Add(this.chkDesktop);
            this.grpDetail.Controls.Add(this.chkLaptop);
            this.grpDetail.Controls.Add(this.chkPrinter);
            this.grpDetail.Controls.Add(this.chkPhone);
            this.grpDetail.Controls.Add(this.lblImage);
            this.grpDetail.Controls.Add(this.picError);
            this.grpDetail.Controls.Add(this.btnLoadImage);
            this.grpDetail.Location = new System.Drawing.Point(12, 225);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(440, 280);
            this.grpDetail.TabIndex = 1;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "Phân loại & Chi tiết";

            // lblIssueType
            this.lblIssueType.AutoSize = true;
            this.lblIssueType.Location = new System.Drawing.Point(12, 30);
            this.lblIssueType.Name = "lblIssueType";
            this.lblIssueType.TabIndex = 0;
            this.lblIssueType.Text = "Loại sự cố:";

            // cboIssueType
            this.cboIssueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIssueType.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            this.cboIssueType.Location = new System.Drawing.Point(160, 27);
            this.cboIssueType.Name = "cboIssueType";
            this.cboIssueType.Size = new System.Drawing.Size(260, 23);
            this.cboIssueType.TabIndex = 1;
            this.cboIssueType.SelectedIndex = 0;

            // lblDevices
            this.lblDevices.AutoSize = true;
            this.lblDevices.Location = new System.Drawing.Point(12, 68);
            this.lblDevices.Name = "lblDevices";
            this.lblDevices.TabIndex = 2;
            this.lblDevices.Text = "Thiết bị ảnh hưởng:";

            // chkDesktop
            this.chkDesktop.AutoSize = true;
            this.chkDesktop.Location = new System.Drawing.Point(160, 66);
            this.chkDesktop.Name = "chkDesktop";
            this.chkDesktop.TabIndex = 3;
            this.chkDesktop.Text = "Máy tính bàn";

            // chkLaptop
            this.chkLaptop.AutoSize = true;
            this.chkLaptop.Location = new System.Drawing.Point(280, 66);
            this.chkLaptop.Name = "chkLaptop";
            this.chkLaptop.TabIndex = 4;
            this.chkLaptop.Text = "Laptop";

            // chkPrinter
            this.chkPrinter.AutoSize = true;
            this.chkPrinter.Location = new System.Drawing.Point(160, 96);
            this.chkPrinter.Name = "chkPrinter";
            this.chkPrinter.TabIndex = 5;
            this.chkPrinter.Text = "Máy in";

            // chkPhone
            this.chkPhone.AutoSize = true;
            this.chkPhone.Location = new System.Drawing.Point(280, 96);
            this.chkPhone.Name = "chkPhone";
            this.chkPhone.TabIndex = 6;
            this.chkPhone.Text = "Điện thoại";

            // lblImage
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(12, 130);
            this.lblImage.Name = "lblImage";
            this.lblImage.TabIndex = 7;
            this.lblImage.Text = "Ảnh chụp lỗi:";

            // picError
            this.picError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picError.Location = new System.Drawing.Point(160, 128);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(140, 110);
            this.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picError.TabIndex = 8;
            this.picError.TabStop = false;

            // btnLoadImage
            this.btnLoadImage.BackColor = System.Drawing.Color.FromArgb(100, 100, 180);
            this.btnLoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadImage.ForeColor = System.Drawing.Color.White;
            this.btnLoadImage.Location = new System.Drawing.Point(312, 155);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(110, 35);
            this.btnLoadImage.TabIndex = 9;
            this.btnLoadImage.Text = "Tải ảnh lỗi";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);

            // btnSubmit
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(0, 150, 100);
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(12, 520);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 40);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Gửi yêu cầu";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // btnReset
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(120, 100, 120);
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(320, 520);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 40);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Nhập lại";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 578);
            this.Controls.Add(this.grpTicket);
            this.Controls.Add(this.grpDetail);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BT2 - Form Tiếp nhận & Phân loại sự cố IT";
            this.Load += new System.EventHandler((s, e) => { txtTicketId.Text = GenerateTicketId(); });

            this.grpTicket.ResumeLayout(false);
            this.grpTicket.PerformLayout();
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpTicket;
        private System.Windows.Forms.Label lblTicketId;
        private System.Windows.Forms.TextBox txtTicketId;
        private System.Windows.Forms.Label lblRequestor;
        private System.Windows.Forms.TextBox txtRequestor;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.RadioButton rdoLow;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoUrgent;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Label lblIssueType;
        private System.Windows.Forms.ComboBox cboIssueType;
        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.CheckBox chkDesktop;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkPrinter;
        private System.Windows.Forms.CheckBox chkPhone;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
    }
}
