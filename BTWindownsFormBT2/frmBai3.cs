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
	public partial class frmBai3 : Form
	{
		public frmBai3()
		{
			InitializeComponent();
		}

		private void btnChon_Click(object sender, EventArgs e)
		{
				// Lấy giá trị từ các TextBox
				string ho = txtHo.Text;
				string ten = txtTen.Text;

				// Khởi tạo biến để chứa kết quả nối chuỗi
				string kq = "";

				// Gọi hàm NoiChuoi để nối họ và tên
				Class1.NoiChuoi(ho, ten, ref kq);

				// Thêm kết quả vào ListBox
				lbHoTen.Items.Add(kq);
		}
	}
}
