namespace COS20007_Research
{
    // Approach using the Strategy pattern

    // Strategy interface
    public interface IDiscountStrategy
    {
        double ApplyDiscount(List<double> items);
    }

    // Concrete strategy classes
    public class NoDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(List<double> items)
        {
            return items.Sum();
        }
    }

    public class TenPercentDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(List<double> items)
        {
            double total = items.Sum();
            return total - (total * 0.10);
        }
    }

    // Context class that uses the strategy
    public class ShoppingCartWithStrategy
    {
        private List<double> items = new List<double>();
        private IDiscountStrategy discountStrategy;

        public void SetDiscountStrategy(IDiscountStrategy strategy)
        {
            discountStrategy = strategy;
        }

        public void AddItem(double price)
        {
            items.Add(price);
        }

        public double CalculateTotal()
        {
            return discountStrategy.ApplyDiscount(items);
        }
    }
}
