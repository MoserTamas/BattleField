using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_OOP
{
    internal class Predator : IBasicCharacter
    {
        public void Move()
        {
            Console.WriteLine("I am crawling up!");
        }

        public void Eat()
        {
            Console.WriteLine("I do not eat");
        }

        public virtual void Say()
        {
            Console.WriteLine("Where is my beer?");
        }
    }
}
