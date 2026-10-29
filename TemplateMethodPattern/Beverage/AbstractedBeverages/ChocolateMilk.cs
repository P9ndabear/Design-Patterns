namespace TemplateMethodPattern
{
    public class ChocolateMilk : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Brutally simmering the Milk and Chocolate");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Whipped Cream");
        }
    }
}