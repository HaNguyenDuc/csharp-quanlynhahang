namespace QuanLyNhaHang
{
    partial class Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQLB = new System.Windows.Forms.Button();
            this.btnQLMA = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnQLDB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbQLCH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CỬA HÀNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1313, 574);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách đặt bàn";
            // 
            // btnQLB
            // 
            this.btnQLB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLB.Location = new System.Drawing.Point(1052, 143);
            this.btnQLB.Name = "btnQLB";
            this.btnQLB.Size = new System.Drawing.Size(139, 42);
            this.btnQLB.TabIndex = 3;
            this.btnQLB.Text = "Quản lý bàn";
            this.btnQLB.UseVisualStyleBackColor = true;
            this.btnQLB.Click += new System.EventHandler(this.btnQLB_Click);
            // 
            // btnQLMA
            // 
            this.btnQLMA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMA.Location = new System.Drawing.Point(894, 143);
            this.btnQLMA.Name = "btnQLMA";
            this.btnQLMA.Size = new System.Drawing.Size(152, 42);
            this.btnQLMA.TabIndex = 4;
            this.btnQLMA.Text = "Quản lý món ăn";
            this.btnQLMA.UseVisualStyleBackColor = true;
            this.btnQLMA.Click += new System.EventHandler(this.btnQLMA_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(1197, 143);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(139, 42);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnQLDB
            // 
            this.btnQLDB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDB.Location = new System.Drawing.Point(736, 143);
            this.btnQLDB.Name = "btnQLDB";
            this.btnQLDB.Size = new System.Drawing.Size(152, 42);
            this.btnQLDB.TabIndex = 6;
            this.btnQLDB.Text = "Quản lý đặt bàn";
            this.btnQLDB.UseVisualStyleBackColor = true;
            this.btnQLDB.Click += new System.EventHandler(this.btnQLDB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lọc theo:";
            // 
            // cbbQLCH
            // 
            this.cbbQLCH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQLCH.FormattingEnabled = true;
            this.cbbQLCH.Location = new System.Drawing.Point(306, 154);
            this.cbbQLCH.Name = "cbbQLCH";
            this.cbbQLCH.Size = new System.Drawing.Size(165, 31);
            this.cbbQLCH.TabIndex = 8;
            this.cbbQLCH.SelectedIndexChanged += new System.EventHandler(this.cbbQLCH_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 777);
            this.Controls.Add(this.cbbQLCH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnQLDB);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnQLMA);
            this.Controls.Add(this.btnQLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQLB;
        private System.Windows.Forms.Button btnQLMA;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnQLDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbQLCH;
    }
}