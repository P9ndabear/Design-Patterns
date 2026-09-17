using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Beverages.Espresso();
            espresso.Size = Size.TALL;
            PrintBeverage(espresso);

            Beverage doppio = new Beverages.Espresso();
            doppio.Size = Size.GRANDE;
            doppio = new Condiments.Espresso(doppio);
            PrintBeverage(doppio);

            Beverage lungo = new Beverages.Espresso();
            lungo.Size = Size.VENDI;
            lungo = new Water(lungo);
            PrintBeverage(lungo);

            Beverage macchiato = new Beverages.Espresso();
            macchiato.Size = Size.VENDI;
            macchiato = new MilkFoam(macchiato);
            PrintBeverage(macchiato);

            Beverage corretta = new Beverages.Espresso();
            corretta.Size = Size.GRANDE;
            corretta = new Liqour(corretta);
            PrintBeverage(corretta);

            Beverage conpanna = new Beverages.Espresso();
            conpanna.Size = Size.GRANDE;
            conpanna = new Whip(conpanna);
            PrintBeverage(conpanna);

            Beverage cappucinno = new Beverages.Espresso();
            cappucinno.Size = Size.GRANDE;
            cappucinno = new SteamedMilk(cappucinno);
            cappucinno = new MilkFoam(cappucinno);
            PrintBeverage(cappucinno);

            Beverage americano = new Beverages.Espresso();
            americano.Size = Size.VENDI;
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);

            Beverage caffélatte = new Beverages.Espresso();
            caffélatte.Size = Size.VENDI;
            caffélatte = new SteamedMilk(caffélatte);
            caffélatte = new SteamedMilk(caffélatte);
            caffélatte = new MilkFoam(caffélatte);
            PrintBeverage(caffélatte);

            Beverage flatwhite = new Beverages.Espresso();
            flatwhite.Size = Size.VENDI;
            flatwhite = new SteamedMilk(caffélatte);
            flatwhite = new SteamedMilk(caffélatte);
            PrintBeverage(caffélatte);

            Beverage romana = new Beverages.Espresso();
            romana.Size = Size.VENDI;
            romana = new Lemon(romana);
            PrintBeverage(romana);

            Beverage morocchino = new Beverages.Espresso();
            morocchino.Size = Size.VENDI;
            morocchino = new Condiments.Chocolate(morocchino);
            morocchino = new MilkFoam(morocchino);
            PrintBeverage(morocchino);

            Beverage mocha = new Beverages.Espresso();
            mocha.Size = Size.VENDI;
            mocha = new Condiments.Chocolate(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            Beverage bicerin = new Beverages.Espresso();
            bicerin.Size = Size.VENDI;
            bicerin = new BlackChocolate(bicerin);
            bicerin = new WhiteChocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage(bicerin);

            Beverage breve = new Beverages.Espresso();
            breve.Size = Size.VENDI;
            breve = new MilkFoam(breve);
            breve = new HalfMilk(breve);
            breve = new Whip(breve);
            PrintBeverage(breve);

            Beverage rafcoffee = new Beverages.Espresso();
            rafcoffee.Size = Size.VENDI;
            rafcoffee = new VanillaSugar(rafcoffee);
            rafcoffee = new Cream(rafcoffee);
            PrintBeverage(rafcoffee);

            Beverage meadraf = new Beverages.Espresso();
            meadraf.Size = Size.VENDI;
            meadraf = new Honey(meadraf);
            meadraf = new Cream(meadraf);
            PrintBeverage(meadraf);

            Beverage galao = new Beverages.Espresso();
            galao.Size = Size.VENDI;
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);
            PrintBeverage(galao);

            Beverage cafféaffogato = new Beverages.Espresso();
            cafféaffogato.Size = Size.VENDI;
            cafféaffogato = new Condiments.Espresso(cafféaffogato);
            cafféaffogato = new IceCream(cafféaffogato);
            PrintBeverage(cafféaffogato);

            Beverage viennacoffee = new Beverages.Espresso();
            viennacoffee.Size = Size.VENDI;
            viennacoffee = new Condiments.Espresso(viennacoffee);
            viennacoffee = new Whip(viennacoffee);
            viennacoffee = new Whip(viennacoffee);
            PrintBeverage(viennacoffee);

            Beverage glace = new Beverages.Espresso();
            glace.Size = Size.VENDI;
            glace = new Condiments.Espresso(glace);
            glace = new IceCream(glace);
            PrintBeverage(glace);

            Beverage chocolatemilk = new Beverages.Chocolate();
            chocolatemilk.Size = Size.VENDI;
            chocolatemilk = new Milk(chocolatemilk);
            chocolatemilk = new Milk(chocolatemilk);
            PrintBeverage(chocolatemilk);

            Beverage democréme = new Beverages.Espresso();
            democréme.Size = Size.VENDI;
            democréme = new Condiments.Espresso(democréme);
            democréme = new Cream(democréme);
            democréme = new Cream(democréme);
            PrintBeverage(democréme);

            Beverage lattemacchiato = new Beverages.Espresso();
            lattemacchiato.Size = Size.VENDI;
            lattemacchiato = new SteamedMilk(lattemacchiato);
            lattemacchiato = new SteamedMilk(lattemacchiato);
            lattemacchiato = new MilkFoam(lattemacchiato);
            PrintBeverage(lattemacchiato);

            Beverage freddo = new Beverages.Espresso();
            freddo.Size = Size.VENDI;
            freddo = new Liqour(freddo);
            freddo = new Ice(freddo);
            PrintBeverage(freddo);

            Beverage frapppuccino = new Beverages.Espresso();
            frapppuccino.Size = Size.VENDI;
            frapppuccino = new Ice(frapppuccino);
            frapppuccino = new SteamedMilk(frapppuccino);
            frapppuccino = new Whip(frapppuccino);
            PrintBeverage(frapppuccino);

            Beverage caramelfrappuccino = new Beverages.Espresso();
            caramelfrappuccino.Size = Size.VENDI;
            caramelfrappuccino = new Ice(caramelfrappuccino);
            caramelfrappuccino = new SteamedMilk(caramelfrappuccino);
            caramelfrappuccino = new Cream(caramelfrappuccino);
            caramelfrappuccino = new Syrup(caramelfrappuccino);
            PrintBeverage(caramelfrappuccino);

            Beverage frappe = new Beverages.Espresso();
            frappe.Size = Size.VENDI;
            frappe = new SteamedMilk(frappe);
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream(frappe);
            PrintBeverage(frappe);

            Beverage irishcoffee = new Beverages.Espresso();
            irishcoffee.Size = Size.VENDI;
            irishcoffee = new Beverages.Espresso(irishcoffee);
            irishcoffee = new Whiskey(irishcoffee);
            irishcoffee = new Whip(irishcoffee);
            PrintBeverage(irishcoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.cost().ToString("#.##"));
        }
    }
}