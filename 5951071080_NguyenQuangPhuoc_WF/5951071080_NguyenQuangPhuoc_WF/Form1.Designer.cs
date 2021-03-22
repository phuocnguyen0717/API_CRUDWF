
namespace _5951071080_NguyenQuangPhuoc_WF
{
    partial class Form1
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.txb_Hoten = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_Hoten = new System.Windows.Forms.Label();
            this.txb_SBD = new System.Windows.Forms.TextBox();
            this.lbl_SBD = new System.Windows.Forms.Label();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txb_Ten = new System.Windows.Forms.TextBox();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.txb_Sdt = new System.Windows.Forms.TextBox();
            this.lbl_Sdt = new System.Windows.Forms.Label();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(29, 165);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(87, 46);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txb_Hoten
            // 
            this.txb_Hoten.Location = new System.Drawing.Point(156, 38);
            this.txb_Hoten.Name = "txb_Hoten";
            this.txb_Hoten.Size = new System.Drawing.Size(100, 22);
            this.txb_Hoten.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(557, 177);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_Hoten
            // 
            this.lbl_Hoten.AutoSize = true;
            this.lbl_Hoten.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hoten.Location = new System.Drawing.Point(25, 38);
            this.lbl_Hoten.Name = "lbl_Hoten";
            this.lbl_Hoten.Size = new System.Drawing.Size(107, 19);
            this.lbl_Hoten.TabIndex = 4;
            this.lbl_Hoten.Text = "Họ sinh viên:";
            // 
            // txb_SBD
            // 
            this.txb_SBD.Location = new System.Drawing.Point(156, 74);
            this.txb_SBD.Name = "txb_SBD";
            this.txb_SBD.Size = new System.Drawing.Size(100, 22);
            this.txb_SBD.TabIndex = 1;
            // 
            // lbl_SBD
            // 
            this.lbl_SBD.AutoSize = true;
            this.lbl_SBD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SBD.Location = new System.Drawing.Point(25, 74);
            this.lbl_SBD.Name = "lbl_SBD";
            this.lbl_SBD.Size = new System.Drawing.Size(102, 19);
            this.lbl_SBD.TabIndex = 4;
            this.lbl_SBD.Text = "Số báo danh:";
            // 
            // txb_Address
            // 
            this.txb_Address.Location = new System.Drawing.Point(156, 109);
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(100, 22);
            this.txb_Address.TabIndex = 1;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(25, 109);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(68, 19);
            this.lbl_Address.TabIndex = 4;
            this.lbl_Address.Text = "Địa chỉ:";
            // 
            // txb_Ten
            // 
            this.txb_Ten.Location = new System.Drawing.Point(441, 41);
            this.txb_Ten.Name = "txb_Ten";
            this.txb_Ten.Size = new System.Drawing.Size(100, 22);
            this.txb_Ten.TabIndex = 1;
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten.Location = new System.Drawing.Point(310, 41);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(114, 19);
            this.lbl_Ten.TabIndex = 4;
            this.lbl_Ten.Text = "Tên Sinh viên:";
            // 
            // txb_Sdt
            // 
            this.txb_Sdt.Location = new System.Drawing.Point(441, 74);
            this.txb_Sdt.Name = "txb_Sdt";
            this.txb_Sdt.Size = new System.Drawing.Size(100, 22);
            this.txb_Sdt.TabIndex = 1;
            // 
            // lbl_Sdt
            // 
            this.lbl_Sdt.AutoSize = true;
            this.lbl_Sdt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sdt.Location = new System.Drawing.Point(310, 74);
            this.lbl_Sdt.Name = "lbl_Sdt";
            this.lbl_Sdt.Size = new System.Drawing.Size(111, 19);
            this.lbl_Sdt.TabIndex = 4;
            this.lbl_Sdt.Text = "Số điện thoại:";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(143, 165);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(87, 46);
            this.btn_CapNhat.TabIndex = 0;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(263, 165);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(87, 46);
            this.btn_Sua.TabIndex = 0;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(392, 165);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(87, 46);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 409);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_SBD);
            this.Controls.Add(this.txb_Address);
            this.Controls.Add(this.lbl_Sdt);
            this.Controls.Add(this.lbl_Ten);
            this.Controls.Add(this.lbl_Hoten);
            this.Controls.Add(this.txb_Sdt);
            this.Controls.Add(this.txb_SBD);
            this.Controls.Add(this.txb_Ten);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txb_Hoten);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Them);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txb_Hoten;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Hoten;
        private System.Windows.Forms.TextBox txb_SBD;
        private System.Windows.Forms.Label lbl_SBD;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txb_Ten;
        private System.Windows.Forms.Label lbl_Ten;
        private System.Windows.Forms.TextBox txb_Sdt;
        private System.Windows.Forms.Label lbl_Sdt;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
    }
}

