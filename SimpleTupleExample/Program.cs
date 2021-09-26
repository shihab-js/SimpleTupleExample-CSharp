using System;

namespace SimpleTupleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a tuple
            var numbers = Tuple.Create("One",2,3,4,5,6,7,8);

            //access the elements
            Console.WriteLine(numbers.Item1); //return One
            Console.WriteLine(numbers.Item2); //return 2
            Console.WriteLine(numbers.Item3); //return 3
            Console.WriteLine(numbers.Item4); //return 4
            Console.WriteLine(numbers.Item5); //return 5
            Console.WriteLine(numbers.Item6); //return 6
            Console.WriteLine(numbers.Item7); //return 7
            Console.WriteLine(numbers.Rest); //return 8
            Console.WriteLine(numbers.Rest.Item1); //return 8


        }
    }
}
