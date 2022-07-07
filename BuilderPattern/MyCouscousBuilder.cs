namespace BuilderPattern;

public class MyCouscousBuilder: IBuilder
{
    private Couscous _couscous;

    public void AddIngredients()
    {
        _couscous.Ingredients = new string[] { "lamb meat", "Carrot", "Onion", "Milk" };
    }

    public void AddQuantity()
    {
        _couscous.Quantity = "So much, please";
    }

    public void AddCountry()
    {
        _couscous.Country = "Tunisia";
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