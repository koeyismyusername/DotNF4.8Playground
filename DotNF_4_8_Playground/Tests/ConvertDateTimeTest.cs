using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    public class ConvertDateTimeTest : ITestable
    {
        public void Test(TestContext context)
        {
            context.EnableStopWatch = false;

            var timeStr = "20240321181845";
            //var datetime = Convert.ToDateTime(timeStr);
            //Console.WriteLine(datetime);

            if (DateTime.TryParseExact(timeStr, "yyyyMMddHHmmss", CultureInfo.InstalledUICulture, DateTimeStyles.None, out DateTime datetime))
            {
                Console.WriteLine(datetime);
            }
            else
            {
                Console.WriteLine("변환 실패");
            }
        }
    }
}
