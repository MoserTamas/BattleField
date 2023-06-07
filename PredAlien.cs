using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_OOP
{
    internal class PredAlien : Predator
    {
        public override void Say()
        {
            Console.WriteLine("You will be my dinner!");
        }
    }
}
