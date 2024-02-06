using System.Collections.Generic;

namespace DotNF_4_8_Playground.DesignPattern.ObserverPattern
{
    public class Subject : ISubject
    {
        private List<IMyObserver> _observers = new List<IMyObserver>();
        private static Subject _instance;

        public static Subject Instance { get => _instance is null ? _instance = new Subject() : _instance; }
        
        private Subject() { }

        public void Attach(IMyObserver observer)
        {
            _observers?.Add(observer);
        }

        public void Detach(IMyObserver observer)
        {
            _observers?.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}