using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    public class RefTest : ITestable
    {
        public void Test(TestContext context)
        {
            var list = new List<Data> { 
                new Data(1),
                new Data(2),
                new Data(3),
            };

            var data = list.Find(x => x.Value == 2);
            data.Value *= 999;

            foreach (var item in list)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(data.Value);
            ChangeValue(data);

            Console.WriteLine(data.Value);
        }

        private void ChangeValue(Data data)
        {
            data.Value = -1;
        }
    }

    internal class Data
    {
        public Data(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }
}
