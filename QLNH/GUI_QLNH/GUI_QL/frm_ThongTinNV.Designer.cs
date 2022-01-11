
namespace QLNH.GUI_QLNH.GUI_QL
{
    partial class frm_ThongTinNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbt_Male = new System.Windows.Forms.RadioButton();
            this.rbt_Female = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.rtb_Diachi = new System.Windows.Forms.RichTextBox();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.ptb_Picture = new System.Windows.Forms.PictureBox();
            this.lb_TieuDe = new System.Windows.Forms.Label();
            this.cbb_MaNV = new System.Windows.Forms.ComboBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lb_MaNV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(43, 90);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(130, 25);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // rbt_Male
            // 
            this.rbt_Male.AutoSize = true;
            this.rbt_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Male.Location = new System.Drawing.Point(193, 186);
            this.rbt_Male.Name = "rbt_Male";
            this.rbt_Male.Size = new System.Drawing.Size(65, 24);
            this.rbt_Male.TabIndex = 5;
            this.rbt_Male.TabStop = true;
            this.rbt_Male.Text = "Nam";
            this.rbt_Male.UseVisualStyleBackColor = true;
            this.rbt_Male.CheckedChanged += new System.EventHandler(this.rbt_Male_CheckedChanged);
            // 
            // rbt_Female
            // 
            this.rbt_Female.AutoSize = true;
            this.rbt_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Female.Location = new System.Drawing.Point(309, 186);
            this.rbt_Female.Name = "rbt_Female";
            this.rbt_Female.Size = new System.Drawing.Size(51, 24);
            this.rbt_Female.TabIndex = 6;
            this.rbt_Female.TabStop = true;
            this.rbt_Female.Text = "Nữ";
            this.rbt_Female.UseVisualStyleBackColor = true;
            this.rbt_Female.CheckedChanged += new System.EventHandler(this.rbt_Female_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Địa chỉ";
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_HoTen.Location = new System.Drawing.Point(193, 135);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(239, 27);
            this.tb_HoTen.TabIndex = 10;
            // 
            // tb_SDT
            // 
            this.tb_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SDT.Location = new System.Drawing.Point(193, 279);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(167, 27);
            this.tb_SDT.TabIndex = 11;
            // 
            // rtb_Diachi
            // 
            this.rtb_Diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Diachi.Location = new System.Drawing.Point(193, 325);
            this.rtb_Diachi.Name = "rtb_Diachi";
            this.rtb_Diachi.Size = new System.Drawing.Size(295, 96);
            this.rtb_Diachi.TabIndex = 12;
            this.rtb_Diachi.Text = "";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "";
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(193, 227);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(200, 27);
            this.dtp_NgaySinh.TabIndex = 7;
            this.dtp_NgaySinh.Value = new System.DateTime(2021, 5, 21, 0, 0, 0, 0);
            // 
            // ptb_Picture
            // 
            this.ptb_Picture.BackColor = System.Drawing.Color.Gray;
            this.ptb_Picture.Location = new System.Drawing.Point(517, 101);
            this.ptb_Picture.Name = "ptb_Picture";
            this.ptb_Picture.Size = new System.Drawing.Size(227, 202);
            this.ptb_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Picture.TabIndex = 13;
            this.ptb_Picture.TabStop = false;
            // 
            // lb_TieuDe
            // 
            this.lb_TieuDe.AutoSize = true;
            this.lb_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TieuDe.Location = new System.Drawing.Point(186, 22);
            this.lb_TieuDe.Name = "lb_TieuDe";
            this.lb_TieuDe.Size = new System.Drawing.Size(413, 38);
            this.lb_TieuDe.TabIndex = 14;
            this.lb_TieuDe.Text = "Quản lý thông tin nhân viên";
            // 
            // cbb_MaNV
            // 
            this.cbb_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_MaNV.FormattingEnabled = true;
            this.cbb_MaNV.Location = new System.Drawing.Point(193, 87);
            this.cbb_MaNV.Name = "cbb_MaNV";
            this.cbb_MaNV.Size = new System.Drawing.Size(113, 28);
            this.cbb_MaNV.TabIndex = 15;
            this.cbb_MaNV.SelectedIndexChanged += new System.EventHandler(this.cbb_MaNV_SelectedIndexChanged);
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.Gray;
            this.btn_Browse.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Browse.Location = new System.Drawing.Point(572, 314);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(105, 36);
            this.btn_Browse.TabIndex = 16;
            this.btn_Browse.Text = "Chọn ảnh";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(173, 439);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(158, 59);
            this.btn_Update.TabIndex = 17;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Brown;
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(458, 439);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(148, 59);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lb_MaNV
            // 
            this.lb_MaNV.AutoSize = true;
            this.lb_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaNV.Location = new System.Drawing.Point(197, 90);
            this.lb_MaNV.Name = "lb_MaNV";
            this.lb_MaNV.Size = new System.Drawing.Size(41, 25);
            this.lb_MaNV.TabIndex = 19;
            this.lb_MaNV.Text = "lb_";
            // 
            // frm_ThongTinNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.lb_MaNV);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.cbb_MaNV);
            this.Controls.Add(this.lb_TieuDe);
            this.Controls.Add(this.ptb_Picture);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.rtb_Diachi);
            this.Controls.Add(this.tb_SDT);
            this.Controls.Add(this.tb_HoTen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbt_Female);
            this.Controls.Add(this.rbt_Male);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb1);
            this.Name = "frm_ThongTinNV";
            this.Text = "frm_ThongTinNV";
            this.Load += new System.EventHandler(this.frm_ThongTinNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RadioButton rbt_Male;
        public System.Windows.Forms.RadioButton rbt_Female;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tb_HoTen;
        public System.Windows.Forms.TextBox tb_SDT;
        public System.Windows.Forms.RichTextBox rtb_Diachi;
        public System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        public System.Windows.Forms.ComboBox cbb_MaNV;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Update;
        public System.Windows.Forms.PictureBox ptb_Picture;
        public System.Windows.Forms.Label lb1;
        public System.Windows.Forms.Label lb_TieuDe;
        public System.Windows.Forms.Button btn_Delete;
        public System.Windows.Forms.Label lb_MaNV;
    }
}