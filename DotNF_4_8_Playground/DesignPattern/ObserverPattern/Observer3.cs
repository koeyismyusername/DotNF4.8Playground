using System;

namespace DotNF_4_8_Playground.DesignPattern.ObserverPattern
{
    public class Observer3 : IMyObserver
    {
        public void Update()
        {
            Console.WriteLine("3번 알림 받았습니다!");
        }
    }
}