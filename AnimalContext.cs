using StrategyPattern.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class AnimalContext
    {
        private IBehaviorStrategy _strategy;

        public AnimalContext(IBehaviorStrategy strategy, string name)
        {
            _strategy = strategy;
            Name = name;
        }

        public string Name { get; set; }
    
        public void PreformBehavior()
        {
            _strategy.ExecuteBehavior();
        }

        public void DescribeAnimal()
        {
            Console.WriteLine("This animal name is {0}.", Name);
        }
    }
}
