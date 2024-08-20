namespace BTWindownsForm
{
	partial class frmBai3
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
			this.label3 = new System.Windows.Forms.Label();
			this.txtSoA = new System.Windows.Forms.TextBox();
			this.txtSoN = new System.Windows.Forms.TextBox();
			this.txtSoB = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.rdTongAB = new System.Windows.Forms.RadioButton();
			this.btnXemKq = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblKetQua = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(60, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số a =";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(60, 166);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Số n =";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(60, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Số b =";
			// 
			// txtSoA
			// 
			this.txtSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoA.Location = new System.Drawing.Point(133, 53);
			this.txtSoA.Name = "txtSoA";
			this.txtSoA.Size = new System.Drawing.Size(202, 27);
			this.txtSoA.TabIndex = 3;
			this.txtSoA.Text = "0";
			// 
			// txtSoN
			// 
			this.txtSoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoN.Location = new System.Drawing.Point(133, 163);
			this.txtSoN.Name = "txtSoN";
			this.txtSoN.Size = new System.Drawing.Size(202, 27);
			this.txtSoN.TabIndex = 4;
			this.txtSoN.Text = "0";
			// 
			// txtSoB
			// 
			this.txtSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoB.Location = new System.Drawing.Point(133, 106);
			this.txtSoB.Name = "txtSoB";
			this.txtSoB.Size = new System.Drawing.Size(202, 27);
			this.txtSoB.TabIndex = 5;
			this.txtSoB.Text = "0";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.rdTongAB);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(110, 218);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(236, 93);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn phép toán";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(23, 57);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(178, 24);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Tính tổng từ 1 đến n";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// rdTongAB
			// 
			this.rdTongAB.AutoSize = true;
			this.rdTongAB.Location = new System.Drawing.Point(23, 27);
			this.rdTongAB.Name = "rdTongAB";
			this.rdTongAB.Size = new System.Drawing.Size(159, 24);
			this.rdTongAB.TabIndex = 0;
			this.rdTongAB.TabStop = true;
			this.rdTongAB.Text = "Tính tổng của a b";
			this.rdTongAB.UseVisualStyleBackColor = true;
			// 
			// btnXemKq
			// 
			this.btnXemKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXemKq.Location = new System.Drawing.Point(152, 317);
			this.btnXemKq.Name = "btnXemKq";
			this.btnXemKq.Size = new System.Drawing.Size(123, 40);
			this.btnXemKq.TabIndex = 7;
			this.btnXemKq.Text = "Xem kết quả";
			this.btnXemKq.UseVisualStyleBackColor = true;
			this.btnXemKq.Click += new System.EventHandler(this.btnXemKq_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Firebrick;
			this.label4.Location = new System.Drawing.Point(60, 383);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Kết quả là :";
			// 
			// lblKetQua
			// 
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKetQua.ForeColor = System.Drawing.Color.Firebrick;
			this.lblKetQua.Location = new System.Drawing.Point(169, 383);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(13, 20);
			this.lblKetQua.TabIndex = 9;
			this.lblKetQua.Text = ".";
			// 
			// frmBai3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(455, 433);
			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnXemKq);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtSoB);
			this.Controls.Add(this.txtSoN);
			this.Controls.Add(this.txtSoA);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai3";
			this.Text = "Bài 3";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSoA;
		private System.Windows.Forms.TextBox txtSoN;
		private System.Windows.Forms.TextBox txtSoB;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton rdTongAB;
		private System.Windows.Forms.Button btnXemKq;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblKetQua;
	}
}