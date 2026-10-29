namespace TemplateMethodPattern
{
    internal class SodaWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Doing something with soda idk what");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding vanilla ice cream");
        }
        public override bool CustomerWantsCondement()
        {
            Console.WriteLine("Would you like vanilla ice cream with your soda (y/n)?");
            string answer = Console.ReadLine();
            return answer.ToLower().StartsWith('y');
        }
    }
}
