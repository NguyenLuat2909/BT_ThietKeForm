﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindownsFormBT2
{
	internal class Class1
	{
		public static void NoiChuoi(string ho,string ten,ref string s)
		{
			s = ho + " " + ten;
		}
		public static long GiaiThua ( int n )
		{
			if (n<0)
			{
				throw new ArgumentException("n phải là số nguyên dương");
			}
			long kq = 1;
			for (int i = 1; i <= n; i++)
			{
				kq *= i
;			}
			return kq;
		}
	}
}
