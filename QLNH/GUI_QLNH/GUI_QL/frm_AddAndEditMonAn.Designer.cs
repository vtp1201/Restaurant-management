
namespace QLNH.GUI_QLNH.GUI_QL
{
    partial class frm_AddAndEditMonAn
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
            this.lb_MaNV = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.cbb_MaMonAn = new System.Windows.Forms.ComboBox();
            this.lb_TieuDe = new System.Windows.Forms.Label();
            this.ptb_Picture = new System.Windows.Forms.PictureBox();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.tb_Gia = new System.Windows.Forms.TextBox();
            this.tb_TenMonAn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.cbb_PhanLoai = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_MaNV
            // 
            this.lb_MaNV.AutoSize = true;
            this.lb_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaNV.Location = new System.Drawing.Point(248, 133);
            this.lb_MaNV.Name = "lb_MaNV";
            this.lb_MaNV.Size = new System.Drawing.Size(0, 25);
            this.lb_MaNV.TabIndex = 38;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Brown;
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(525, 507);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(148, 59);
            this.btn_Delete.TabIndex = 37;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(226, 507);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(158, 59);
            this.btn_Update.TabIndex = 36;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.Gray;
            this.btn_Browse.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Browse.Location = new System.Drawing.Point(641, 364);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(105, 36);
            this.btn_Browse.TabIndex = 35;
            this.btn_Browse.Text = "Chọn ảnh";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // cbb_MaMonAn
            // 
            this.cbb_MaMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_MaMonAn.FormattingEnabled = true;
            this.cbb_MaMonAn.Location = new System.Drawing.Point(246, 130);
            this.cbb_MaMonAn.Name = "cbb_MaMonAn";
            this.cbb_MaMonAn.Size = new System.Drawing.Size(113, 28);
            this.cbb_MaMonAn.TabIndex = 34;
            this.cbb_MaMonAn.SelectedIndexChanged += new System.EventHandler(this.cbb_MaMonAn_SelectedIndexChanged);
            // 
            // lb_TieuDe
            // 
            this.lb_TieuDe.AutoSize = true;
            this.lb_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TieuDe.Location = new System.Drawing.Point(348, 56);
            this.lb_TieuDe.Name = "lb_TieuDe";
            this.lb_TieuDe.Size = new System.Drawing.Size(217, 38);
            this.lb_TieuDe.TabIndex = 33;
            this.lb_TieuDe.Text = "Thêm món ăn";
            // 
            // ptb_Picture
            // 
            this.ptb_Picture.BackColor = System.Drawing.Color.Gray;
            this.ptb_Picture.Location = new System.Drawing.Point(525, 145);
            this.ptb_Picture.Name = "ptb_Picture";
            this.ptb_Picture.Size = new System.Drawing.Size(336, 213);
            this.ptb_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Picture.TabIndex = 32;
            this.ptb_Picture.TabStop = false;
            // 
            // rtb_Description
            // 
            this.rtb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Description.Location = new System.Drawing.Point(246, 369);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(295, 96);
            this.rtb_Description.TabIndex = 31;
            this.rtb_Description.Text = "";
            // 
            // tb_Gia
            // 
            this.tb_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Gia.Location = new System.Drawing.Point(246, 309);
            this.tb_Gia.Name = "tb_Gia";
            this.tb_Gia.Size = new System.Drawing.Size(167, 27);
            this.tb_Gia.TabIndex = 30;
            // 
            // tb_TenMonAn
            // 
            this.tb_TenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenMonAn.Location = new System.Drawing.Point(246, 188);
            this.tb_TenMonAn.Name = "tb_TenMonAn";
            this.tb_TenMonAn.Size = new System.Drawing.Size(239, 27);
            this.tb_TenMonAn.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mô tả món ăn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Giá thành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Phân loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên món ăn";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(96, 133);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(110, 25);
            this.lb1.TabIndex = 20;
            this.lb1.Text = "Mã món ăn";
            // 
            // cbb_PhanLoai
            // 
            this.cbb_PhanLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_PhanLoai.FormattingEnabled = true;
            this.cbb_PhanLoai.Location = new System.Drawing.Point(246, 249);
            this.cbb_PhanLoai.Name = "cbb_PhanLoai";
            this.cbb_PhanLoai.Size = new System.Drawing.Size(154, 28);
            this.cbb_PhanLoai.TabIndex = 39;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Aqua;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(383, 507);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(158, 59);
            this.btn_Add.TabIndex = 40;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // frm_AddAndEditMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(915, 614);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cbb_PhanLoai);
            this.Controls.Add(this.lb_MaNV);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.cbb_MaMonAn);
            this.Controls.Add(this.lb_TieuDe);
            this.Controls.Add(this.ptb_Picture);
            this.Controls.Add(this.rtb_Description);
            this.Controls.Add(this.tb_Gia);
            this.Controls.Add(this.tb_TenMonAn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb1);
            this.Name = "frm_AddAndEditMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AddAndEditMonAn";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_MaNV;
        public System.Windows.Forms.Button btn_Delete;
        public System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Browse;
        public System.Windows.Forms.ComboBox cbb_MaMonAn;
        public System.Windows.Forms.Label lb_TieuDe;
        public System.Windows.Forms.PictureBox ptb_Picture;
        public System.Windows.Forms.RichTextBox rtb_Description;
        public System.Windows.Forms.TextBox tb_Gia;
        public System.Windows.Forms.TextBox tb_TenMonAn;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lb1;
        public System.Windows.Forms.ComboBox cbb_PhanLoai;
        public System.Windows.Forms.Button btn_Add;
    }
}