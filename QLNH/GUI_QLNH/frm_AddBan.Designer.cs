
namespace QLNH.GUI_QLNH
{
    partial class frm_AddBan
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
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ibtn_ApDung = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_SapXep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_TrangThai = new System.Windows.Forms.ComboBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ibtn_ApDung);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbb_SapXep);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbb_TrangThai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 133);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(14, 15);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 31);
            this.button5.TabIndex = 22;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(692, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chọn bàn ăn";
            // 
            // ibtn_ApDung
            // 
            this.ibtn_ApDung.BackColor = System.Drawing.Color.DimGray;
            this.ibtn_ApDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_ApDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_ApDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ibtn_ApDung.IconChar = FontAwesome.Sharp.IconChar.ConciergeBell;
            this.ibtn_ApDung.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ibtn_ApDung.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_ApDung.IconSize = 40;
            this.ibtn_ApDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_ApDung.Location = new System.Drawing.Point(510, 63);
            this.ibtn_ApDung.Name = "ibtn_ApDung";
            this.ibtn_ApDung.Size = new System.Drawing.Size(139, 47);
            this.ibtn_ApDung.TabIndex = 4;
            this.ibtn_ApDung.Text = "Áp dụng";
            this.ibtn_ApDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtn_ApDung.UseVisualStyleBackColor = false;
            this.ibtn_ApDung.Click += new System.EventHandler(this.ibtn_ApDung_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(297, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sắp xếp theo";
            // 
            // cbb_SapXep
            // 
            this.cbb_SapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_SapXep.FormattingEnabled = true;
            this.cbb_SapXep.Location = new System.Drawing.Point(302, 77);
            this.cbb_SapXep.Name = "cbb_SapXep";
            this.cbb_SapXep.Size = new System.Drawing.Size(174, 33);
            this.cbb_SapXep.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(75, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trạng thái";
            // 
            // cbb_TrangThai
            // 
            this.cbb_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TrangThai.FormattingEnabled = true;
            this.cbb_TrangThai.Location = new System.Drawing.Point(80, 77);
            this.cbb_TrangThai.Name = "cbb_TrangThai";
            this.cbb_TrangThai.Size = new System.Drawing.Size(174, 33);
            this.cbb_TrangThai.TabIndex = 0;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lb_1.Location = new System.Drawing.Point(35, 208);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(131, 29);
            this.lb_1.TabIndex = 2;
            this.lb_1.Text = "Trạng thái";
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lb_2.Location = new System.Drawing.Point(35, 346);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(131, 29);
            this.lb_2.TabIndex = 3;
            this.lb_2.Text = "Trạng thái";
            // 
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lb_3.Location = new System.Drawing.Point(35, 473);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(131, 29);
            this.lb_3.TabIndex = 4;
            this.lb_3.Text = "Trạng thái";
            // 
            // frm_AddBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1039, 653);
            this.Controls.Add(this.lb_3);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_AddBan";
            this.Text = "Chọn bàn ăn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ibtn_ApDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_SapXep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_TrangThai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Label lb_3;
    }
}