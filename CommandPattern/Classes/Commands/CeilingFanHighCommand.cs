using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanHighCommand : Command
    {
        CeilingFan ceilingFan;
        //Stack om de vorige snelheid in een stapel op te slaan
        Stack<int> prevSpeeds = new Stack<int>();
        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            // Push om de snelheid op de stapel te zetten
            prevSpeeds.Push(ceilingFan.GetSpeed());
            ceilingFan.High();
        }

        public void Undo()
        {
            // Pop om het van de stapel af te halen
            int speed = prevSpeeds.Pop();
            switch(speed)
            {
                case 3:
                    ceilingFan.High();
                    break;
                case 2:
                    ceilingFan.Medium();
                    break;
                case 1:
                    ceilingFan.Low();
                    break;
                case 0:
                    ceilingFan.Off();
                    break;
            }
        }
    }
}
