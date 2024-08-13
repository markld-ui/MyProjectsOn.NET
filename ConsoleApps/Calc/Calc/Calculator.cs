using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstrCalc;

namespace Calc
{
    class Calculator : AbstrFunc
    {
        public override int DevNumbers(bool isMaxOrOther = true, params int[] Numbers)
        {
            int res;
            if (isMaxOrOther)
            {
                Array.Sort(Numbers);
                int reslt = Numbers[^1];
                foreach (int i in Numbers) 
                {
                    if (i == Numbers[^1]) { break; }
                    reslt /= i;
                }
                res = reslt;
            }
            else
            {
                Array.Sort(Numbers);
                int reslt = Numbers[0];
                for (int i = Numbers.Length - 1; i > 0; i--)
                {
                    if (i == Numbers[0]) { break; }
                    reslt /= i;
                }
                res = reslt;
            }
            return res;
        }

        public override int MinusNumbers(params int[] Numbers)
        {
            Array.Sort(Numbers);
            int res = Numbers[^1];
            foreach (int i in Numbers) 
            {
                if (i == Numbers[^1]) { break; }
                res -= i;
            }
            return res;
        }

        public override int MultiplyNumbers(params int[] Numbers)
        {
            int res = 1;
            foreach (int item in Numbers)
            {
                res *= item;
            }
            return res;
        }

        public override int SumNumbers(params int[] Numbers)
        {
            int res = 0;
            foreach (int item in Numbers)
            {
                res += item;
            }
            return res;
        }
    }
}
