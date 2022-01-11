
namespace QLNH.GUI_QLNH.GUI_QL
{
    partial class frm_AddNhanVien
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ptb_Picture = new System.Windows.Forms.PictureBox();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rtb_Diachi = new System.Windows.Forms.RichTextBox();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbt_Female = new System.Windows.Forms.RadioButton();
            this.rbt_Male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.tb_RePass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(280, 471);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(221, 71);
            this.btn_Add.TabIndex = 35;
            this.btn_Add.Text = "Thêm nhân viên";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.Gray;
            this.btn_Browse.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Browse.Location = new System.Drawing.Point(618, 249);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(105, 36);
            this.btn_Browse.TabIndex = 34;
            this.btn_Browse.Text = "Chọn ảnh";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(411, 38);
            this.label7.TabIndex = 32;
            this.label7.Text = "Đăng kí thông tin nhân viên";
            // 
            // ptb_Picture
            // 
            this.ptb_Picture.BackColor = System.Drawing.Color.Gray;
            this.ptb_Picture.Location = new System.Drawing.Point(552, 41);
            this.ptb_Picture.Name = "ptb_Picture";
            this.ptb_Picture.Size = new System.Drawing.Size(227, 202);
            this.ptb_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Picture.TabIndex = 31;
            this.ptb_Picture.TabStop = false;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "";
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(176, 216);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(200, 27);
            this.dtp_NgaySinh.TabIndex = 26;
            this.dtp_NgaySinh.Value = new System.DateTime(2021, 5, 21, 0, 0, 0, 0);
            // 
            // rtb_Diachi
            // 
            this.rtb_Diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Diachi.Location = new System.Drawing.Point(176, 332);
            this.rtb_Diachi.Name = "rtb_Diachi";
            this.rtb_Diachi.Size = new System.Drawing.Size(284, 117);
            this.rtb_Diachi.TabIndex = 30;
            this.rtb_Diachi.Text = "";
            // 
            // tb_SDT
            // 
            this.tb_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SDT.Location = new System.Drawing.Point(176, 270);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(167, 27);
            this.tb_SDT.TabIndex = 29;
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_HoTen.Location = new System.Drawing.Point(176, 116);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(239, 27);
            this.tb_HoTen.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Số điện thoại";
            // 
            // rbt_Female
            // 
            this.rbt_Female.AutoSize = true;
            this.rbt_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Female.Location = new System.Drawing.Point(307, 167);
            this.rbt_Female.Name = "rbt_Female";
            this.rbt_Female.Size = new System.Drawing.Size(51, 24);
            this.rbt_Female.TabIndex = 24;
            this.rbt_Female.TabStop = true;
            this.rbt_Female.Text = "Nữ";
            this.rbt_Female.UseVisualStyleBackColor = true;
            this.rbt_Female.CheckedChanged += new System.EventHandler(this.rbt_Female_CheckedChanged);
            // 
            // rbt_Male
            // 
            this.rbt_Male.AutoSize = true;
            this.rbt_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Male.Location = new System.Drawing.Point(200, 167);
            this.rbt_Male.Name = "rbt_Male";
            this.rbt_Male.Size = new System.Drawing.Size(65, 24);
            this.rbt_Male.TabIndex = 23;
            this.rbt_Male.TabStop = true;
            this.rbt_Male.Text = "Nam";
            this.rbt_Male.UseVisualStyleBackColor = true;
            this.rbt_Male.CheckedChanged += new System.EventHandler(this.rbt_Male_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(493, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tên đăng nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(493, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "Nhập lại MK";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(493, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 25);
            this.label10.TabIndex = 38;
            this.label10.Text = "Mật khẩu";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UserName.Location = new System.Drawing.Point(644, 333);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(153, 27);
            this.tb_UserName.TabIndex = 39;
            // 
            // tb_Pass
            // 
            this.tb_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pass.Location = new System.Drawing.Point(618, 376);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.Size = new System.Drawing.Size(140, 27);
            this.tb_Pass.TabIndex = 40;
            // 
            // tb_RePass
            // 
            this.tb_RePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RePass.Location = new System.Drawing.Point(618, 422);
            this.tb_RePass.Name = "tb_RePass";
            this.tb_RePass.Size = new System.Drawing.Size(140, 27);
            this.tb_RePass.TabIndex = 41;
            // 
            // frm_AddNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 554);
            this.Controls.Add(this.tb_RePass);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.label1);
            this.Name = "frm_AddNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AddNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.PictureBox ptb_Picture;
        public System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        public System.Windows.Forms.RichTextBox rtb_Diachi;
        public System.Windows.Forms.TextBox tb_SDT;
        public System.Windows.Forms.TextBox tb_HoTen;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.RadioButton rbt_Female;
        public System.Windows.Forms.RadioButton rbt_Male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tb_UserName;
        public System.Windows.Forms.TextBox tb_Pass;
        public System.Windows.Forms.TextBox tb_RePass;
    }
}