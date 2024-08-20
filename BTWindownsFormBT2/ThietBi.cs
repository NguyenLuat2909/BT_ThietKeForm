using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindownsFormBT2
{
	internal class ThietBi
	{
		public string MaThietBi { get; set; }
		public string TenThietBi { get; set; }
		public string NuocSanXuat { get; set; }
		public int DonGia { get; set; }
		public int SoLuong { get; set; }
		public ThietBi()
		{

		}
		public ThietBi(string maThietBi, string tenThietBi, string nuocSanXuat, int donGia, int soLuong)
		{
			MaThietBi = maThietBi;
			TenThietBi = tenThietBi;
			NuocSanXuat = nuocSanXuat;
			DonGia = donGia;
			SoLuong = soLuong;
		}
		public string HienThi()
		{
			return $"Mã Thiết Bị: {MaThietBi}, Tên Thiết Bị: {TenThietBi}, Nước Sản Xuất {NuocSanXuat}, Đơn Giá {DonGia}, Số Lượng {SoLuong}";
		}
		public int ThanhTien()
		{
			return DonGia * SoLuong;
		}

	}
}
