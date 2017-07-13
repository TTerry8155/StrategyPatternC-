using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategies
{
    public class WalkBehavior : IBehaviorStrategy
    {
        public void ExecuteBehavior()
        {
            Console.WriteLine("CRUNCH! CRUNCH! The animal is walking!");
        }
    }
}
