﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindowsForm
{
	internal class HangHoa
	{
		public string MaHang { get; set; }
		public string TenHang { get; set; }
		public string DVT { get; set; }
		public int SoLuong { get; set; }
		public int DonGia { get; set; }
		public HangHoa()
			{

			}
		public string HienThi()
		{
			return $"{MaHang}, {TenHang}, {DVT}, {SoLuong}, {DonGia}";
		}

	}
}
