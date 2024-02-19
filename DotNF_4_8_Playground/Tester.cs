using DotNF_4_8_Playground.Tests;
using System;
using System.Diagnostics;

namespace DotNF_4_8_Playground
{
    public class Tester
    {
        private static Tester _instance;
        public static Tester Instance { get => _instance is null ? _instance = new Tester() : _instance; }

        private Tester() { }

        internal void TestElapsedTime<T>() where T : ITestable, new()
        {
            var testable = new T();
            var stopwatch = new Stopwatch();
            var context = new TestContext();

            stopwatch.Start();
            testable.Test(context);
            stopwatch.Stop();

            Console.WriteLine("테스트를 성공적으로 수행했습니다.");

            if (context.EnableStopWatch)
            {
                Console.WriteLine($"실행 시간: {stopwatch.ElapsedMilliseconds}ms");
            }
        }
    }
}