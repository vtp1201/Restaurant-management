
namespace QLNH.GUI_QLNH.GUI_QL
{
    partial class frm_QLBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddBan = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgv_Ban = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_SoGhe = new System.Windows.Forms.ComboBox();
            this.tb_MaBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_KhuVuc = new System.Windows.Forms.ComboBox();
            this.tb_12ChoNgoi = new System.Windows.Forms.TextBox();
            this.tb_8ChoNgoi = new System.Windows.Forms.TextBox();
            this.tb_4ChoNgoi = new System.Windows.Forms.TextBox();
            this.tb_TongSoBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ban)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(432, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Danh sách bàn";
            // 
            // btn_AddBan
            // 
            this.btn_AddBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_AddBan.FlatAppearance.BorderSize = 0;
            this.btn_AddBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddBan.ForeColor = System.Drawing.Color.LightGray;
            this.btn_AddBan.Location = new System.Drawing.Point(82, 615);
            this.btn_AddBan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddBan.Name = "btn_AddBan";
            this.btn_AddBan.Size = new System.Drawing.Size(191, 49);
            this.btn_AddBan.TabIndex = 22;
            this.btn_AddBan.Text = "Thêm Bàn";
            this.btn_AddBan.UseVisualStyleBackColor = false;
            this.btn_AddBan.Click += new System.EventHandler(this.btn_AddBan_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(12, 7);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 31);
            this.button5.TabIndex = 21;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgv_Ban
            // 
            this.dgv_Ban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Ban.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Ban.ColumnHeadersHeight = 29;
            this.dgv_Ban.Location = new System.Drawing.Point(437, 131);
            this.dgv_Ban.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Ban.Name = "dgv_Ban";
            this.dgv_Ban.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Ban.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Ban.Size = new System.Drawing.Size(453, 536);
            this.dgv_Ban.TabIndex = 20;
            this.dgv_Ban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ban_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(321, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 44);
            this.label1.TabIndex = 19;
            this.label1.Text = "QUẢN LÝ BÀN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_KhuVuc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbb_SoGhe);
            this.groupBox1.Controls.Add(this.tb_MaBan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 203);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Bàn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbb_SoGhe
            // 
            this.cbb_SoGhe.FormattingEnabled = true;
            this.cbb_SoGhe.Location = new System.Drawing.Point(118, 98);
            this.cbb_SoGhe.Name = "cbb_SoGhe";
            this.cbb_SoGhe.Size = new System.Drawing.Size(166, 33);
            this.cbb_SoGhe.TabIndex = 28;
            // 
            // tb_MaBan
            // 
            this.tb_MaBan.Location = new System.Drawing.Point(118, 42);
            this.tb_MaBan.Name = "tb_MaBan";
            this.tb_MaBan.Size = new System.Drawing.Size(129, 30);
            this.tb_MaBan.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(26, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Số ghế";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(26, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên bàn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_12ChoNgoi);
            this.groupBox2.Controls.Add(this.tb_8ChoNgoi);
            this.groupBox2.Controls.Add(this.tb_4ChoNgoi);
            this.groupBox2.Controls.Add(this.tb_TongSoBan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 254);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê";
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.Location = new System.Drawing.Point(82, 615);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(191, 49);
            this.btn_Update.TabIndex = 27;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label9.Location = new System.Drawing.Point(26, 152);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Khu Vực";
            // 
            // cbb_KhuVuc
            // 
            this.cbb_KhuVuc.FormattingEnabled = true;
            this.cbb_KhuVuc.Location = new System.Drawing.Point(118, 149);
            this.cbb_KhuVuc.Name = "cbb_KhuVuc";
            this.cbb_KhuVuc.Size = new System.Drawing.Size(166, 33);
            this.cbb_KhuVuc.TabIndex = 30;
            // 
            // tb_12ChoNgoi
            // 
            this.tb_12ChoNgoi.Location = new System.Drawing.Point(155, 190);
            this.tb_12ChoNgoi.Name = "tb_12ChoNgoi";
            this.tb_12ChoNgoi.Size = new System.Drawing.Size(220, 30);
            this.tb_12ChoNgoi.TabIndex = 41;
            // 
            // tb_8ChoNgoi
            // 
            this.tb_8ChoNgoi.Location = new System.Drawing.Point(155, 146);
            this.tb_8ChoNgoi.Name = "tb_8ChoNgoi";
            this.tb_8ChoNgoi.Size = new System.Drawing.Size(220, 30);
            this.tb_8ChoNgoi.TabIndex = 40;
            // 
            // tb_4ChoNgoi
            // 
            this.tb_4ChoNgoi.Location = new System.Drawing.Point(155, 100);
            this.tb_4ChoNgoi.Name = "tb_4ChoNgoi";
            this.tb_4ChoNgoi.Size = new System.Drawing.Size(220, 30);
            this.tb_4ChoNgoi.TabIndex = 39;
            // 
            // tb_TongSoBan
            // 
            this.tb_TongSoBan.Location = new System.Drawing.Point(155, 46);
            this.tb_TongSoBan.Name = "tb_TongSoBan";
            this.tb_TongSoBan.Size = new System.Drawing.Size(117, 30);
            this.tb_TongSoBan.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label8.Location = new System.Drawing.Point(26, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Tổng số bàn";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label7.Location = new System.Drawing.Point(26, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Sân vườn";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label6.Location = new System.Drawing.Point(26, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tầng 2";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(26, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tầng 1";
            // 
            // frm_QLBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(932, 753);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AddBan);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgv_Ban);
            this.Controls.Add(this.label1);
            this.Name = "frm_QLBan";
            this.Text = "frm_QLBan";
            this.Load += new System.EventHandler(this.frm_QLBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ban)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddBan;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgv_Ban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_SoGhe;
        private System.Windows.Forms.TextBox tb_MaBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ComboBox cbb_KhuVuc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_12ChoNgoi;
        private System.Windows.Forms.TextBox tb_8ChoNgoi;
        private System.Windows.Forms.TextBox tb_4ChoNgoi;
        private System.Windows.Forms.TextBox tb_TongSoBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}