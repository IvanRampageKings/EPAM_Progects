using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    //class RegulationsSort : IComparer<string>
    //{
    //    void A()
    //    {
    //        Compare("asd", "qwe", CompareLengthAscending);
    //        Compare("asd", "qwe", (a, b) => { return -a.Length.CompareTo(b); });
    //    }

    //    public int Compare(string a, string b, Func<string,string,int> lengthComarison)
    //    {
    //        var lengthComparisonResult = lengthComarison(a, b);
    //        if (lengthComparisonResult == 0)
    //        {
    //            if (a == b)
    //            {
    //                return 0;
    //            }
    //            else
    //            {
    //                string[] temp = new string[2];
    //                temp[0] = a;
    //                temp[1] = b;

    //                Array.Sort(temp);
    //                if (temp[0] == a)
    //                {
    //                    return -1;
    //                }
    //                else
    //                {
    //                    return 1;
    //                }
    //            }

    //        }

    //        return lengthComparisonResult;
    //    }

    //    int CompareLengthAscending(string a, string b)
    //    {
    //        return a.Length.CompareTo(b.Length);
    //        //if (a.Length < b.Length)
    //        //{
    //        //    return -1;
    //        //}
    //        //else if (a.Length > b.Length)
    //        //{
    //        //    return 1;
    //        //}
    //    }


    //    //      int IComparer.Compare(object a, object b)
    //    //{
    //    //	if (a.ToString().Length < b.ToString().Length)
    //    //	{
    //    //		return -1;
    //    //	}
    //    //	else if(a.ToString().Length > b.ToString().Length)
    //    //	{
    //    //		return 1;
    //    //	}
    //    //	else
    //    //	{
    //    //		if(a.ToString() == b.ToString())
    //    //		{
    //    //			return 0;
    //    //		}
    //    //		else
    //    //		{
    //    //			string[] temp = new string[2];
    //    //			temp[0] = a.ToString();
    //    //			temp[1] = b.ToString();
    //    //			Array.Sort(temp);
    //    //			if (temp[0] == a.ToString())
    //    //			{
    //    //				return -1;
    //    //			}
    //    //			else
    //    //			{
    //    //				return 1;
    //    //			}
    //    //		}

    //    //	}
    //    //}
    //}
}
