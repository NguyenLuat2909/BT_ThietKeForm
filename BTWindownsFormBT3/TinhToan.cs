using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWindownsFormBT3
{
	internal class TinhToan
	{
		private long CalculateSum(int n)
		{
			long sum = 0;
			for (int i = 1; i <= n; i++) ;
			{
				sum += 1;
			}
			return sum;
		}
		private long CalculateFactorial(int n)
		{
			long factorial = 1;
			for (int i=1; i <=n; i++)
			{
				factorial *= i;
			}
			return factorial;

		}
	}
}
