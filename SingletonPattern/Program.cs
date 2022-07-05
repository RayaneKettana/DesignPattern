using System;

namespace SingletonPattern
{
    static class Program
    {
        static void Main()
        {
            try
            {
                var redZlabia = CreationZlabia.GetInstance();
                redZlabia.Preparation();
                redZlabia.Cooking();
                redZlabia.Rest();
            }
            catch (Exception e )
            {
                Console.Write(e.Message);
            }
            
        }
    }
}