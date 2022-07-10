namespace DecoratorPattern
{
    class GingerCondiment : CondimentDecorator
    {
        readonly Drink _drink;

        public GingerCondiment(Drink drink)
        {
            this._drink = drink;
        }

        public override string Description
        {
            get
            {
                if (_drink.Description.StartsWith("Ginger"))
                {
                    return "Double " + _drink.Description;
                }
                else
                    return "Ginger " + _drink.Description;
            }
        }

        public override double Cost()
        {
            return 0.6 + _drink.Cost();
        }
    }
}