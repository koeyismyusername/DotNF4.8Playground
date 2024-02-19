using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    public class EventProgrammingTest : ITestable
    {
        protected EventHandler<MyEventArgs> buttonClick;

        public void Test(TestContext context)
        {
            context.EnableStopWatch = false;

            var nameLover = new NameLover();
            var birthdayLover = new BirthdayLover();
            var balanceLover = new BalanceLover();

            buttonClick += nameLover.ShowName;
            buttonClick += birthdayLover.ShowBirthday;
            buttonClick += balanceLover.TakeBalanceIfDead;

            var eventArgs = new MyEventArgs
            {
                Name = "홍길동",
                Birthday = DateTime.Now.AddYears(-19),
                Balance = 150_000_000,
                IsDead = false,
            };

            OnButtonClick(eventArgs);

            buttonClick -= birthdayLover.ShowBirthday;
            buttonClick -= nameLover.ShowName;

            eventArgs.IsDead = true;

            OnButtonClick(eventArgs);
        }

        private void OnButtonClick(MyEventArgs eventArgs)
        {
            buttonClick?.Invoke(this, eventArgs);
        }
    }

    public class BalanceLover
    {
        public void TakeBalanceIfDead(object sender, MyEventArgs e)
        {
            if (e.IsDead)
            {
                Console.WriteLine($"{e.Name}은 죽었습니다. 이제 이 돈 {e.Balance:#,##0}원은 제 것입니다.");
            }
            else
            {
                Console.WriteLine($"젠장, {e.Name}은 아직 살아있습니다. 저 돈 {e.Balance:#,##0}원이 너무 탐납니다!");
            }
        }
    }

    public class BirthdayLover
    {
        public void ShowBirthday(object sender, MyEventArgs e)
        {
            Console.WriteLine(e.Birthday);
        }
    }

    public class NameLover
    {
        public void ShowName(object sender, MyEventArgs e)
        {
            Console.WriteLine(e.Name);
        }
    }

    public class MyEventArgs
    {
        public DateTime Birthday { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public bool IsDead { get; set; }
    }
}
