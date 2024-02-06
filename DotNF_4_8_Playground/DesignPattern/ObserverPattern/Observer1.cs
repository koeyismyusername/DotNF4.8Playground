using System;

namespace DotNF_4_8_Playground.DesignPattern.ObserverPattern
{
    internal class Observer1 : IMyObserver
    {
        public void Update()
        {
            Console.WriteLine("1번 알림 받았습니다!");
        }
    }
}