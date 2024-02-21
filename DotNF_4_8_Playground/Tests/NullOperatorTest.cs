using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNF_4_8_Playground.Tests
{
    public class NullOperatorTest : ITestable
    {
        public void Test(TestContext context)
        {
            context.EnableStopWatch = false;

            var user = User.Null;
            Console.WriteLine(user);
            Console.WriteLine(user?.Age);
            Console.WriteLine(user?.Age ?? 10);

            var user1 = User.Instance;
            var user2 = User.Instance;
            var user3 = User.Instance;

            Console.WriteLine(user1?.Age); 
            Console.WriteLine(user2?.Age); 
            Console.WriteLine(user3?.Age);
        }


    }

    public class User
    {
        private static User _instance = new User(29);
        public User(int age)
        {
            Age = age;
        }

        public static User Instance { get => _instance ?? (_instance = new User(new Random().Next())); }
        public static User Null { get => default; }
        public int Age { get; set; }
    }
}
