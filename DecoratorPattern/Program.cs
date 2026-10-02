using DecoratorPattern.BeverageFactory;
using DecoratorPattern.Beverages;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeverageStore store = new HuyHoangStore();

            PrintBeverage(store.OrderBeverage("espresso", Size.TALL));
            PrintBeverage(store.OrderBeverage("doppio", Size.GRANDE));
            PrintBeverage(store.OrderBeverage("lungo", Size.VENDI));
            PrintBeverage(store.OrderBeverage("macchiato", Size.VENDI));
            PrintBeverage(store.OrderBeverage("corretta", Size.GRANDE));
            PrintBeverage(store.OrderBeverage("conpanna", Size.GRANDE));
            PrintBeverage(store.OrderBeverage("cappuccino", Size.GRANDE));
            PrintBeverage(store.OrderBeverage("americano", Size.VENDI));
            PrintBeverage(store.OrderBeverage("caffelatte", Size.VENDI));
            PrintBeverage(store.OrderBeverage("flatwhite", Size.VENDI));
            PrintBeverage(store.OrderBeverage("romana", Size.VENDI));
            PrintBeverage(store.OrderBeverage("morocchino", Size.VENDI));
            PrintBeverage(store.OrderBeverage("mocha", Size.VENDI));
            PrintBeverage(store.OrderBeverage("bicerin", Size.VENDI));
            PrintBeverage(store.OrderBeverage("breve", Size.VENDI));
            PrintBeverage(store.OrderBeverage("rafcoffee", Size.VENDI));
            PrintBeverage(store.OrderBeverage("meadraf", Size.VENDI));
            PrintBeverage(store.OrderBeverage("galao", Size.VENDI));
            PrintBeverage(store.OrderBeverage("caffeaffogato", Size.VENDI));
            PrintBeverage(store.OrderBeverage("viennacoffee", Size.VENDI));
            PrintBeverage(store.OrderBeverage("glace", Size.VENDI));
            PrintBeverage(store.OrderBeverage("chocolatemilk", Size.VENDI));
            PrintBeverage(store.OrderBeverage("demicreme", Size.VENDI));
            PrintBeverage(store.OrderBeverage("lattemacchiato", Size.VENDI));
            PrintBeverage(store.OrderBeverage("freddo", Size.VENDI));
            PrintBeverage(store.OrderBeverage("frappuccino", Size.VENDI));
            PrintBeverage(store.OrderBeverage("caramelfrappuccino", Size.VENDI));
            PrintBeverage(store.OrderBeverage("frappe", Size.VENDI));
            PrintBeverage(store.OrderBeverage("irishcoffee", Size.VENDI));
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }
}