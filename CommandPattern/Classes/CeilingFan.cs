using System;

namespace CommandPattern.Classes
{
    internal class CeilingFan
    {
        public int HIGH { get { return 3; } }
        public int MEDIUM { get { return 2; } }
        public int LOW { get { return 1; } }
        public int OFF { get { return 0; } }
        string location;
        int speed;

        public CeilingFan(string location)
        {
            this.location = location;
            speed = OFF;
        }

        private string SpeedName()
        {
            switch (speed)
            {
                case 3: return "high";
                case 2: return "medium";
                case 1: return "low";
                default: return "off";
            }
        }

        public void High()
        {
            speed = HIGH;
            Console.WriteLine(location + " ceiling fan is on " + SpeedName());
        }

        public void Medium()
        {
            speed = MEDIUM;
            Console.WriteLine(location + " ceiling fan is on " + SpeedName());
        }

        public void Low()
        {
            speed = LOW;
            Console.WriteLine(location + " ceiling fan is on " + SpeedName());
        }

        public void Off()
        {
            speed = OFF;
            Console.WriteLine(location + " ceiling fan is " + SpeedName());
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}