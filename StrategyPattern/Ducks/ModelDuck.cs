using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class ModelDuck : Duck
    {
        public ModelDuck() 
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Model Duck");
        }
    }
}
