namespace CompositePattern
{
    static class Program
    {
        public static void Main()
        {

            var breakfast = new Menu("Breakfast", "Chinese Pancake");
            var lunch = new Menu("Lunch", "Couscous Food");
            var dinner = new Menu("Dinner", "Italian food");

            var dessert = new Menu("Dessert", "Ice Cream");

            var menu = new Menu("All", "Burger King");

            breakfast.Add(new MenuItem("Waffles", "Sugar waffles", 60, false));
            breakfast.Add(new MenuItem("Corn Flakes", "Kellogs", 30, true));

            lunch.Add(new MenuItem("Burger", "Cheese and Rings Burger", 100, true));
            lunch.Add(new MenuItem("Sandwich", "Fish Sandwich", 45, false));

            dinner.Add(new MenuItem("Pizza", "4 cheese", 22, true));
            dinner.Add(new MenuItem("Pasta", "Fish Pasta", 12, false));

            dessert.Add(new MenuItem("Ice Cream", "Vanilla and Coco", 49, true));
            dessert.Add(new MenuItem("Cake", "Tiramisu", 30, false));

            dinner.Add(dessert);
            menu.Add(breakfast);
            menu.Add(lunch);
            menu.Add(dinner);

            menu.Print();

        }
    }
}