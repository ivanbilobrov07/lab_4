using System.Diagnostics.Metrics;

namespace ConsoleApp
{
    internal class Program
    {
        public delegate int CountDelegate(string str, char symbol);

        static void Main(string[] args)
        {
            CountDelegate FindNumberOfSymbolUsage = delegate (string str, char symbol)
            {
                int counter = 0;

                foreach (char letter in str)
                {
                    if (letter == symbol)
                    {
                        counter++;
                    }
                }

                return counter;
            };

            int NumberOfZerosInString1 = FindNumberOfSymbolUsage("01231230qwd", '0');
            Console.WriteLine(NumberOfZerosInString1);

            FindNumberOfSymbolUsage = (string str, char symbol) =>
            {
                int counter = 0;

                foreach (char letter in str)
                {
                    if (letter == symbol)
                    {
                        counter++;
                    }
                }

                return counter;
            };

            int NumberOfZerosInString2 = FindNumberOfSymbolUsage("01231230qwd", '0');
            Console.WriteLine(NumberOfZerosInString2);

            MathOperations MO = new MathOperations();
            MO.OnEvent += DivisionHandler;

            MO.Division(4, 1);


        }
        
        public static void DivisionHandler(int result, EventArgs args)
        {
            Console.WriteLine(result);
        }
    }
}
