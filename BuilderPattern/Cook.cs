namespace BuilderPattern;

public class Cook
{
    private IBuilder _builder;
    
    public Cook(IBuilder builder)
    {
        AcceptBuilder(builder);
    }

    public void ChangeBuilder(IBuilder builder)
    {
        AcceptBuilder(builder);
    }

    public Couscous Build()
    {
        _builder.AddIngredients();
        _builder.AddQuantity();
        _builder.AddCountry();
        return _builder.Build();
    }
    
    private void AcceptBuilder(IBuilder builder)
    {
        _builder = builder;
        _builder.Reset();
    }
    
    
}