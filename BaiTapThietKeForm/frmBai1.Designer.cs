﻿namespace BaiTapThietKeForm
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdTrang = new System.Windows.Forms.RadioButton();
			this.rdXanh = new System.Windows.Forms.RadioButton();
			this.rdDo = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.btnTinhTien = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblTongTien = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::BaiTapThietKeForm.Properties.Resources.maxresdefault;
			this.pictureBox1.Location = new System.Drawing.Point(12, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(312, 329);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdTrang);
			this.groupBox1.Controls.Add(this.rdXanh);
			this.groupBox1.Controls.Add(this.rdDo);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(522, 108);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 172);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn màu xe";
			// 
			// rdTrang
			// 
			this.rdTrang.AutoSize = true;
			this.rdTrang.Location = new System.Drawing.Point(7, 137);
			this.rdTrang.Name = "rdTrang";
			this.rdTrang.Size = new System.Drawing.Size(73, 24);
			this.rdTrang.TabIndex = 2;
			this.rdTrang.TabStop = true;
			this.rdTrang.Text = "Trắng";
			this.rdTrang.UseVisualStyleBackColor = true;
			this.rdTrang.CheckedChanged += new System.EventHandler(this.rdTrang_CheckedChanged);
			// 
			// rdXanh
			// 
			this.rdXanh.AutoSize = true;
			this.rdXanh.Location = new System.Drawing.Point(6, 26);
			this.rdXanh.Name = "rdXanh";
			this.rdXanh.Size = new System.Drawing.Size(68, 24);
			this.rdXanh.TabIndex = 1;
			this.rdXanh.TabStop = true;
			this.rdXanh.Text = "Xanh";
			this.rdXanh.UseVisualStyleBackColor = true;
			this.rdXanh.CheckedChanged += new System.EventHandler(this.rdXanh_CheckedChanged);
			// 
			// rdDo
			// 
			this.rdDo.AutoSize = true;
			this.rdDo.Location = new System.Drawing.Point(6, 77);
			this.rdDo.Name = "rdDo";
			this.rdDo.Size = new System.Drawing.Size(51, 24);
			this.rdDo.TabIndex = 0;
			this.rdDo.TabStop = true;
			this.rdDo.Text = "Đỏ";
			this.rdDo.UseVisualStyleBackColor = true;
			this.rdDo.CheckedChanged += new System.EventHandler(this.rdDo_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(399, 311);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Đơn giá";
			// 
			// txtDonGia
			// 
			this.txtDonGia.Location = new System.Drawing.Point(471, 311);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(178, 22);
			this.txtDonGia.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(655, 311);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(18, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "$";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(399, 354);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Số lượng";
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(480, 354);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(100, 22);
			this.txtSoLuong.TabIndex = 6;
			// 
			// btnTinhTien
			// 
			this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTinhTien.Location = new System.Drawing.Point(494, 397);
			this.btnTinhTien.Name = "btnTinhTien";
			this.btnTinhTien.Size = new System.Drawing.Size(108, 42);
			this.btnTinhTien.TabIndex = 7;
			this.btnTinhTien.Text = "Tính Tiền";
			this.btnTinhTien.UseVisualStyleBackColor = true;
			this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(250, 478);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(193, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Tổng tiền thanh toán :";
			// 
			// lblTongTien
			// 
			this.lblTongTien.AutoSize = true;
			this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTongTien.Location = new System.Drawing.Point(494, 478);
			this.lblTongTien.Name = "lblTongTien";
			this.lblTongTien.Size = new System.Drawing.Size(0, 20);
			this.lblTongTien.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(478, 478);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 20);
			this.label5.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(655, 478);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(18, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "$";
			// 
			// frmBai1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 577);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblTongTien);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnTinhTien);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtDonGia);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "frmBai1";
			this.Text = "Bài 1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdTrang;
		private System.Windows.Forms.RadioButton rdXanh;
		private System.Windows.Forms.RadioButton rdDo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Button btnTinhTien;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblTongTien;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}