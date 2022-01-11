
namespace QLNH.GUI_QLNH
{
    partial class frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lb_Login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Login.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btn_Login.Location = new System.Drawing.Point(155, 300);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(175, 36);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Log_in";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Red;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btn_Exit.Location = new System.Drawing.Point(471, 300);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(175, 36);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tb_Username.Location = new System.Drawing.Point(279, 162);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(367, 30);
            this.tb_Username.TabIndex = 2;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tb_Password.Location = new System.Drawing.Point(279, 230);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(367, 30);
            this.tb_Password.TabIndex = 3;
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.BackColor = System.Drawing.Color.Transparent;
            this.lb_Username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lb_Username.ForeColor = System.Drawing.SystemColors.Info;
            this.lb_Username.Location = new System.Drawing.Point(133, 164);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(126, 23);
            this.lb_Username.TabIndex = 4;
            this.lb_Username.Text = "USER NAME";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.BackColor = System.Drawing.Color.Transparent;
            this.lb_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lb_Password.ForeColor = System.Drawing.SystemColors.Info;
            this.lb_Password.Location = new System.Drawing.Point(134, 232);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(125, 23);
            this.lb_Password.TabIndex = 5;
            this.lb_Password.Text = "PASS WORD";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.BackColor = System.Drawing.Color.Transparent;
            this.lb_Login.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold);
            this.lb_Login.ForeColor = System.Drawing.Color.OliveDrab;
            this.lb_Login.Location = new System.Drawing.Point(293, 50);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(196, 55);
            this.lb_Login.TabIndex = 7;
            this.lb_Login.Text = "LOG IN";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 416);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Username);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG_IN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lb_Login;
    }
}

