using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class LeetCode
    {
        //task166
        public string FractionToDecimal(int numerator, int denominator)
        {
            decimal result = (decimal)numerator / (decimal)denominator;
            string format = result.ToString();
            int length = format.Length;

            int num = (int)result;
            decimal quer = result - num;
            string queryString= quer.ToString();
            string res = num.ToString();
            int resLength = res.Length;

            //if (leng > 4)
            //{

            //    for (int i =0 ; i <= 5; i++)
            //    {
            //        if ((i - res.Length) == 0)
            //        {
            //            res = res + ".(";
            //        }

            //        if ((resLeng - i) == 0)
            //        {
            //            res = res + ")";
            //        }

            //        if ((i - resLeng) > 0)
            //        {
            //            res = res + queryString[i].ToString();
            //        }



            //    }
            //}

            if (length > 4)
            {
                res += ".(";

                for (int i = 0; i < 4; i++)
                {
                    if ((resLength + i) < length)
                    {
                        if (format[resLength + i] == ',')
                        {
                            continue;
                        }
                        res += format[resLength + i];
                    }
                }

                res += ")";
            }
                return res;
        }
    }
}
