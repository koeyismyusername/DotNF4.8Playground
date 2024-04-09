using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    public class OrderNumTest : ITestable
    {
        public void Test(TestContext context)
        {
            context.EnableStopWatch = false;

            //foreach (var i in Enumerable.Range(0, 20)) {
            //    Console.WriteLine(GetOrderNum("M", 31153));
            //}
            Console.WriteLine(GetOrderNum("M", 31153)); Console.WriteLine(GetOrderNum("M", 31153)); Console.WriteLine(GetOrderNum("M", 31153));
        }

        private string GetOrderNum(string deviceKeyword, int userSeq)
        {
            var randX = new Random().Next(int.MaxValue).ToString("x8").ToCharArray();
            var now = DateTime.Now.ToString("ddHHmmss").ToCharArray();
            var userSeqX = userSeq.ToString("x8").ToCharArray();

            var orderNums = randX.Select((x, index) =>
            {
                var separator = (index % 2 == 1) ? "-" : "";
                return $"{separator}{x}{now[7 - index]}{userSeqX[index]}";
            });

            var sb = new StringBuilder();
            foreach (var item in orderNums)
            {
                sb.Append(item);
            }

            return deviceKeyword + sb.ToString();
        }
    }
}
