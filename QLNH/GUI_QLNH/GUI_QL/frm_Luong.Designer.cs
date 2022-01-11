
namespace QLNH.GUI_QLNH.GUI_QL
{
    partial class frm_Luong
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
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.DTP_Ngay = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.dgv_CaLam = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CaLam)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btn_ThemNV.FlatAppearance.BorderSize = 0;
            this.btn_ThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNV.ForeColor = System.Drawing.Color.LightGray;
            this.btn_ThemNV.Location = new System.Drawing.Point(793, 160);
            this.btn_ThemNV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(109, 55);
            this.btn_ThemNV.TabIndex = 18;
            this.btn_ThemNV.Text = "Cập nhật";
            this.btn_ThemNV.UseVisualStyleBackColor = false;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Find.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Find.FlatAppearance.BorderSize = 0;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.ForeColor = System.Drawing.Color.Black;
            this.btn_Find.Location = new System.Drawing.Point(407, 108);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(109, 30);
            this.btn_Find.TabIndex = 17;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // DTP_Ngay
            // 
            this.DTP_Ngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Ngay.Location = new System.Drawing.Point(25, 108);
            this.DTP_Ngay.Name = "DTP_Ngay";
            this.DTP_Ngay.Size = new System.Drawing.Size(354, 30);
            this.DTP_Ngay.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(12, 10);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 31);
            this.button5.TabIndex = 14;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgv_CaLam
            // 
            this.dgv_CaLam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_CaLam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.dgv_CaLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CaLam.Location = new System.Drawing.Point(25, 160);
            this.dgv_CaLam.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_CaLam.Name = "dgv_CaLam";
            this.dgv_CaLam.RowHeadersWidth = 51;
            this.dgv_CaLam.Size = new System.Drawing.Size(746, 507);
            this.dgv_CaLam.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(215, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "QUẢN LÝ LƯƠNG NHÂN VIÊN";
            // 
            // frm_Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(914, 706);
            this.Controls.Add(this.btn_ThemNV);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.DTP_Ngay);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgv_CaLam);
            this.Controls.Add(this.label1);
            this.Name = "frm_Luong";
            this.Text = "frm_Luong";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CaLam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_ThemNV;
        public System.Windows.Forms.Button btn_Find;
        public System.Windows.Forms.DateTimePicker DTP_Ngay;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.DataGridView dgv_CaLam;
        public System.Windows.Forms.Label label1;
    }
}