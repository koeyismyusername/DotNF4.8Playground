using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    public class MVVMWithMyEventHandler : ITestable
    {
        public void Test(TestContext context)
        {
            context.EnableStopWatch = true;

            var view = new CountView();

            view.OnBtnCountClickAndFail();
            view.OnBtnCountClickAndSuccess();
            view.OnBtnCountClickAndError();
        }
    }

    public class CountView
    {
        public int Count { get; private set; } = 0;
        public ICountViewModel ViewModel { get; private set; }
        public CountView()
        {
            ViewModel.CountUpdated.Error += (sender, exception) => Console.WriteLine(exception.Message);
            ViewModel.CountUpdated.Next += (sender, eventArgs) =>
            {
                if (eventArgs.IsSuccess)
                {
                    Console.WriteLine($"성공({eventArgs.Count})");
                }
                else
                {
                    Console.WriteLine($"실패({eventArgs.Count})");
                }
            };
        }

        internal void OnBtnCountClickAndError()
        {
            ViewModel.CountUpdated.OnError(new NullReferenceException("NULL 참조 발생!"));
        }

        internal void OnBtnCountClickAndFail()
        {
            ViewModel.CountUpdated.OnNext(new CountEventResult { IsSuccess = false, Count = Count });
        }

        internal void OnBtnCountClickAndSuccess()
        {
            ViewModel.CountUpdated.OnNext(new CountEventResult { IsSuccess = true, Count = Count});
        }
    }

    public interface ICountViewModel
    {
        IMyEvent<CountEventResult> CountUpdated { get; set; }
    }

    public interface IMyEvent<T>
    {
        EventHandler<Exception> Error { get; set; }
        EventHandler<T> Next { get; set; }

        void OnError(Exception exception); 
        void OnNext(T eventArgs);
    }

    public class CountEventResult
    {
        public bool IsSuccess { get; set; }
        public int Count { get; set; }
    }
}
