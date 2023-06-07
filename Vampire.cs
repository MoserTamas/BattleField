using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_OOP
{
    internal class Vampire : IBasicCharacter
    {
        public void Move()
        {
            Console.WriteLine("I am moving!");
        }

        public void Say()
        {
            Console.WriteLine("I need more blood!");
        }
        public void Eat()
        {
            Console.WriteLine("I am sucking blood!");
        }

    }
}
