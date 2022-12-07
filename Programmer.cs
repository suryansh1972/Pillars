using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    public class Programmer : Creator
    {
        public override void Create()
        {
            if (base.CreativityLevl >= 70 && base.Energy >= 80)
            {
                this.BrainStrom();
                this.PickSolution();
                this.WriteCode();
                this.ReadCode();
            }
            else
            {
                throw new Exception("Monke");
            }
        }

        private void BrainStrom()
        {
            base.CreativityLevl = base.CreativityLevl -1;
            base.Energy = base.Energy + 1;
            Console.WriteLine("Brainstorming solutions .....");
        }
        private void PickSolution()
        {
            base.CreativityLevl = base.CreativityLevl - 1;
            base.Energy = base.Energy + 1;
            Console.WriteLine("Picking out optimal solutions .....");
        }
        private void WriteCode()
        {
            base.CreativityLevl = base.CreativityLevl - 1;
            base.Energy = base.Energy + 1;
            Console.WriteLine("Writing code.....");
        }
        private void ReadCode()
        {
            base.CreativityLevl = base.CreativityLevl - 1;
            base.Energy = base.Energy + 1;
            Console.WriteLine("Testing .....");
        }
    }

}
     