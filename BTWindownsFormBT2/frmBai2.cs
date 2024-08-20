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
	public partial class frmBai2 : Form
	{
		public frmBai2()
		{
			InitializeComponent();
		}

		private void btnKetQua_Click(object sender, EventArgs e)
		{
			int kq = 0;
			int a = int.Parse(txtSoThuNhat.Text);
			int b = int.Parse(txtSoThuHai.Text);
			if (rdCong.Checked)
				PhepTinh.PhepCong(a, b, ref kq);
			if (rdTru.Checked)
				PhepTinh.PhepTru(a, b, ref kq);
			if (rdNhan.Checked)
				PhepTinh.PhepNhan(a, b, ref kq);
			if (rdChia.Checked)
				PhepTinh.PhepChia(a, b, ref kq);
			lblKetQua.Text = kq.ToString();
		}
	}
}
