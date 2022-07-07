namespace BuilderPattern;

public interface IBuilder
{
    void AddIngredients();
    void AddQuantity();

    void AddCountry();

    void Reset();

    Couscous Build();


}