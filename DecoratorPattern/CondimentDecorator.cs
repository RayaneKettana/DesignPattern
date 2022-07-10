namespace DecoratorPattern;

abstract class CondimentDecorator: Drink
{
    public abstract override string Description { get; }
}