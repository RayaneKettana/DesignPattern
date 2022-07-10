namespace DecoratorPattern;

internal class BlackTea: Drink
{
    public BlackTea()
    {
        _description = "Black Tea";
    }

    public override string Description => _description;
    public override double Cost()
    {
        return 1.25;
    }
}