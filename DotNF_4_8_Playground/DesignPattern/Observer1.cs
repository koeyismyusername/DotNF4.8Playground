using DotNF_4_8_Playground.DesignPattern;
using System;

namespace DotNF_4_8_Playground.Tests
{
    internal class Observer1 : IMyObserver
    {
        public void Update()
        {
            Console.WriteLine("1번 알림 받았습니다!");
        }
    }
}