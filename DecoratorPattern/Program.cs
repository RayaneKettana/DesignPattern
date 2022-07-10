using System;

namespace DecoratorPattern
{
    static class Program
    {
        static void Main()
        {
            Drink drink = new BlackTea();
            Console.WriteLine(drink.Description +":" + drink.Cost() + " €");

            Drink drink2 = new RooibosTea();
            drink2 = new LemonCondiment(drink2);
            drink2 = new LemonCondiment(drink2);
            Console.WriteLine(drink2.Description + ":" + drink2.Cost() + " €");
            
            Drink drink3 = new WhiteTea();
            drink3 = new LemonCondiment(drink3);
            drink3 = new GingerCondiment(drink3);
            Console.WriteLine(drink3.Description + ":" + drink3.Cost() + " €");

        }

        
    }
}