using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    internal class ParseIntTest : ITestable
    {
        public void Test(TestContext context)
        {
            context.EnableStopWatch = false;

            var numStr = "      00051035     ";
            string nullStr = null;
            var trimedStr = numStr.Trim();
            Console.WriteLine($"{nameof(numStr)}={numStr}");
            Console.WriteLine($"{nameof(trimedStr)}={trimedStr}");

            int.TryParse(nullStr, out int numFromNull);
            int.TryParse(numStr, out int numFromStr);
            int.TryParse(numStr, out int numFromTrimedStr);

            Console.WriteLine($"{nameof(numFromNull)}={numFromNull}");
            Console.WriteLine($"{nameof(numFromStr)}={numFromStr}");
            Console.WriteLine($"{nameof(numFromTrimedStr)}={numFromTrimedStr}");

        }
    }
}
