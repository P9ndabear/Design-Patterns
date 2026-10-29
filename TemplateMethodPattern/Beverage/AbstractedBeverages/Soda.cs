namespace TemplateMethodPattern
{
    public class Soda : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Doing something with the soda idk what");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding vanilla ice cream");
        }
    }
}
