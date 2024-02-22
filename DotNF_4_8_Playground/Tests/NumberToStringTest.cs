using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    public class NumberToStringTest : ITestable
    {
        public void Test(TestContext context)
        {
            context.EnableStopWatch = false;

            int stockAmount = 0;
            Console.WriteLine(stockAmount.ToString("#,##0"));
            Console.WriteLine(stockAmount.ToString("#,###"));
        }
    }
}
