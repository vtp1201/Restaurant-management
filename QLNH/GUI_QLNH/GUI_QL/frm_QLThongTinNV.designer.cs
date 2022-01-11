namespace QLNH.GUI_QLNH.GUI_QL
{
    partial class frm_QLThongTinNV
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
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.btn_UpdateNV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Location = new System.Drawing.Point(184, 104);
            this.dgv_NhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.Size = new System.Drawing.Size(735, 609);
            this.dgv_NhanVien.TabIndex = 9;
            this.dgv_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(343, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 31);
            this.button5.TabIndex = 14;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.BackColor = System.Drawing.Color.DarkGray;
            this.btn_ThemNV.FlatAppearance.BorderSize = 0;
            this.btn_ThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNV.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_ThemNV.Location = new System.Drawing.Point(13, 104);
            this.btn_ThemNV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(163, 49);
            this.btn_ThemNV.TabIndex = 18;
            this.btn_ThemNV.Text = "Thêm Nhân Viên";
            this.btn_ThemNV.UseVisualStyleBackColor = false;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // btn_UpdateNV
            // 
            this.btn_UpdateNV.BackColor = System.Drawing.Color.DarkGray;
            this.btn_UpdateNV.FlatAppearance.BorderSize = 0;
            this.btn_UpdateNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateNV.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_UpdateNV.Location = new System.Drawing.Point(13, 184);
            this.btn_UpdateNV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_UpdateNV.Name = "btn_UpdateNV";
            this.btn_UpdateNV.Size = new System.Drawing.Size(163, 54);
            this.btn_UpdateNV.TabIndex = 19;
            this.btn_UpdateNV.Text = "Cập nhật thông tin";
            this.btn_UpdateNV.UseVisualStyleBackColor = false;
            this.btn_UpdateNV.Click += new System.EventHandler(this.btn_UpdateNV_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(454, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Danh sách nhân viên";
            // 
            // frm_QLThongTinNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(932, 753);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_UpdateNV);
            this.Controls.Add(this.btn_ThemNV);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgv_NhanVien);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QLThongTinNV";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_ThemNV;
        private System.Windows.Forms.Button btn_UpdateNV;
        public System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Label label2;
    }
}