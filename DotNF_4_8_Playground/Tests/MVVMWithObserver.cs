using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    public class MVVMWithObserver : ITestable
    {
        public void Test(TestContext context)
        {
            var view = new RandomNumberView();

            view.OnRandomNumberBtnClickAndFail();
            view.OnRandomNumberBtnClickAndError();
            view.OnRandomNumberBtnClickAndSuccess();
        }
    }

    public class RandomNumberView
    {
        private IRandomNumberViewModel ViewModel { get; set; } = new RamdomNumberViewModel();
        public RandomNumberView()
        {
            ViewModel.RandomNumberUpdated.Error += (sender, exception) => Console.WriteLine(exception.Message);
            ViewModel.RandomNumberUpdated.Next += (sender, result) =>
            {
                if (result.IsSuccess)
                {
                    Console.WriteLine(result.RandomNumber);
                }
                else
                {
                    Console.WriteLine("잘못된 요청입니다.");
                }
            };
        }

        internal void OnRandomNumberBtnClickAndError()
        {
            ViewModel.UpdateRandomNumberAndError();
        }

        internal void OnRandomNumberBtnClickAndFail()
        {
            ViewModel.UpdateRandomNumberAndFail();
        }

        internal void OnRandomNumberBtnClickAndSuccess()
        {
            ViewModel.UpdateRandomNumberAndSuccess();
        }
    }

    public class RamdomNumberViewModel : IRandomNumberViewModel
    {

        public MyEvent<RandomNumberEventArgs> RandomNumberUpdated { get; set; } = new MyEvent<RandomNumberEventArgs>();

        public void UpdateRandomNumberAndError()
        {
            // TODO: 
        }

        public void UpdateRandomNumberAndFail()
        {
            // TODO: 
        }

        public void UpdateRandomNumberAndSuccess()
        {
            // TODO: 
        }
    }

    public interface IRandomNumberViewModel
    {
        MyEvent<RandomNumberEventArgs> RandomNumberUpdated { get; set; }

        void UpdateRandomNumberAndError();
        void UpdateRandomNumberAndFail();
        void UpdateRandomNumberAndSuccess();
    }

    public class RandomNumberEventArgs : EventArgs
    {
        public bool IsSuccess { get; set; }
        public bool RandomNumber { get; set; }
    }

    public class MyEvent<TEventArgs>
    {
        public EventHandler<Exception> Error { get; set; }
        public EventHandler<TEventArgs> Next { get; set; }
    }
}
