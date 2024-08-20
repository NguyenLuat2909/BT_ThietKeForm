namespace BTWindownsFormBT2
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
			this.txtHo = new System.Windows.Forms.TextBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.lbHoTen = new System.Windows.Forms.ListBox();
			this.btnChon = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Họ : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên : ";
			// 
			// txtHo
			// 
			this.txtHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHo.Location = new System.Drawing.Point(83, 47);
			this.txtHo.Name = "txtHo";
			this.txtHo.Size = new System.Drawing.Size(124, 27);
			this.txtHo.TabIndex = 2;
			// 
			// txtTen
			// 
			this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTen.Location = new System.Drawing.Point(83, 93);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(124, 27);
			this.txtTen.TabIndex = 3;
			// 
			// lbHoTen
			// 
			this.lbHoTen.FormattingEnabled = true;
			this.lbHoTen.ItemHeight = 16;
			this.lbHoTen.Location = new System.Drawing.Point(333, 12);
			this.lbHoTen.Name = "lbHoTen";
			this.lbHoTen.Size = new System.Drawing.Size(181, 132);
			this.lbHoTen.TabIndex = 4;
			// 
			// btnChon
			// 
			this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChon.Location = new System.Drawing.Point(232, 61);
			this.btnChon.Name = "btnChon";
			this.btnChon.Size = new System.Drawing.Size(85, 45);
			this.btnChon.TabIndex = 5;
			this.btnChon.Text = "=>";
			this.btnChon.UseVisualStyleBackColor = true;
			this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
			// 
			// frmBai3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 450);
			this.Controls.Add(this.btnChon);
			this.Controls.Add(this.lbHoTen);
			this.Controls.Add(this.txtTen);
			this.Controls.Add(this.txtHo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai3";
			this.Text = "Bài 3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtHo;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.ListBox lbHoTen;
		private System.Windows.Forms.Button btnChon;
	}
}