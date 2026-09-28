namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.GetInstance();
            ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance();

            boiler.fill();
            boiler.boil();
            boiler.drain();

            boiler2.fill();
            boiler2.boil();
            boiler2.drain();
        }
    }
}