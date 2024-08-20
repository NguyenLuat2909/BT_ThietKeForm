namespace BTWindownsFormBT2
{
	partial class frmBai1
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
			this.label2 = new System.Windows.Forms.Label();
			this.cbbMaTB = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTenTB = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNuocSX = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.btnThanhTien = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.lblTongTien = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(62, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã thiết bị :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(146, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = ".";
			// 
			// cbbMaTB
			// 
			this.cbbMaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbMaTB.FormattingEnabled = true;
			this.cbbMaTB.Items.AddRange(new object[] {
            "SM-G991B",
            "XPS 13 9310",
            "HL-L2350DW",
            "D850"});
			this.cbbMaTB.Location = new System.Drawing.Point(189, 29);
			this.cbbMaTB.Name = "cbbMaTB";
			this.cbbMaTB.Size = new System.Drawing.Size(190, 28);
			this.cbbMaTB.TabIndex = 2;
			this.cbbMaTB.SelectedIndexChanged += new System.EventHandler(this.cbbMaTB_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(56, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Tên thiết bị :";
			// 
			// txtTenTB
			// 
			this.txtTenTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenTB.Location = new System.Drawing.Point(189, 67);
			this.txtTenTB.Name = "txtTenTB";
			this.txtTenTB.Size = new System.Drawing.Size(269, 27);
			this.txtTenTB.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(31, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(141, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Nước sản xuất :";
			// 
			// txtNuocSX
			// 
			this.txtNuocSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNuocSX.Location = new System.Drawing.Point(189, 101);
			this.txtNuocSX.Name = "txtNuocSX";
			this.txtNuocSX.Size = new System.Drawing.Size(237, 27);
			this.txtNuocSX.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(87, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 20);
			this.label5.TabIndex = 7;
			this.label5.Text = "Đơn giá :";
			// 
			// txtDonGia
			// 
			this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDonGia.Location = new System.Drawing.Point(189, 141);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(148, 27);
			this.txtDonGia.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(343, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(19, 20);
			this.label6.TabIndex = 9;
			this.label6.Text = "$";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(78, 180);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 20);
			this.label7.TabIndex = 10;
			this.label7.Text = "Số lượng :";
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoLuong.Location = new System.Drawing.Point(189, 177);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(88, 27);
			this.txtSoLuong.TabIndex = 11;
			// 
			// btnThanhTien
			// 
			this.btnThanhTien.BackColor = System.Drawing.Color.Snow;
			this.btnThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThanhTien.Location = new System.Drawing.Point(219, 230);
			this.btnThanhTien.Name = "btnThanhTien";
			this.btnThanhTien.Size = new System.Drawing.Size(160, 47);
			this.btnThanhTien.TabIndex = 12;
			this.btnThanhTien.Text = "Thành Tiền";
			this.btnThanhTien.UseVisualStyleBackColor = false;
			this.btnThanhTien.Click += new System.EventHandler(this.btnThanhTien_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.OrangeRed;
			this.label8.Location = new System.Drawing.Point(35, 301);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(125, 20);
			this.label8.TabIndex = 13;
			this.label8.Text = "Tổng số tiền :";
			// 
			// lblTongTien
			// 
			this.lblTongTien.AutoSize = true;
			this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTongTien.ForeColor = System.Drawing.Color.OrangeRed;
			this.lblTongTien.Location = new System.Drawing.Point(185, 301);
			this.lblTongTien.Name = "lblTongTien";
			this.lblTongTien.Size = new System.Drawing.Size(14, 20);
			this.lblTongTien.TabIndex = 14;
			this.lblTongTien.Text = ".";
			// 
			// frmBai1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MistyRose;
			this.ClientSize = new System.Drawing.Size(546, 353);
			this.Controls.Add(this.lblTongTien);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnThanhTien);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtDonGia);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtNuocSX);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTenTB);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbbMaTB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai1";
			this.Text = "Bài 1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbbMaTB;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTenTB;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNuocSX;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Button btnThanhTien;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblTongTien;
	}
}