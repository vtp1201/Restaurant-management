namespace QLNH.GUI_QLNH.GUI_QL
{
    partial class frm_QLMonAn
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
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_AddMonAn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_PhanLoai = new System.Windows.Forms.ComboBox();
            this.dgv_MonAn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(328, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản Lý Món Ăn";
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
            // btn_AddMonAn
            // 
            this.btn_AddMonAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddMonAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_AddMonAn.FlatAppearance.BorderSize = 0;
            this.btn_AddMonAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddMonAn.ForeColor = System.Drawing.Color.LightGray;
            this.btn_AddMonAn.Location = new System.Drawing.Point(13, 136);
            this.btn_AddMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddMonAn.Name = "btn_AddMonAn";
            this.btn_AddMonAn.Size = new System.Drawing.Size(191, 49);
            this.btn_AddMonAn.TabIndex = 15;
            this.btn_AddMonAn.Text = "Thêm Món Ăn";
            this.btn_AddMonAn.UseVisualStyleBackColor = false;
            this.btn_AddMonAn.Click += new System.EventHandler(this.btn_AddMonAn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(248, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Danh sách món ăn";
            // 
            // cbb_PhanLoai
            // 
            this.cbb_PhanLoai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbb_PhanLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_PhanLoai.FormattingEnabled = true;
            this.cbb_PhanLoai.Location = new System.Drawing.Point(480, 92);
            this.cbb_PhanLoai.Name = "cbb_PhanLoai";
            this.cbb_PhanLoai.Size = new System.Drawing.Size(144, 37);
            this.cbb_PhanLoai.TabIndex = 18;
            this.cbb_PhanLoai.SelectedIndexChanged += new System.EventHandler(this.cbb_PhanLoai_SelectedIndexChanged);
            // 
            // dgv_MonAn
            // 
            this.dgv_MonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MonAn.Location = new System.Drawing.Point(253, 136);
            this.dgv_MonAn.Name = "dgv_MonAn";
            this.dgv_MonAn.RowHeadersWidth = 51;
            this.dgv_MonAn.RowTemplate.Height = 24;
            this.dgv_MonAn.Size = new System.Drawing.Size(657, 605);
            this.dgv_MonAn.TabIndex = 19;
            // 
            // frm_QLMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(932, 753);
            this.Controls.Add(this.dgv_MonAn);
            this.Controls.Add(this.cbb_PhanLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AddMonAn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QLMonAn";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frm_QLMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_AddMonAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_PhanLoai;
        private System.Windows.Forms.DataGridView dgv_MonAn;
    }
}