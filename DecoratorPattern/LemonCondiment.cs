namespace DecoratorPattern
{
    class LemonCondiment : CondimentDecorator
    {
        readonly Drink _drink;

        public LemonCondiment(Drink drink)
        {
            this._drink = drink;
        }

        public override string Description
        {
            get
            {
                if (_drink.Description.StartsWith("Lemon"))
                {
                    return "Double " + _drink.Description;
                }
                else
                    return "Lemon " + _drink.Description;
            }
        }

        public override double Cost()
        {
            return 0.2 + _drink.Cost();
        }
    }
}