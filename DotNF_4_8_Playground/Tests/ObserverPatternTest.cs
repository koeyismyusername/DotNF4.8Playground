using DotNF_4_8_Playground.DesignPattern;

namespace DotNF_4_8_Playground.Tests
{
    internal class ObserverPatternTest : ITestable
    {
        public void Test(TestContext context)
        {
            context.EnableStopWatch = false;

            var subject = Subject.Instance;

            var observer1 = new Observer1();
            var observer2 = new Observer2();
            var observer3 = new Observer3();

            subject.Attach(observer1);
            subject.Attach(observer2);
            subject.Attach(observer3);

            subject.Notify();

            subject.Detach(observer2);
            subject.Detach(observer1);

            subject.Notify();
        }
    }
}
