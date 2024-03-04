using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    public class EnumTest : ITestable
    {
        public void Test(TestContext context)
        {
            context.EnableStopWatch = false;

            const int value = 0;
            if (Enum.IsDefined(typeof(MyEnumType), value))
            {
                Console.WriteLine($"True, {(MyEnumType)value}");
            }
            else
            {
                 try
                {
                    Console.WriteLine($"False, {(MyEnumType)value}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }

    public enum MyEnumType
    {
        None,
        First,
        Second,
        Third,
    }
}
