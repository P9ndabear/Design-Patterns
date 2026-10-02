using DecoratorPattern.Beverages;

namespace DecoratorPattern.BeverageFactory
{
    internal abstract class BeverageStore
    {
        public Beverage OrderBeverage(string type, Size size)
        {
            Beverage beverage = CreateBeverage(type, size);

            return beverage;
        }

        public abstract Beverage CreateBeverage(string type, Size size);
    }
}   