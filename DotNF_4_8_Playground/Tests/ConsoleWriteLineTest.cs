using System;

namespace DotNF_4_8_Playground.Tests
{
    /// <summary>
    /// 콘솔에 Hello, World 출력하기 테스트
    /// </summary>
    public class ConsoleWriteLineTest : ITestable
    {
        public void Test(TestContext context)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}