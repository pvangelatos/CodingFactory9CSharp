using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace AbstractApp
{
    internal class Cat : AbstractAnimal
    {
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine($"{Name} is finally eating.");
        }
        public override string ToString() => $"Id={Id}, Name={Name}, Age={Age}";
    }
}
