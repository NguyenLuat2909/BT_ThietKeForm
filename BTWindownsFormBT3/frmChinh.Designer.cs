﻿namespace BTWindownsFormBT3
{
	partial class frmChinh
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
			this.btnBai1 = new System.Windows.Forms.Button();
			this.btnBai2 = new System.Windows.Forms.Button();
			this.btnBai3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBai1
			// 
			this.btnBai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBai1.Location = new System.Drawing.Point(68, 65);
			this.btnBai1.Name = "btnBai1";
			this.btnBai1.Size = new System.Drawing.Size(120, 36);
			this.btnBai1.TabIndex = 0;
			this.btnBai1.Text = "Bài 1";
			this.btnBai1.UseVisualStyleBackColor = true;
			this.btnBai1.Click += new System.EventHandler(this.btnBai1_Click);
			// 
			// btnBai2
			// 
			this.btnBai2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBai2.Location = new System.Drawing.Point(218, 65);
			this.btnBai2.Name = "btnBai2";
			this.btnBai2.Size = new System.Drawing.Size(120, 36);
			this.btnBai2.TabIndex = 1;
			this.btnBai2.Text = "Bài 2";
			this.btnBai2.UseVisualStyleBackColor = true;
			// 
			// btnBai3
			// 
			this.btnBai3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBai3.Location = new System.Drawing.Point(360, 65);
			this.btnBai3.Name = "btnBai3";
			this.btnBai3.Size = new System.Drawing.Size(120, 36);
			this.btnBai3.TabIndex = 2;
			this.btnBai3.Text = "Bài 3";
			this.btnBai3.UseVisualStyleBackColor = true;
			// 
			// frmChinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(563, 185);
			this.Controls.Add(this.btnBai3);
			this.Controls.Add(this.btnBai2);
			this.Controls.Add(this.btnBai1);
			this.Name = "frmChinh";
			this.Text = "Chương trình chính";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnBai1;
		private System.Windows.Forms.Button btnBai2;
		private System.Windows.Forms.Button btnBai3;
	}
}

