using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindownsFormBT2
{
	internal class PhepTinh
	{
		public static void PhepCong(int a , int b , ref int s)
		{
			s = a + b;
		}
		public static void PhepTru(int a , int b , ref int s)
		{
			s = a - b;
		}
		public static void PhepNhan ( int a , int b , ref int s)
		{
			s = a * b;
		}
		public static void PhepChia (int a, int b, ref int s)
		{
			s = a / b;
		}
	}
}
