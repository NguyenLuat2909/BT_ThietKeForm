namespace BTWindownsFormBT3
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
			this.txtNhapN = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.grbTinhTong = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lblKetQua = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập một số nguyên dương N :";
			// 
			// txtNhapN
			// 
			this.txtNhapN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNhapN.Location = new System.Drawing.Point(270, 37);
			this.txtNhapN.Name = "txtNhapN";
			this.txtNhapN.Size = new System.Drawing.Size(233, 27);
			this.txtNhapN.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.grbTinhTong);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(270, 98);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(233, 97);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn công việc :";
			// 
			// grbTinhTong
			// 
			this.grbTinhTong.AutoSize = true;
			this.grbTinhTong.Location = new System.Drawing.Point(7, 27);
			this.grbTinhTong.Name = "grbTinhTong";
			this.grbTinhTong.Size = new System.Drawing.Size(176, 24);
			this.grbTinhTong.TabIndex = 0;
			this.grbTinhTong.TabStop = true;
			this.grbTinhTong.Text = "Tính tổng 1+2+...+N";
			this.grbTinhTong.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(7, 57);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(181, 24);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Tính N giai thừa (N!)";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(229, 224);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(111, 33);
			this.button1.TabIndex = 3;
			this.button1.Text = "Xem kết quả :";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(131, 295);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kết quả là :";
			// 
			// lblKetQua
			// 
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKetQua.Location = new System.Drawing.Point(246, 295);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(13, 20);
			this.lblKetQua.TabIndex = 5;
			this.lblKetQua.Text = ".";
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(671, 422);
			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtNhapN);
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
		private System.Windows.Forms.TextBox txtNhapN;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton grbTinhTong;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblKetQua;
	}
}