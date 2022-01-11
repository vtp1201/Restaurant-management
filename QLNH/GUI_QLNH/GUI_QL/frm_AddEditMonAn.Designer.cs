
namespace QLNH.GUI_QLNH.GUI_QL
{
    partial class frm_AddEditMonAn
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
            this.dtp_Ngay = new System.Windows.Forms.DateTimePicker();
            this.cbb_TenCa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_MaCl = new System.Windows.Forms.TextBox();
            this.tb_MaMonAn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TenMonAn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_TieuDe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ConLai = new System.Windows.Forms.TextBox();
            this.lb_ConLai = new System.Windows.Forms.Label();
            this.tb_SoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Ngay.Location = new System.Drawing.Point(117, 89);
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.Size = new System.Drawing.Size(338, 30);
            this.dtp_Ngay.TabIndex = 0;
            // 
            // cbb_TenCa
            // 
            this.cbb_TenCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TenCa.FormattingEnabled = true;
            this.cbb_TenCa.Location = new System.Drawing.Point(472, 89);
            this.cbb_TenCa.Name = "cbb_TenCa";
            this.cbb_TenCa.Size = new System.Drawing.Size(121, 30);
            this.cbb_TenCa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã ca làm";
            // 
            // tb_MaCl
            // 
            this.tb_MaCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaCl.Location = new System.Drawing.Point(325, 130);
            this.tb_MaCl.Name = "tb_MaCl";
            this.tb_MaCl.Size = new System.Drawing.Size(100, 30);
            this.tb_MaCl.TabIndex = 3;
            // 
            // tb_MaMonAn
            // 
            this.tb_MaMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaMonAn.Location = new System.Drawing.Point(325, 174);
            this.tb_MaMonAn.Name = "tb_MaMonAn";
            this.tb_MaMonAn.Size = new System.Drawing.Size(100, 30);
            this.tb_MaMonAn.TabIndex = 5;
            this.tb_MaMonAn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã món ăn";
            // 
            // tb_TenMonAn
            // 
            this.tb_TenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenMonAn.Location = new System.Drawing.Point(325, 214);
            this.tb_TenMonAn.Name = "tb_TenMonAn";
            this.tb_TenMonAn.Size = new System.Drawing.Size(158, 30);
            this.tb_TenMonAn.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên món ăn";
            // 
            // lb_TieuDe
            // 
            this.lb_TieuDe.AutoSize = true;
            this.lb_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TieuDe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lb_TieuDe.Location = new System.Drawing.Point(100, 25);
            this.lb_TieuDe.Name = "lb_TieuDe";
            this.lb_TieuDe.Size = new System.Drawing.Size(471, 44);
            this.lb_TieuDe.TabIndex = 8;
            this.lb_TieuDe.Text = "Thêm món ăn vào ca làm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ca làm";
            // 
            // tb_ConLai
            // 
            this.tb_ConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ConLai.Location = new System.Drawing.Point(325, 300);
            this.tb_ConLai.Name = "tb_ConLai";
            this.tb_ConLai.Size = new System.Drawing.Size(100, 30);
            this.tb_ConLai.TabIndex = 13;
            // 
            // lb_ConLai
            // 
            this.lb_ConLai.AutoSize = true;
            this.lb_ConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ConLai.Location = new System.Drawing.Point(192, 303);
            this.lb_ConLai.Name = "lb_ConLai";
            this.lb_ConLai.Size = new System.Drawing.Size(73, 25);
            this.lb_ConLai.TabIndex = 12;
            this.lb_ConLai.Text = "Còn lại";
            // 
            // tb_SoLuong
            // 
            this.tb_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SoLuong.Location = new System.Drawing.Point(325, 256);
            this.tb_SoLuong.Name = "tb_SoLuong";
            this.tb_SoLuong.Size = new System.Drawing.Size(100, 30);
            this.tb_SoLuong.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số lượng";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Cyan;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(237, 336);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(150, 52);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // frm_AddEditMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(622, 406);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tb_ConLai);
            this.Controls.Add(this.lb_ConLai);
            this.Controls.Add(this.tb_SoLuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_TieuDe);
            this.Controls.Add(this.tb_TenMonAn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_MaMonAn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_MaCl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_TenCa);
            this.Controls.Add(this.dtp_Ngay);
            this.Name = "frm_AddEditMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AddEditMonAn";
            this.Load += new System.EventHandler(this.frm_AddEditMonAn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtp_Ngay;
        public System.Windows.Forms.ComboBox cbb_TenCa;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_MaCl;
        public System.Windows.Forms.TextBox tb_MaMonAn;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_TenMonAn;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lb_TieuDe;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_ConLai;
        public System.Windows.Forms.TextBox tb_SoLuong;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btn_Add;
        public System.Windows.Forms.Label lb_ConLai;
    }
}