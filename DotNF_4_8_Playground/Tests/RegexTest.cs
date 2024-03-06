using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    internal class RegexTest : ITestable
    {
        public void Test(TestContext context)
        {
            var durtyStr = "    !!@@##$$%%^^&&**(())__--++==||~~``::;;''??>><<..,,//[[]]{{}}hello 세상 0123";
            var cleanStr = Regex.Replace(durtyStr, @"[^\w]|_", "");
            Console.WriteLine(durtyStr);
            Console.WriteLine(cleanStr);
        }
    }
}
