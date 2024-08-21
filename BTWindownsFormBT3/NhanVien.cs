using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindownsFormBT3
{
	internal class NhanVien
	{
		public string MaNV { get; set; }
		public string HoTen { get; set; }
		public DateTime NgaySinh { get; set; }
		public float HeSoLuong { get; set; }
		public float HeSoPhuCap { get; set; }
		public NhanVien(string maNV,string hoTen, DateTime ngaySinh, float hesoLuong,
			float hesoPhuCap)
		{
			MaNV = maNV;
			HoTen = hoTen;
			NgaySinh = ngaySinh;
			HeSoLuong = hesoLuong;
			HeSoPhuCap = hesoPhuCap;
		}
		public float TongLuong()
		{
			const float luongcd = 1150000f;//Lương cố định
			return (HeSoLuong + HeSoPhuCap) * luongcd;
		}
		public string HienThi()
		{
			return $"{MaNV},{HoTen},{NgaySinh},{HeSoLuong},{HeSoPhuCap}";
		}
	}
}
