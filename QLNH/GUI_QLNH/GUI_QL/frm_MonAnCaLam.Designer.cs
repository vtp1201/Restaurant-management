
namespace QLNH.GUI_QLNH.GUI_QL
{
    partial class frm_MonAnCaLam
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
            this.btn_CaLam = new System.Windows.Forms.Button();
            this.cbb_TenCa = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_MonAn = new System.Windows.Forms.ListView();
            this.dgv_MonAnCaLam = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonAnCaLam)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CaLam
            // 
            this.btn_CaLam.BackColor = System.Drawing.Color.Aqua;
            this.btn_CaLam.Location = new System.Drawing.Point(693, 108);
            this.btn_CaLam.Name = "btn_CaLam";
            this.btn_CaLam.Size = new System.Drawing.Size(108, 29);
            this.btn_CaLam.TabIndex = 52;
            this.btn_CaLam.Text = "Áp dụng";
            this.btn_CaLam.UseVisualStyleBackColor = false;
            this.btn_CaLam.Click += new System.EventHandler(this.btn_CaLam_Click);
            // 
            // cbb_TenCa
            // 
            this.cbb_TenCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TenCa.FormattingEnabled = true;
            this.cbb_TenCa.Location = new System.Drawing.Point(556, 108);
            this.cbb_TenCa.Name = "cbb_TenCa";
            this.cbb_TenCa.Size = new System.Drawing.Size(121, 28);
            this.cbb_TenCa.TabIndex = 49;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(430, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 27);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(147, 651);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(109, 55);
            this.btn_Add.TabIndex = 47;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(427, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "Danh sách món ăn trong ca làm";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(2, 3);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 31);
            this.button5.TabIndex = 44;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(294, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 44);
            this.label1.TabIndex = 42;
            this.label1.Text = "QUẢN LÝ MÓN ĂN";
            // 
            // lv_MonAn
            // 
            this.lv_MonAn.HideSelection = false;
            this.lv_MonAn.Location = new System.Drawing.Point(23, 110);
            this.lv_MonAn.Name = "lv_MonAn";
            this.lv_MonAn.Size = new System.Drawing.Size(380, 535);
            this.lv_MonAn.TabIndex = 41;
            this.lv_MonAn.UseCompatibleStateImageBehavior = false;
            // 
            // dgv_MonAnCaLam
            // 
            this.dgv_MonAnCaLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MonAnCaLam.Location = new System.Drawing.Point(430, 143);
            this.dgv_MonAnCaLam.Name = "dgv_MonAnCaLam";
            this.dgv_MonAnCaLam.RowHeadersWidth = 51;
            this.dgv_MonAnCaLam.RowTemplate.Height = 24;
            this.dgv_MonAnCaLam.Size = new System.Drawing.Size(478, 502);
            this.dgv_MonAnCaLam.TabIndex = 53;
            // 
            // frm_MonAnCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(936, 754);
            this.Controls.Add(this.dgv_MonAnCaLam);
            this.Controls.Add(this.btn_CaLam);
            this.Controls.Add(this.cbb_TenCa);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_MonAn);
            this.Name = "frm_MonAnCaLam";
            this.Text = "frm_MonAnCaLam";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonAnCaLam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CaLam;
        public System.Windows.Forms.ComboBox cbb_TenCa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_MonAn;
        private System.Windows.Forms.DataGridView dgv_MonAnCaLam;
    }
}