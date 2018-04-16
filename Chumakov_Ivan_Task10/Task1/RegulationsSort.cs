using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class RegulationsSort : IComparer
	{
		int IComparer.Compare(object a, object b)
		{
			if (a.ToString().Length < b.ToString().Length)
			{
				return -1;
			}
			else if(a.ToString().Length > b.ToString().Length)
			{
				return 1;
			}
			else
			{
				if(a.ToString() == b.ToString())
				{
					return 0;
				}
				else
				{
					string[] temp = new string[2];
					temp[0] = a.ToString();
					temp[1] = b.ToString();
					Array.Sort(temp);
					if (temp[0] == a.ToString())
					{
						return -1;
					}
					else
					{
						return 1;
					}
				}
				
			}
		}
	}
}
