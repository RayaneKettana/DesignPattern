using System;

namespace SingletonPattern
{
    internal partial class CreationZlabia
    {
        private static readonly Lazy<CreationZlabia> _singleton = new Lazy<CreationZlabia>(() => new CreationZlabia());

        public static CreationZlabia GetInstance() => _singleton.Value;

        private Status _zlabiaPreparationStatus;

        private CreationZlabia()    
        {
            Console.WriteLine("Starting");
            _zlabiaPreparationStatus = Status.InStarting;
        }

        public void Preparation()
        {
            if (!isStart) return;
            Console.WriteLine("Preparation for 20 minutes");
            _zlabiaPreparationStatus = Status.InProgress;
        }

        public void Cooking()
        {
            if (!isRest) return;
            Console.WriteLine("Baking for 25 minutes");
            _zlabiaPreparationStatus = Status.InCooking;
        }

        public void Rest()
        {
            if (isStart || isCook) return;
            Console.WriteLine("Rest for 20 minutes...");
            _zlabiaPreparationStatus = Status.AtRest;
        }

        private bool isStart => (_zlabiaPreparationStatus == Status.InStarting);
        private bool isCook => (_zlabiaPreparationStatus == Status.InCooking);

        private bool isRest => (_zlabiaPreparationStatus == Status.AtRest);
    }
    
    
    
    
}