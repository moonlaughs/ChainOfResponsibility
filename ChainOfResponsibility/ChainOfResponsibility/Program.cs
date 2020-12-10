using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chain of Responsibility!");

            AbstractHandler squirrel = new SquirrelHandler();
            AbstractHandler dog = new DogHandler();

            squirrel.SetNext(squirrel).SetNext(dog);

            HandleRequest(squirrel);
        }

        public static void HandleRequest(AbstractHandler handler)
        {
            foreach (var food in new List<string> { "Nut", "MeatBall", "Cup of coffee" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }
}
