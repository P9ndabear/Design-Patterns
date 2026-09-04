using System.Security.Cryptography.X509Certificates;
using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            performAllAction(mallardDuck);
            Duck redheadDuck = new RedheadDuck();
            performAllAction(redheadDuck);
            Duck decoyDuck = new DecoyDuck();
            performAllAction(decoyDuck);
            Duck rubberDuck = new RubberDuck();
            performAllAction(rubberDuck);
            Duck robotDuck = new RobotDuck();
            performAllAction(robotDuck);
            Duck modelDuck = new ModelDuck();
            modelDuck.PerformFly();
            modelDuck.SetFlyBehavior(new FlyWithRocket());
            modelDuck.PerformFly();
        }

        public static void performAllAction(Duck duck)
        {
            duck.Display();
            duck.PerformQuack();
            duck.PerformFly();
            duck.PerformSwim();
        }
     }
}