namespace BuilderPattern;

public class Couscous
{
    public string[] Ingredients { get; set; }
    
    public String Quantity { get; set; }
    
    public string Country { get; set; }

    public override string ToString()
    {
        var couscous = "";

        foreach (var ingredient in Ingredients)
        {
            couscous += $"{ingredient}";
        }
        
        return $"Ingredients: {couscous}, Quantity: {Quantity}";

    }
}