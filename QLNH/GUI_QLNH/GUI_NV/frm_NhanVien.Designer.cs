
namespace QLNH.GUI_QLNH.GUI_NV
{
    partial class frm_NhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NhanVien));
            this.llb_EditPass = new System.Windows.Forms.LinkLabel();
            this.lb_CheckIn = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.llb_EditTT = new System.Windows.Forms.LinkLabel();
            this.lb_CheckOut = new System.Windows.Forms.Label();
            this.ptb_Picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_BanHang = new System.Windows.Forms.Button();
            this.lb_Name = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_LichLam = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbt_CheckIn = new FontAwesome.Sharp.IconButton();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Picture)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // llb_EditPass
            // 
            this.llb_EditPass.AutoSize = true;
            this.llb_EditPass.LinkColor = System.Drawing.Color.SteelBlue;
            this.llb_EditPass.Location = new System.Drawing.Point(582, 237);
            this.llb_EditPass.Name = "llb_EditPass";
            this.llb_EditPass.Size = new System.Drawing.Size(91, 17);
            this.llb_EditPass.TabIndex = 16;
            this.llb_EditPass.TabStop = true;
            this.llb_EditPass.Text = "Đổi mật khẩu";
            this.llb_EditPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_EditPass_LinkClicked);
            // 
            // lb_CheckIn
            // 
            this.lb_CheckIn.AutoSize = true;
            this.lb_CheckIn.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CheckIn.ForeColor = System.Drawing.Color.Chartreuse;
            this.lb_CheckIn.Location = new System.Drawing.Point(348, 491);
            this.lb_CheckIn.Name = "lb_CheckIn";
            this.lb_CheckIn.Size = new System.Drawing.Size(73, 28);
            this.lb_CheckIn.TabIndex = 14;
            this.lb_CheckIn.Text = "label3";
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Date.Location = new System.Drawing.Point(151, 372);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(51, 19);
            this.lb_Date.TabIndex = 13;
            this.lb_Date.Text = "label3";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_time.Location = new System.Drawing.Point(148, 322);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(101, 37);
            this.lb_time.TabIndex = 12;
            this.lb_time.Text = "label3";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Snow;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Snow;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 101;
            this.iconPictureBox1.Location = new System.Drawing.Point(53, 308);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(297, 101);
            this.iconPictureBox1.TabIndex = 11;
            this.iconPictureBox1.TabStop = false;
            // 
            // llb_EditTT
            // 
            this.llb_EditTT.AutoSize = true;
            this.llb_EditTT.LinkColor = System.Drawing.Color.SteelBlue;
            this.llb_EditTT.Location = new System.Drawing.Point(454, 237);
            this.llb_EditTT.Name = "llb_EditTT";
            this.llb_EditTT.Size = new System.Drawing.Size(92, 17);
            this.llb_EditTT.TabIndex = 10;
            this.llb_EditTT.TabStop = true;
            this.llb_EditTT.Text = "Sửa thông tin";
            this.llb_EditTT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_EditTT_LinkClicked);
            // 
            // lb_CheckOut
            // 
            this.lb_CheckOut.AutoSize = true;
            this.lb_CheckOut.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CheckOut.ForeColor = System.Drawing.Color.Aqua;
            this.lb_CheckOut.Location = new System.Drawing.Point(348, 600);
            this.lb_CheckOut.Name = "lb_CheckOut";
            this.lb_CheckOut.Size = new System.Drawing.Size(73, 28);
            this.lb_CheckOut.TabIndex = 15;
            this.lb_CheckOut.Text = "label4";
            // 
            // ptb_Picture
            // 
            this.ptb_Picture.BackColor = System.Drawing.Color.Silver;
            this.ptb_Picture.Location = new System.Drawing.Point(719, 168);
            this.ptb_Picture.Name = "ptb_Picture";
            this.ptb_Picture.Size = new System.Drawing.Size(165, 160);
            this.ptb_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Picture.TabIndex = 7;
            this.ptb_Picture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(104, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chào mừng đến với trang nhân viên";
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 701);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(300, 52);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_BanHang
            // 
            this.btn_BanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_BanHang.FlatAppearance.BorderSize = 0;
            this.btn_BanHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btn_BanHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btn_BanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BanHang.ForeColor = System.Drawing.Color.Silver;
            this.btn_BanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BanHang.Location = new System.Drawing.Point(0, 210);
            this.btn_BanHang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_BanHang.Name = "btn_BanHang";
            this.btn_BanHang.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btn_BanHang.Size = new System.Drawing.Size(300, 52);
            this.btn_BanHang.TabIndex = 8;
            this.btn_BanHang.Text = "  Trang bán hàng";
            this.btn_BanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_BanHang.UseVisualStyleBackColor = true;
            this.btn_BanHang.Click += new System.EventHandler(this.btn_BanHang_Click);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Name.Location = new System.Drawing.Point(451, 187);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(222, 35);
            this.lb_Name.TabIndex = 8;
            this.lb_Name.Text = "Phạm Việt Thắng";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButton1.IconColor = System.Drawing.Color.Aqua;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 65;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(131, 587);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(180, 62);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Check out";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_LichLam
            // 
            this.btn_LichLam.BackColor = System.Drawing.Color.Black;
            this.btn_LichLam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_LichLam.FlatAppearance.BorderSize = 0;
            this.btn_LichLam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btn_LichLam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btn_LichLam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LichLam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LichLam.ForeColor = System.Drawing.Color.Silver;
            this.btn_LichLam.Image = ((System.Drawing.Image)(resources.GetObject("btn_LichLam.Image")));
            this.btn_LichLam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LichLam.Location = new System.Drawing.Point(0, 158);
            this.btn_LichLam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_LichLam.Name = "btn_LichLam";
            this.btn_LichLam.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btn_LichLam.Size = new System.Drawing.Size(300, 52);
            this.btn_LichLam.TabIndex = 1;
            this.btn_LichLam.Text = "  Quản lý Lịch làm việc";
            this.btn_LichLam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LichLam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LichLam.UseVisualStyleBackColor = false;
            this.btn_LichLam.Click += new System.EventHandler(this.btn_LichLam_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(300, 158);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbt_CheckIn
            // 
            this.tbt_CheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tbt_CheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbt_CheckIn.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbt_CheckIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbt_CheckIn.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.tbt_CheckIn.IconColor = System.Drawing.Color.Chartreuse;
            this.tbt_CheckIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tbt_CheckIn.IconSize = 70;
            this.tbt_CheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbt_CheckIn.Location = new System.Drawing.Point(131, 473);
            this.tbt_CheckIn.Name = "tbt_CheckIn";
            this.tbt_CheckIn.Size = new System.Drawing.Size(180, 62);
            this.tbt_CheckIn.TabIndex = 4;
            this.tbt_CheckIn.Text = "Check in";
            this.tbt_CheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbt_CheckIn.UseVisualStyleBackColor = false;
            this.tbt_CheckIn.Click += new System.EventHandler(this.tbt_CheckIn_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.btn_BanHang);
            this.panelSideMenu.Controls.Add(this.btn_LichLam);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(300, 753);
            this.panelSideMenu.TabIndex = 3;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.llb_EditPass);
            this.panelChildForm.Controls.Add(this.lb_CheckOut);
            this.panelChildForm.Controls.Add(this.lb_CheckIn);
            this.panelChildForm.Controls.Add(this.lb_Date);
            this.panelChildForm.Controls.Add(this.lb_time);
            this.panelChildForm.Controls.Add(this.iconPictureBox1);
            this.panelChildForm.Controls.Add(this.llb_EditTT);
            this.panelChildForm.Controls.Add(this.lb_Name);
            this.panelChildForm.Controls.Add(this.ptb_Picture);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.iconButton1);
            this.panelChildForm.Controls.Add(this.tbt_CheckIn);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelChildForm.Location = new System.Drawing.Point(300, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(932, 753);
            this.panelChildForm.TabIndex = 4;
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 753);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelChildForm);
            this.Name = "frm_NhanVien";
            this.Text = "frm_NhanVien";
            this.Load += new System.EventHandler(this.frm_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Picture)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel llb_EditPass;
        private System.Windows.Forms.Label lb_CheckIn;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Label lb_time;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.LinkLabel llb_EditTT;
        private System.Windows.Forms.Label lb_CheckOut;
        public System.Windows.Forms.PictureBox ptb_Picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn_BanHang;
        public System.Windows.Forms.Label lb_Name;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_LichLam;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton tbt_CheckIn;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelChildForm;
    }
}