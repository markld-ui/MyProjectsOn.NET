using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrCalc
{
    abstract class AbstrFunc
    {
        public abstract int SumNumbers(params int[] Numbers);
        public abstract int MultiplyNumbers(params int[] Numbers);
        public abstract int MinusNumbers(params int[] Numbers);
        public abstract int DevNumbers(bool isMaxOrOther = true, params int[] Numbers);
    }
}
