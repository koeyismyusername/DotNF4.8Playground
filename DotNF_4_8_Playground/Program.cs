using DotNF_4_8_Playground.Tests;

namespace DotNF_4_8_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tester = Tester.Instance;

            tester.TestElapsedTime<RefTest>();
        }
    }
}
