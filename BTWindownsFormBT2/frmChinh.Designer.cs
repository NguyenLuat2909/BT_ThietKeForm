﻿namespace BTWindownsFormBT2
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.bàiKiểmTraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bàiSố1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bàiSố2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bàiSố3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Snow;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiKiểmTraToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(409, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// bàiKiểmTraToolStripMenuItem
			// 
			this.bàiKiểmTraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiSố1ToolStripMenuItem,
            this.bàiSố2ToolStripMenuItem,
            this.bàiSố3ToolStripMenuItem});
			this.bàiKiểmTraToolStripMenuItem.Image = global::BTWindownsFormBT2.Properties.Resources.test;
			this.bàiKiểmTraToolStripMenuItem.Name = "bàiKiểmTraToolStripMenuItem";
			this.bàiKiểmTraToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
			this.bàiKiểmTraToolStripMenuItem.Text = "Bài kiểm tra";
			// 
			// bàiSố1ToolStripMenuItem
			// 
			this.bàiSố1ToolStripMenuItem.Image = global::BTWindownsFormBT2.Properties.Resources.reading_book;
			this.bàiSố1ToolStripMenuItem.Name = "bàiSố1ToolStripMenuItem";
			this.bàiSố1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.bàiSố1ToolStripMenuItem.Text = "Bài số 1";
			this.bàiSố1ToolStripMenuItem.Click += new System.EventHandler(this.bàiSố1ToolStripMenuItem_Click);
			// 
			// bàiSố2ToolStripMenuItem
			// 
			this.bàiSố2ToolStripMenuItem.Image = global::BTWindownsFormBT2.Properties.Resources.open_book;
			this.bàiSố2ToolStripMenuItem.Name = "bàiSố2ToolStripMenuItem";
			this.bàiSố2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.bàiSố2ToolStripMenuItem.Text = "Bài số 2";
			this.bàiSố2ToolStripMenuItem.Click += new System.EventHandler(this.bàiSố2ToolStripMenuItem_Click);
			// 
			// bàiSố3ToolStripMenuItem
			// 
			this.bàiSố3ToolStripMenuItem.Image = global::BTWindownsFormBT2.Properties.Resources.book;
			this.bàiSố3ToolStripMenuItem.Name = "bàiSố3ToolStripMenuItem";
			this.bàiSố3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.bàiSố3ToolStripMenuItem.Text = "Bài số 3";
			this.bàiSố3ToolStripMenuItem.Click += new System.EventHandler(this.bàiSố3ToolStripMenuItem_Click);
			// 
			// frmChinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(409, 265);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmChinh";
			this.Text = "Chương trình chính";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem bàiKiểmTraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bàiSố1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bàiSố2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bàiSố3ToolStripMenuItem;
	}
}

