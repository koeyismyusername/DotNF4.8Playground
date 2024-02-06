using DotNF_4_8_Playground.DesignPattern.ObserverPattern;
using System;

namespace DotNF_4_8_Playground.CSharpEvent
{
    public class EventObject
    {
        public delegate void MyEventHandler<TEventArgs>(object sender, TEventArgs e);
        public event MyEventHandler<IMyObserver> myEvented;

        public event EventHandler<EventArgs> ThresholdReached;

        protected virtual void OnThresholdReached(EventArgs e)
        {
            var handler = ThresholdReached;
            handler?.Invoke(this, e);
        }

        protected virtual void OnMyEvented(IMyObserver e) { 
            var handler = myEvented;
            handler?.Invoke(this, e);
        }
    }
}