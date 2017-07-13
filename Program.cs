using StrategyPattern.Strategies;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalContext context;

            // Three contexts following different strategies
            context = new AnimalContext(new FlyBehavior(), "Jared the Mallard Duck");
            context.DescribeAnimal();
            context.PreformBehavior();

            context = new AnimalContext(new RoarBehavior(), "George the Gorilla");
            context.DescribeAnimal();
            context.PreformBehavior();

            context = new AnimalContext(new WalkBehavior(), "Adam the Man");
            context.DescribeAnimal();
            context.PreformBehavior();

            // Wait for user
            Console.ReadKey();
        }
    }
}