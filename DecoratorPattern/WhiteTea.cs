namespace DecoratorPattern;

internal class WhiteTea: Drink
{
    public WhiteTea()
    {
        _description = "White Tea";
    }

    public override string Description => _description;
    public override double Cost()
    {
        return 2.4;
    }
}