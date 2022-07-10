namespace DecoratorPattern;

abstract class Drink
{
    protected string _description = "No description";
    public abstract string Description { get; }
    public abstract double Cost();
}