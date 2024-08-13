using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            UICalc calc = new UICalc();
            calc.MainLoop();
        }
    }
}