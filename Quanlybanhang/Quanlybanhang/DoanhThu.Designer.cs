namespace Quanlybanhang
{
    partial class DoanhThu
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDT = new System.Windows.Forms.DataGridView();
            this.butDT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDoanhthu = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ DOANH THU THEO NGÀY";
            // 
            // dataGridViewDT
            // 
            this.dataGridViewDT.AllowUserToAddRows = false;
            this.dataGridViewDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDT.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dataGridViewDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDT.Location = new System.Drawing.Point(261, 210);
            this.dataGridViewDT.Name = "dataGridViewDT";
            this.dataGridViewDT.Size = new System.Drawing.Size(613, 176);
            this.dataGridViewDT.TabIndex = 1;
            // 
            // butDT
            // 
            this.butDT.AutoSize = true;
            this.butDT.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDT.Location = new System.Drawing.Point(647, 114);
            this.butDT.Name = "butDT";
            this.butDT.Size = new System.Drawing.Size(286, 34);
            this.butDT.TabIndex = 2;
            this.butDT.Text = "Xem Thông Kê Doanh Thu";
            this.butDT.UseVisualStyleBackColor = true;
            this.butDT.Click += new System.EventHandler(this.butDT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn Ngày :";
            // 
            // dtpDoanhthu
            // 
            this.dtpDoanhthu.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDoanhthu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDoanhthu.Location = new System.Drawing.Point(418, 114);
            this.dtpDoanhthu.Name = "dtpDoanhthu";
            this.dtpDoanhthu.Size = new System.Drawing.Size(200, 32);
            this.dtpDoanhthu.TabIndex = 4;
            this.dtpDoanhthu.Value = new System.DateTime(2022, 1, 21, 0, 0, 0, 0);
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dtpDoanhthu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butDT);
            this.Controls.Add(this.dataGridViewDT);
            this.Controls.Add(this.label1);
            this.Name = "DoanhThu";
            this.Size = new System.Drawing.Size(1259, 580);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDT;
        private System.Windows.Forms.Button butDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDoanhthu;
    }
}
