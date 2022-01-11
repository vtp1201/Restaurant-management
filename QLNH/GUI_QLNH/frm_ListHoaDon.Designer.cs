
namespace QLNH.GUI_QLNH
{
    partial class frm_ListHoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ChuaThanhToan = new System.Windows.Forms.Button();
            this.btn_DaThanhToan = new System.Windows.Forms.Button();
            this.btn_HoanTat = new System.Windows.Forms.Button();
            this.btn_TatCa = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btn_Find = new System.Windows.Forms.Button();
            this.cbb_Ban = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.flp_ListMonAn = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.btn_ChuaThanhToan);
            this.panel1.Controls.Add(this.btn_DaThanhToan);
            this.panel1.Controls.Add(this.btn_HoanTat);
            this.panel1.Controls.Add(this.btn_TatCa);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 653);
            this.panel1.TabIndex = 3;
            // 
            // btn_ChuaThanhToan
            // 
            this.btn_ChuaThanhToan.BackColor = System.Drawing.Color.Black;
            this.btn_ChuaThanhToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ChuaThanhToan.FlatAppearance.BorderSize = 0;
            this.btn_ChuaThanhToan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btn_ChuaThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btn_ChuaThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChuaThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChuaThanhToan.ForeColor = System.Drawing.Color.Silver;
            this.btn_ChuaThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChuaThanhToan.Location = new System.Drawing.Point(0, 282);
            this.btn_ChuaThanhToan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_ChuaThanhToan.Name = "btn_ChuaThanhToan";
            this.btn_ChuaThanhToan.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btn_ChuaThanhToan.Size = new System.Drawing.Size(240, 52);
            this.btn_ChuaThanhToan.TabIndex = 5;
            this.btn_ChuaThanhToan.Text = "  Chưa thanh toán";
            this.btn_ChuaThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChuaThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ChuaThanhToan.UseVisualStyleBackColor = false;
            this.btn_ChuaThanhToan.Click += new System.EventHandler(this.btn_ChuaThanhToan_Click);
            // 
            // btn_DaThanhToan
            // 
            this.btn_DaThanhToan.BackColor = System.Drawing.Color.Black;
            this.btn_DaThanhToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DaThanhToan.FlatAppearance.BorderSize = 0;
            this.btn_DaThanhToan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btn_DaThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btn_DaThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DaThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DaThanhToan.ForeColor = System.Drawing.Color.Silver;
            this.btn_DaThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DaThanhToan.Location = new System.Drawing.Point(0, 230);
            this.btn_DaThanhToan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DaThanhToan.Name = "btn_DaThanhToan";
            this.btn_DaThanhToan.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btn_DaThanhToan.Size = new System.Drawing.Size(240, 52);
            this.btn_DaThanhToan.TabIndex = 4;
            this.btn_DaThanhToan.Text = "  Đã thanh toán";
            this.btn_DaThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DaThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DaThanhToan.UseVisualStyleBackColor = false;
            this.btn_DaThanhToan.Click += new System.EventHandler(this.btn_DaThanhToan_Click);
            // 
            // btn_HoanTat
            // 
            this.btn_HoanTat.BackColor = System.Drawing.Color.Black;
            this.btn_HoanTat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_HoanTat.FlatAppearance.BorderSize = 0;
            this.btn_HoanTat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btn_HoanTat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btn_HoanTat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoanTat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoanTat.ForeColor = System.Drawing.Color.Silver;
            this.btn_HoanTat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HoanTat.Location = new System.Drawing.Point(0, 178);
            this.btn_HoanTat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_HoanTat.Name = "btn_HoanTat";
            this.btn_HoanTat.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btn_HoanTat.Size = new System.Drawing.Size(240, 52);
            this.btn_HoanTat.TabIndex = 3;
            this.btn_HoanTat.Text = "  Đã hoàn tất";
            this.btn_HoanTat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HoanTat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_HoanTat.UseVisualStyleBackColor = false;
            this.btn_HoanTat.Click += new System.EventHandler(this.btn_HoanTat_Click);
            // 
            // btn_TatCa
            // 
            this.btn_TatCa.BackColor = System.Drawing.Color.Black;
            this.btn_TatCa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TatCa.FlatAppearance.BorderSize = 0;
            this.btn_TatCa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btn_TatCa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btn_TatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TatCa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TatCa.ForeColor = System.Drawing.Color.Silver;
            this.btn_TatCa.Location = new System.Drawing.Point(0, 126);
            this.btn_TatCa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_TatCa.Name = "btn_TatCa";
            this.btn_TatCa.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btn_TatCa.Size = new System.Drawing.Size(240, 52);
            this.btn_TatCa.TabIndex = 2;
            this.btn_TatCa.Text = "Tất cả ";
            this.btn_TatCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TatCa.UseVisualStyleBackColor = false;
            this.btn_TatCa.Click += new System.EventHandler(this.btn_TatCa_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelLogo.Controls.Add(this.btn_Find);
            this.panelLogo.Controls.Add(this.cbb_Ban);
            this.panelLogo.Controls.Add(this.button5);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 126);
            this.panelLogo.TabIndex = 1;
            // 
            // btn_Find
            // 
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Find.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_Find.Location = new System.Drawing.Point(150, 53);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(75, 41);
            this.btn_Find.TabIndex = 25;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // cbb_Ban
            // 
            this.cbb_Ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Ban.FormattingEnabled = true;
            this.cbb_Ban.Location = new System.Drawing.Point(23, 59);
            this.cbb_Ban.Name = "cbb_Ban";
            this.cbb_Ban.Size = new System.Drawing.Size(121, 28);
            this.cbb_Ban.TabIndex = 24;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(13, 4);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 31);
            this.button5.TabIndex = 23;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // flp_ListMonAn
            // 
            this.flp_ListMonAn.AutoScroll = true;
            this.flp_ListMonAn.Dock = System.Windows.Forms.DockStyle.Right;
            this.flp_ListMonAn.Location = new System.Drawing.Point(240, 0);
            this.flp_ListMonAn.Name = "flp_ListMonAn";
            this.flp_ListMonAn.Size = new System.Drawing.Size(799, 653);
            this.flp_ListMonAn.TabIndex = 2;
            // 
            // frm_ListHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flp_ListMonAn);
            this.Name = "frm_ListHoaDon";
            this.Text = "frm_ListHoaDon";
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ChuaThanhToan;
        private System.Windows.Forms.Button btn_DaThanhToan;
        private System.Windows.Forms.Button btn_HoanTat;
        private System.Windows.Forms.Button btn_TatCa;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.FlowLayoutPanel flp_ListMonAn;
        private System.Windows.Forms.ComboBox cbb_Ban;
        private System.Windows.Forms.Button btn_Find;
    }
}