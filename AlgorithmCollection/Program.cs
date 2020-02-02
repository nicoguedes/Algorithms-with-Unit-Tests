using AlgorithmCollection.Solutions;
using System;

namespace AlgorithmCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick what algorithm you would like to test:");

                Console.WriteLine(@"
                    1 - Fibonacci
                    2 - Whatever");

                var key = Console.ReadKey();
                switch (key.KeyChar)
                {
                    case '1':
                        RunFibonacci();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press 1 to view full stack trace.");
                if (Console.ReadKey().KeyChar == '1')
                    Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Bye!");
            }
        }

        private static void RunFibonacci()
        {
            Console.WriteLine("Please enter a value for \"n\".");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                throw new ArgumentException("Invalid input for n. It should be an Integer number.");
            }

            Fibonacci f = new Fibonacci();
            Console.WriteLine($"The nth term is: {f.CalculateFibonacci(n)}");
        }
    }
}
