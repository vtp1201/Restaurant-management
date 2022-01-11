
namespace QLNH.GUI_QLNH
{
    partial class List_HoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lb_Ban = new System.Windows.Forms.Label();
            this.lb_SoHoaDon = new System.Windows.Forms.Label();
            this.lb_NgayMua = new System.Windows.Forms.Label();
            this.lb_Tien = new System.Windows.Forms.Label();
            this.lb_Status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(175, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 21);
            this.panel1.TabIndex = 22;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelLogo.Controls.Add(this.lb_Ban);
            this.panelLogo.Controls.Add(this.lb_SoHoaDon);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(247, 148);
            this.panelLogo.TabIndex = 23;
            // 
            // lb_Ban
            // 
            this.lb_Ban.AutoSize = true;
            this.lb_Ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lb_Ban.Location = new System.Drawing.Point(28, 83);
            this.lb_Ban.Name = "lb_Ban";
            this.lb_Ban.Size = new System.Drawing.Size(83, 29);
            this.lb_Ban.TabIndex = 22;
            this.lb_Ban.Text = "lb_Gia";
            // 
            // lb_SoHoaDon
            // 
            this.lb_SoHoaDon.AutoSize = true;
            this.lb_SoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.lb_SoHoaDon.Location = new System.Drawing.Point(3, 28);
            this.lb_SoHoaDon.Name = "lb_SoHoaDon";
            this.lb_SoHoaDon.Size = new System.Drawing.Size(220, 32);
            this.lb_SoHoaDon.TabIndex = 15;
            this.lb_SoHoaDon.Text = "Hóa đơn số: 50";
            // 
            // lb_NgayMua
            // 
            this.lb_NgayMua.AutoSize = true;
            this.lb_NgayMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayMua.Location = new System.Drawing.Point(264, 16);
            this.lb_NgayMua.Name = "lb_NgayMua";
            this.lb_NgayMua.Size = new System.Drawing.Size(64, 25);
            this.lb_NgayMua.TabIndex = 24;
            this.lb_NgayMua.Text = "label1";
            // 
            // lb_Tien
            // 
            this.lb_Tien.AutoSize = true;
            this.lb_Tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tien.Location = new System.Drawing.Point(264, 57);
            this.lb_Tien.Name = "lb_Tien";
            this.lb_Tien.Size = new System.Drawing.Size(64, 25);
            this.lb_Tien.TabIndex = 25;
            this.lb_Tien.Text = "label1";
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Status.Location = new System.Drawing.Point(264, 95);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(85, 29);
            this.lb_Status.TabIndex = 26;
            this.lb_Status.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(573, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 51);
            this.button1.TabIndex = 27;
            this.button1.Text = "Xem chi tiết";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // List_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.lb_Tien);
            this.Controls.Add(this.lb_NgayMua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLogo);
            this.Name = "List_HoaDon";
            this.Size = new System.Drawing.Size(800, 148);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lb_SoHoaDon;
        private System.Windows.Forms.Label lb_Ban;
        private System.Windows.Forms.Label lb_NgayMua;
        private System.Windows.Forms.Label lb_Tien;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Button button1;
    }
}
