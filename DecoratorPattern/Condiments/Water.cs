using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Water : CondimentDecorator
    {
        public Water(Beverage beverage) : base(beverage)
        {

        }

        public override double cost()
        {
            return 0.90 + base.cost() + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Water";
        }
    }
}
