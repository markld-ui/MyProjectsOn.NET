using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Calc
{
    interface IUICalc
    {
        private void ShowRuInfo() => Console.WriteLine();
        private void ShowEnInfo() => Console.WriteLine();
        public void MainLoop();

    }
}
