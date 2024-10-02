using COS20007_Research;

class Program
{
    static void Main()
    {
        // Baseline approach
        ShoppingCart cart1 = new ShoppingCart();
        cart1.AddItem(50);
        cart1.AddItem(30);
        cart1.AddItem(20);
        double total1 = cart1.CalculateTotal();
        Console.WriteLine($"Total (Baseline): {total1}");

        // Approach using the Strategy pattern
        ShoppingCartWithStrategy cart2 = new ShoppingCartWithStrategy();
        cart2.AddItem(50);
        cart2.AddItem(30);
        cart2.AddItem(20);
        cart2.SetDiscountStrategy(new NoDiscountStrategy()); // Change strategy here
        double total2 = cart2.CalculateTotal();
        Console.WriteLine($"Total (Strategy Pattern): {total2}");
    }
}
