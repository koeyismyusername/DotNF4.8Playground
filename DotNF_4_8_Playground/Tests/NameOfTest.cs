using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    internal class NameOfTest : ITestable
    {
        public void Test(TestContext context)
        {
            var name = nameof(Temp.CNo);
            Console.WriteLine(name);
        }
    }

    internal class Temp
    {
        public int CNo { get; }
    }
}
