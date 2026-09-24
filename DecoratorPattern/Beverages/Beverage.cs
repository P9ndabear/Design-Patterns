using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }
    internal abstract class Beverage
    {
        public Size Size { get { return size; } set { size = value; } }
        private Size size;


        protected string description = "Unknown";
        protected Beverage baseBeverage = null;
        

        public virtual string GetDescription()
        {
            return description;
        }

        public virtual double cost()
        {
            switch (Size)
            {
                case Size.TALL:
                    return 300000.99;
                case Size.GRANDE:
                    return 600000.49;
                case Size.VENDI:
                    return 900000.99;
                default:
                    break;
            }
            return 0.0;
        }
    }
}
