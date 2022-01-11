
namespace QLNH.GUI_QLNH.GUI_QL
{
    partial class frm_QLBanCaLamcs
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
            this.button5 = new System.Windows.Forms.Button();
            this.dgv_Ban = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_Ban = new System.Windows.Forms.ListView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbb_TenCa = new System.Windows.Forms.ComboBox();
            this.cbb_PhanLoai = new System.Windows.Forms.ComboBox();
            this.btn_PhanLoai = new System.Windows.Forms.Button();
            this.btn_CaLam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ban)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(428, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Danh sách bàn trong ca làm";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(5, 7);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 31);
            this.button5.TabIndex = 30;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dgv_Ban
            // 
            this.dgv_Ban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Ban.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Ban.ColumnHeadersHeight = 29;
            this.dgv_Ban.Location = new System.Drawing.Point(433, 144);
            this.dgv_Ban.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Ban.Name = "dgv_Ban";
            this.dgv_Ban.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Ban.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Ban.Size = new System.Drawing.Size(487, 566);
            this.dgv_Ban.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(331, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 44);
            this.label1.TabIndex = 28;
            this.label1.Text = "QUẢN LÝ BÀN";
            // 
            // lv_Ban
            // 
            this.lv_Ban.HideSelection = false;
            this.lv_Ban.Location = new System.Drawing.Point(25, 144);
            this.lv_Ban.Name = "lv_Ban";
            this.lv_Ban.Scrollable = false;
            this.lv_Ban.Size = new System.Drawing.Size(341, 505);
            this.lv_Ban.TabIndex = 20;
            this.lv_Ban.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(128, 655);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(109, 55);
            this.btn_Add.TabIndex = 35;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(433, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 27);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // cbb_TenCa
            // 
            this.cbb_TenCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TenCa.FormattingEnabled = true;
            this.cbb_TenCa.Location = new System.Drawing.Point(569, 112);
            this.cbb_TenCa.Name = "cbb_TenCa";
            this.cbb_TenCa.Size = new System.Drawing.Size(121, 28);
            this.cbb_TenCa.TabIndex = 37;
            // 
            // cbb_PhanLoai
            // 
            this.cbb_PhanLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_PhanLoai.FormattingEnabled = true;
            this.cbb_PhanLoai.Location = new System.Drawing.Point(25, 111);
            this.cbb_PhanLoai.Name = "cbb_PhanLoai";
            this.cbb_PhanLoai.Size = new System.Drawing.Size(141, 28);
            this.cbb_PhanLoai.TabIndex = 38;
            // 
            // btn_PhanLoai
            // 
            this.btn_PhanLoai.BackColor = System.Drawing.Color.Aqua;
            this.btn_PhanLoai.Location = new System.Drawing.Point(172, 112);
            this.btn_PhanLoai.Name = "btn_PhanLoai";
            this.btn_PhanLoai.Size = new System.Drawing.Size(108, 29);
            this.btn_PhanLoai.TabIndex = 39;
            this.btn_PhanLoai.Text = "Áp dụng";
            this.btn_PhanLoai.UseVisualStyleBackColor = false;
            this.btn_PhanLoai.Click += new System.EventHandler(this.btn_PhanLoai_Click);
            // 
            // btn_CaLam
            // 
            this.btn_CaLam.BackColor = System.Drawing.Color.Aqua;
            this.btn_CaLam.Location = new System.Drawing.Point(696, 112);
            this.btn_CaLam.Name = "btn_CaLam";
            this.btn_CaLam.Size = new System.Drawing.Size(108, 29);
            this.btn_CaLam.TabIndex = 40;
            this.btn_CaLam.Text = "Áp dụng";
            this.btn_CaLam.UseVisualStyleBackColor = false;
            this.btn_CaLam.Click += new System.EventHandler(this.btn_CaLam_Click);
            // 
            // frm_QLBanCaLamcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(932, 753);
            this.Controls.Add(this.btn_CaLam);
            this.Controls.Add(this.btn_PhanLoai);
            this.Controls.Add(this.cbb_PhanLoai);
            this.Controls.Add(this.cbb_TenCa);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lv_Ban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgv_Ban);
            this.Controls.Add(this.label1);
            this.Name = "frm_QLBanCaLamcs";
            this.Text = "frm_QLBanCaLamcs";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgv_Ban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_Ban;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox cbb_TenCa;
        public System.Windows.Forms.ComboBox cbb_PhanLoai;
        private System.Windows.Forms.Button btn_PhanLoai;
        private System.Windows.Forms.Button btn_CaLam;
    }
}