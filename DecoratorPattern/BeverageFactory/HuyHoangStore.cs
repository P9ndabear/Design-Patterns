using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern.BeverageFactory
{
    internal class HuyHoangStore : BeverageStore
    {
        public override Beverage CreateBeverage(string type, Size size)
        {
            Beverage beverage;
            if (type.Equals("chocolatemilk"))
            {
                beverage = new Beverages.Chocolate();
            }
            else
            {
                beverage = new Beverages.Espresso();
            }
            beverage.Size = size;

            if (type.Equals("espresso"))
            {
            }
            else if (type.Equals("doppio"))
            {
                beverage = new Condiments.Espresso(beverage);
            }
            else if (type.Equals("lungo"))
            {
                beverage = new Water(beverage);
            }
            else if (type.Equals("macchiato"))
            {
                beverage = new MilkFoam(beverage);
            }
            else if (type.Equals("corretta"))
            {
                beverage = new Liqour(beverage);
            }
            else if (type.Equals("conpanna"))
            {
                beverage = new Whip(beverage);
            }
            else if (type.Equals("cappuccino"))
            {
                beverage = new SteamedMilk(beverage);
                beverage = new MilkFoam(beverage);
            }
            else if (type.Equals("americano"))
            {
                beverage = new Water(beverage);
                beverage = new Water(beverage);
            }
            else if (type.Equals("caffelatte"))
            {
                beverage = new SteamedMilk(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new MilkFoam(beverage);
            }
            else if (type.Equals("flatwhite"))
            {
                beverage = new SteamedMilk(beverage);
                beverage = new SteamedMilk(beverage);
            }
            else if (type.Equals("romana"))
            {
                beverage = new Lemon(beverage);
            }
            else if (type.Equals("morocchino"))
            {
                beverage = new Condiments.Chocolate(beverage);
                beverage = new MilkFoam(beverage);
            }
            else if (type.Equals("mocha"))
            {
                beverage = new Condiments.Chocolate(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new Whip(beverage);
            }
            else if (type.Equals("bicerin"))
            {
                beverage = new BlackChocolate(beverage);
                beverage = new WhiteChocolate(beverage);
                beverage = new Whip(beverage);
            }
            else if (type.Equals("breve"))
            {
                beverage = new MilkFoam(beverage);
                beverage = new HalfMilk(beverage);
            }
            else if (type.Equals("rafcoffee"))
            {
                beverage = new VanillaSugar(beverage);
                beverage = new Cream(beverage);
            }
            else if (type.Equals("meadraf"))
            {
                beverage = new Honey(beverage);
                beverage = new Cream(beverage);
            }
            else if (type.Equals("galao"))
            {
                beverage = new MilkFoam(beverage);
                beverage = new MilkFoam(beverage);
            }
            else if (type.Equals("caffeaffogato"))
            {
                beverage = new Condiments.Espresso(beverage);
                beverage = new IceCream(beverage);
            }
            else if (type.Equals("viennacoffee"))
            {
                beverage = new Condiments.Espresso(beverage);
                beverage = new Whip(beverage);
                beverage = new Whip(beverage);
            }
            else if (type.Equals("glace"))
            {
                beverage = new IceCream(beverage);
            }
            else if (type.Equals("chocolatemilk"))
            {
                beverage = new Milk(beverage);
                beverage = new Milk(beverage);
            }
            else if (type.Equals("demicreme"))
            {
                beverage = new Condiments.Espresso(beverage);
                beverage = new Cream(beverage);
                beverage = new Cream(beverage);
            }
            else if (type.Equals("lattemacchiato"))
            {
                beverage = new SteamedMilk(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new MilkFoam(beverage);
            }
            else if (type.Equals("freddo"))
            {
                beverage = new Liqour(beverage);
                beverage = new Ice(beverage);
            }
            else if (type.Equals("frappuccino"))
            {
                beverage = new Ice(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new Whip(beverage);
            }
            else if (type.Equals("caramelfrappuccino"))
            {
                beverage = new Ice(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new Cream(beverage);
                beverage = new Syrup(beverage);
            }
            else if (type.Equals("frappe"))
            {
                beverage = new SteamedMilk(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new IceCream(beverage);
            }
            else if (type.Equals("irishcoffee"))
            {
                beverage = new Condiments.Espresso(beverage);
                beverage = new Whiskey(beverage);
                beverage = new Whip(beverage);
            }
            else
            {
                throw new ArgumentException("Deze drank bestaat niet: " + type);
            }

            return beverage;
        }
    }
}