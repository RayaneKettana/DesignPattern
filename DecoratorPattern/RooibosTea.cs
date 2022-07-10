namespace DecoratorPattern;

internal class RooibosTea: Drink
{
    public override string Description => _description;

    public RooibosTea()
    {
        _description = "Rooibos Tea";
    }
    public override double Cost()
    {
        return 1.8;
    }
}