using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main()
        {
            var builder = new MyCouscousBuilder();
            var cook = new Cook(builder);
            var myCouscous = cook.Build();

            cook.ChangeBuilder(new MyMomCouscousBuilder());
            var momCouscous = cook.Build();

            Console.WriteLine($"My Hamburger: {myCouscous}");
            Console.WriteLine($"My Mom's : {momCouscous}");
        }
    }
}