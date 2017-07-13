using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Strategies
{
    public class RoarBehavior : IBehaviorStrategy
    {
        public void ExecuteBehavior()
        {
            Console.WriteLine("ROARRRRRRRRRRRRRRRRRR!");
        }
    }
}
