using BuilderPattern;

public class MyMomCouscousBuilder: IBuilder
{
    private Couscous _couscous;
    public void AddIngredients()
    {
        _couscous.Ingredients = new string[] { "Meat", "Onion", "Felfel har" };
    }

    public void AddQuantity()
    {
        _couscous.Quantity = "A little bit, please"; 
    }

    public void AddCountry()
    {
        _couscous.Country = "Algeria";
    }

    public void Reset()
    {
        _couscous = new Couscous();
    }

    public Couscous Build()
    {
        return _couscous;
    }
}
