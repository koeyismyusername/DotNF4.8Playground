using System;

namespace DotNF_4_8_Playground.DesignPattern
{
    public interface ISubject
    {
        void Attach(IMyObserver observer);
        void Detach(IMyObserver observer);
        void Notify();
    }
}