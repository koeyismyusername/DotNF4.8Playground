﻿using DotNF_4_8_Playground.DesignPattern;
using System;

namespace DotNF_4_8_Playground.Tests
{
    public class Observer2 : IMyObserver
    {
        public void Update()
        {
            Console.WriteLine("2번 알림 받았습니다!");
        }
    }
}