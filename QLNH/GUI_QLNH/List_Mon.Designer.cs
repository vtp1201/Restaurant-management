
namespace QLNH.GUI_QLNH
{
    partial class List_Mon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ptb_Picture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Gia = new System.Windows.Forms.Label();
            this.lb_ConLai = new System.Windows.Forms.Label();
            this.ibtn_Add = new FontAwesome.Sharp.IconButton();
            this.tb_SoLuong = new System.Windows.Forms.TextBox();
            this.ibtn_Tru = new FontAwesome.Sharp.IconButton();
            this.ibtn_Cong = new FontAwesome.Sharp.IconButton();
            this.rtb_MoTa = new System.Windows.Forms.RichTextBox();
            this.lb_TenMon = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Picture)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptb_Picture
            // 
            this.ptb_Picture.Location = new System.Drawing.Point(19, 14);
            this.ptb_Picture.Name = "ptb_Picture";
            this.ptb_Picture.Size = new System.Drawing.Size(164, 113);
            this.ptb_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Picture.TabIndex = 0;
            this.ptb_Picture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(170, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 21);
            this.panel1.TabIndex = 12;
            // 
            // lb_Gia
            // 
            this.lb_Gia.AutoSize = true;
            this.lb_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lb_Gia.Location = new System.Drawing.Point(223, 55);
            this.lb_Gia.Name = "lb_Gia";
            this.lb_Gia.Size = new System.Drawing.Size(83, 29);
            this.lb_Gia.TabIndex = 21;
            this.lb_Gia.Text = "lb_Gia";
            // 
            // lb_ConLai
            // 
            this.lb_ConLai.AutoSize = true;
            this.lb_ConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ConLai.ForeColor = System.Drawing.Color.Red;
            this.lb_ConLai.Location = new System.Drawing.Point(619, 64);
            this.lb_ConLai.Name = "lb_ConLai";
            this.lb_ConLai.Size = new System.Drawing.Size(94, 20);
            this.lb_ConLai.TabIndex = 20;
            this.lb_ConLai.Text = "Còn lại : 10";
            // 
            // ibtn_Add
            // 
            this.ibtn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ibtn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ibtn_Add.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.ibtn_Add.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.ibtn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_Add.IconSize = 50;
            this.ibtn_Add.Location = new System.Drawing.Point(629, 100);
            this.ibtn_Add.Name = "ibtn_Add";
            this.ibtn_Add.Size = new System.Drawing.Size(69, 38);
            this.ibtn_Add.TabIndex = 19;
            this.ibtn_Add.UseVisualStyleBackColor = true;
            this.ibtn_Add.Click += new System.EventHandler(this.ibtn_Add_Click);
            // 
            // tb_SoLuong
            // 
            this.tb_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SoLuong.Location = new System.Drawing.Point(635, 27);
            this.tb_SoLuong.Name = "tb_SoLuong";
            this.tb_SoLuong.Size = new System.Drawing.Size(63, 34);
            this.tb_SoLuong.TabIndex = 18;
            this.tb_SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ibtn_Tru
            // 
            this.ibtn_Tru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ibtn_Tru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_Tru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ibtn_Tru.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.ibtn_Tru.IconColor = System.Drawing.Color.White;
            this.ibtn_Tru.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_Tru.Location = new System.Drawing.Point(553, 22);
            this.ibtn_Tru.Name = "ibtn_Tru";
            this.ibtn_Tru.Size = new System.Drawing.Size(72, 52);
            this.ibtn_Tru.TabIndex = 17;
            this.ibtn_Tru.UseVisualStyleBackColor = true;
            this.ibtn_Tru.Click += new System.EventHandler(this.ibtn_Tru_Click);
            // 
            // ibtn_Cong
            // 
            this.ibtn_Cong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ibtn_Cong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_Cong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ibtn_Cong.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtn_Cong.IconColor = System.Drawing.Color.White;
            this.ibtn_Cong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_Cong.Location = new System.Drawing.Point(704, 22);
            this.ibtn_Cong.Name = "ibtn_Cong";
            this.ibtn_Cong.Size = new System.Drawing.Size(72, 52);
            this.ibtn_Cong.TabIndex = 16;
            this.ibtn_Cong.UseVisualStyleBackColor = true;
            this.ibtn_Cong.Click += new System.EventHandler(this.ibtn_Cong_Click);
            // 
            // rtb_MoTa
            // 
            this.rtb_MoTa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.rtb_MoTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_MoTa.ForeColor = System.Drawing.Color.Transparent;
            this.rtb_MoTa.Location = new System.Drawing.Point(228, 87);
            this.rtb_MoTa.Name = "rtb_MoTa";
            this.rtb_MoTa.Size = new System.Drawing.Size(285, 51);
            this.rtb_MoTa.TabIndex = 15;
            this.rtb_MoTa.Text = "rtb_MoTa";
            // 
            // lb_TenMon
            // 
            this.lb_TenMon.AutoSize = true;
            this.lb_TenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lb_TenMon.Location = new System.Drawing.Point(222, 22);
            this.lb_TenMon.Name = "lb_TenMon";
            this.lb_TenMon.Size = new System.Drawing.Size(166, 32);
            this.lb_TenMon.TabIndex = 14;
            this.lb_TenMon.Text = "lb_TenMon";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelLogo.Controls.Add(this.ptb_Picture);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(205, 148);
            this.panelLogo.TabIndex = 13;
            // 
            // List_Mon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_Gia);
            this.Controls.Add(this.lb_ConLai);
            this.Controls.Add(this.ibtn_Add);
            this.Controls.Add(this.tb_SoLuong);
            this.Controls.Add(this.ibtn_Tru);
            this.Controls.Add(this.ibtn_Cong);
            this.Controls.Add(this.rtb_MoTa);
            this.Controls.Add(this.lb_TenMon);
            this.Controls.Add(this.panelLogo);
            this.Name = "List_Mon";
            this.Size = new System.Drawing.Size(789, 148);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Picture)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_Picture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Gia;
        private System.Windows.Forms.Label lb_ConLai;
        private FontAwesome.Sharp.IconButton ibtn_Add;
        private System.Windows.Forms.TextBox tb_SoLuong;
        private FontAwesome.Sharp.IconButton ibtn_Tru;
        private FontAwesome.Sharp.IconButton ibtn_Cong;
        private System.Windows.Forms.RichTextBox rtb_MoTa;
        private System.Windows.Forms.Label lb_TenMon;
        private System.Windows.Forms.Panel panelLogo;
    }
}
