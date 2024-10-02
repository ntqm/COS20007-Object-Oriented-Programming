namespace COS20007_Research
{
    // Baseline approach without using the Strategy pattern

    public class ShoppingCart
    {
        private List<double> items = new List<double>();

        public void AddItem(double price)
        {
            items.Add(price);
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (double price in items)
            {
                total += price;
            }
            return total;
        }
    }
}
