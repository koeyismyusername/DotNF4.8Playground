using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace DotNF_4_8_Playground.Tests
{
    public class DelegateUseTest : ITestable
    {
        private delegate T MyDelegate<T>(T a, T b);

        private MyDelegate<int> _myDelegate;

        private static int SumInt(int a, int b) => a + b;

        public void Test(TestContext context)
        {
            _myDelegate += SumInt;
            _myDelegate += SumInt;
            _myDelegate += SumInt;

            var events = _myDelegate?.GetInvocationList();
            if (events is null) return;

            foreach (var e in events)
            {
                Console.WriteLine(_myDelegate?.Invoke(10, 20));
            }
        }
    }
}