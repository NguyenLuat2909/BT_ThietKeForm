namespace BTWindownsFormBT2
{
	partial class frmBai2
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
			this.txtSoThuNhat = new System.Windows.Forms.TextBox();
			this.txtSoThuHai = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdCong = new System.Windows.Forms.RadioButton();
			this.rdTru = new System.Windows.Forms.RadioButton();
			this.rdNhan = new System.Windows.Forms.RadioButton();
			this.rdChia = new System.Windows.Forms.RadioButton();
			this.btnKetQua = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblKetQua = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(63, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số thứ nhất:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(73, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Số thứ hai:";
			// 
			// txtSoThuNhat
			// 
			this.txtSoThuNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoThuNhat.Location = new System.Drawing.Point(179, 57);
			this.txtSoThuNhat.Name = "txtSoThuNhat";
			this.txtSoThuNhat.Size = new System.Drawing.Size(130, 27);
			this.txtSoThuNhat.TabIndex = 2;
			this.txtSoThuNhat.Text = "50";
			// 
			// txtSoThuHai
			// 
			this.txtSoThuHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoThuHai.Location = new System.Drawing.Point(179, 105);
			this.txtSoThuHai.Name = "txtSoThuHai";
			this.txtSoThuHai.Size = new System.Drawing.Size(130, 27);
			this.txtSoThuHai.TabIndex = 3;
			this.txtSoThuHai.Text = "30";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdChia);
			this.groupBox1.Controls.Add(this.rdNhan);
			this.groupBox1.Controls.Add(this.rdTru);
			this.groupBox1.Controls.Add(this.rdCong);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(101, 152);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(230, 155);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn phép toán:";
			// 
			// rdCong
			// 
			this.rdCong.AutoSize = true;
			this.rdCong.Location = new System.Drawing.Point(14, 27);
			this.rdCong.Name = "rdCong";
			this.rdCong.Size = new System.Drawing.Size(69, 24);
			this.rdCong.TabIndex = 0;
			this.rdCong.Text = "Cộng";
			this.rdCong.UseVisualStyleBackColor = true;
			// 
			// rdTru
			// 
			this.rdTru.AutoSize = true;
			this.rdTru.Checked = true;
			this.rdTru.Location = new System.Drawing.Point(14, 57);
			this.rdTru.Name = "rdTru";
			this.rdTru.Size = new System.Drawing.Size(60, 24);
			this.rdTru.TabIndex = 1;
			this.rdTru.TabStop = true;
			this.rdTru.Text = "Trừ ";
			this.rdTru.UseVisualStyleBackColor = true;
			// 
			// rdNhan
			// 
			this.rdNhan.AutoSize = true;
			this.rdNhan.Location = new System.Drawing.Point(14, 87);
			this.rdNhan.Name = "rdNhan";
			this.rdNhan.Size = new System.Drawing.Size(69, 24);
			this.rdNhan.TabIndex = 2;
			this.rdNhan.Text = "Nhân";
			this.rdNhan.UseVisualStyleBackColor = true;
			// 
			// rdChia
			// 
			this.rdChia.AutoSize = true;
			this.rdChia.Location = new System.Drawing.Point(14, 117);
			this.rdChia.Name = "rdChia";
			this.rdChia.Size = new System.Drawing.Size(64, 24);
			this.rdChia.TabIndex = 3;
			this.rdChia.Text = "Chia";
			this.rdChia.UseVisualStyleBackColor = true;
			// 
			// btnKetQua
			// 
			this.btnKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKetQua.Location = new System.Drawing.Point(131, 313);
			this.btnKetQua.Name = "btnKetQua";
			this.btnKetQua.Size = new System.Drawing.Size(151, 39);
			this.btnKetQua.TabIndex = 5;
			this.btnKetQua.Text = "Xem kết quả";
			this.btnKetQua.UseVisualStyleBackColor = true;
			this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(97, 386);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Kết quả là :";
			// 
			// lblKetQua
			// 
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKetQua.ForeColor = System.Drawing.Color.OrangeRed;
			this.lblKetQua.Location = new System.Drawing.Point(197, 386);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(27, 20);
			this.lblKetQua.TabIndex = 7;
			this.lblKetQua.Text = "20";
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(481, 450);
			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnKetQua);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtSoThuHai);
			this.Controls.Add(this.txtSoThuNhat);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai2";
			this.Text = "frmBai2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSoThuNhat;
		private System.Windows.Forms.TextBox txtSoThuHai;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdChia;
		private System.Windows.Forms.RadioButton rdNhan;
		private System.Windows.Forms.RadioButton rdTru;
		private System.Windows.Forms.RadioButton rdCong;
		private System.Windows.Forms.Button btnKetQua;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblKetQua;
	}
}