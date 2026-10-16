using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanOffCommand : Command
    {
        CeilingFan ceilingFan;
        Stack<int> prevSpeeds = new Stack<int>();

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeeds.Push(ceilingFan.GetSpeed());
            ceilingFan.Off();
        }

        public void Undo()
        {
            int speed = prevSpeeds.Pop();
            switch (speed)
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
