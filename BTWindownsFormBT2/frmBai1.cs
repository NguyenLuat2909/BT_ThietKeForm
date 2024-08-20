using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindownsFormBT2
{
	public partial class frmBai1 : Form
	{
		public frmBai1()
		{
			InitializeComponent();
		}

		private void cbbMaTB_SelectedIndexChanged(object sender, EventArgs e)
		{
			var stt = cbbMaTB.SelectedIndex;
			switch(stt)
			{
				case 0:
					txtTenTB.Text = "Samsung Galaxy S21";
					txtNuocSX.Text = "Hàn Quốc";
					txtDonGia.Text = "800";
					break;
				case 1:
					txtTenTB.Text = "Máy tính xách tay Dell XPS 13";
					txtNuocSX.Text = "Mỹ";
					txtDonGia.Text = "1500";
					break;
				case 2:
					txtTenTB.Text = "Máy in Brother HL-L2350DW";
					txtNuocSX.Text = "Nhật Bản";
					txtDonGia.Text = "150";
					break;
				case 3:
					txtTenTB.Text = "Máy ảnh kỹ thuật số Nikon D850";
					txtNuocSX.Text = "Nhật Bản";
					txtDonGia.Text = "3000";
					break;
			}
		}

		private void btnThanhTien_Click(object sender, EventArgs e)
		{
			int donGia = int.Parse(txtDonGia.Text);
			int soLuong = int.Parse(txtSoLuong.Text);
			double ThanhTien = donGia * soLuong;
			lblTongTien.Text = ThanhTien.ToString() + " $";
		}
	}
}
