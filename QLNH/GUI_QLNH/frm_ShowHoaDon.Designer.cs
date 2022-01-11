
namespace QLNH.GUI_QLNH
{
    partial class frm_ShowHoaDon
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
            this.lv_DonMua = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_NgayBan = new System.Windows.Forms.Label();
            this.lb_TenNV = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lb_TenBan = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_HoanTat = new System.Windows.Forms.Button();
            this.gb_ThanhToan = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TongHoaDon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_KhachTra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_TraLai = new System.Windows.Forms.TextBox();
            this.gb_ThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_DonMua
            // 
            this.lv_DonMua.HideSelection = false;
            this.lv_DonMua.Location = new System.Drawing.Point(3, 137);
            this.lv_DonMua.Name = "lv_DonMua";
            this.lv_DonMua.Size = new System.Drawing.Size(400, 341);
            this.lv_DonMua.TabIndex = 0;
            this.lv_DonMua.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hóa đơn bán hàng";
            // 
            // lb_NgayBan
            // 
            this.lb_NgayBan.AutoSize = true;
            this.lb_NgayBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayBan.Location = new System.Drawing.Point(0, 80);
            this.lb_NgayBan.Name = "lb_NgayBan";
            this.lb_NgayBan.Size = new System.Drawing.Size(74, 18);
            this.lb_NgayBan.TabIndex = 2;
            this.lb_NgayBan.Text = "Ngày bán:";
            // 
            // lb_TenNV
            // 
            this.lb_TenNV.AutoSize = true;
            this.lb_TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenNV.Location = new System.Drawing.Point(0, 116);
            this.lb_TenNV.Name = "lb_TenNV";
            this.lb_TenNV.Size = new System.Drawing.Size(61, 18);
            this.lb_TenNV.TabIndex = 3;
            this.lb_TenNV.Text = "Tên NV:";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(370, 2);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 31);
            this.button5.TabIndex = 45;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lb_TenBan
            // 
            this.lb_TenBan.AutoSize = true;
            this.lb_TenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenBan.Location = new System.Drawing.Point(0, 98);
            this.lb_TenBan.Name = "lb_TenBan";
            this.lb_TenBan.Size = new System.Drawing.Size(74, 18);
            this.lb_TenBan.TabIndex = 46;
            this.lb_TenBan.Text = "Ngày bán:";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_ThanhToan.Location = new System.Drawing.Point(52, 494);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(115, 47);
            this.btn_ThanhToan.TabIndex = 47;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_HoanTat.Location = new System.Drawing.Point(239, 494);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Size = new System.Drawing.Size(115, 47);
            this.btn_HoanTat.TabIndex = 48;
            this.btn_HoanTat.Text = "Hoàn tất";
            this.btn_HoanTat.UseVisualStyleBackColor = false;
            this.btn_HoanTat.Click += new System.EventHandler(this.btn_HoanTat_Click);
            // 
            // gb_ThanhToan
            // 
            this.gb_ThanhToan.Controls.Add(this.label4);
            this.gb_ThanhToan.Controls.Add(this.tb_TraLai);
            this.gb_ThanhToan.Controls.Add(this.label3);
            this.gb_ThanhToan.Controls.Add(this.tb_KhachTra);
            this.gb_ThanhToan.Controls.Add(this.label2);
            this.gb_ThanhToan.Controls.Add(this.tb_TongHoaDon);
            this.gb_ThanhToan.Location = new System.Drawing.Point(27, 547);
            this.gb_ThanhToan.Name = "gb_ThanhToan";
            this.gb_ThanhToan.Size = new System.Drawing.Size(346, 142);
            this.gb_ThanhToan.TabIndex = 51;
            this.gb_ThanhToan.TabStop = false;
            this.gb_ThanhToan.Text = "Thanh toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tổng hóa đơn";
            // 
            // tb_TongHoaDon
            // 
            this.tb_TongHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TongHoaDon.Location = new System.Drawing.Point(160, 24);
            this.tb_TongHoaDon.Name = "tb_TongHoaDon";
            this.tb_TongHoaDon.Size = new System.Drawing.Size(173, 27);
            this.tb_TongHoaDon.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Khánh trả";
            // 
            // tb_KhachTra
            // 
            this.tb_KhachTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_KhachTra.Location = new System.Drawing.Point(160, 66);
            this.tb_KhachTra.Name = "tb_KhachTra";
            this.tb_KhachTra.Size = new System.Drawing.Size(173, 27);
            this.tb_KhachTra.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Trả lại";
            // 
            // tb_TraLai
            // 
            this.tb_TraLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TraLai.Location = new System.Drawing.Point(160, 108);
            this.tb_TraLai.Name = "tb_TraLai";
            this.tb_TraLai.Size = new System.Drawing.Size(173, 27);
            this.tb_TraLai.TabIndex = 55;
            // 
            // frm_ShowHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(407, 713);
            this.Controls.Add(this.gb_ThanhToan);
            this.Controls.Add(this.btn_HoanTat);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.lb_TenBan);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lb_TenNV);
            this.Controls.Add(this.lb_NgayBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_DonMua);
            this.Name = "frm_ShowHoaDon";
            this.Text = "frm_ShowHoaDon";
            this.gb_ThanhToan.ResumeLayout(false);
            this.gb_ThanhToan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_DonMua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_NgayBan;
        private System.Windows.Forms.Label lb_TenNV;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lb_TenBan;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_HoanTat;
        private System.Windows.Forms.GroupBox gb_ThanhToan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_TraLai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_KhachTra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TongHoaDon;
    }
}