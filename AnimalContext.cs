using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class AnimalContext
    {
        public string Name { get; set; }

        public void PreformBehavior()
        {

        }

        public void DescribeAnimal()
        {
            Console.WriteLine("This animal name is {0}.", Name);
        }
    }
}
