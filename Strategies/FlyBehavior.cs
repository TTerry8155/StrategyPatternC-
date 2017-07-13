using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategies
{
    public class FlyBehavior : IBehaviorStrategy
    {
        public void ExecuteBehavior()
        {
            Console.WriteLine("WOOSH WOOSH! The animal has taken off.");
        }
    }
}
