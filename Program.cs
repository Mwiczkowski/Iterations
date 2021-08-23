using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i = i+2) //Explanation: (variable i is initiated with value 0, then a condition is checked if i is equal or lesser to 9, finally, the value of variable i is incremented on each loop by 1)
            {
                Console.WriteLine(i);
            }

            string userIsDone = "";
            while (userIsDone != "yes")
            {
                Console.WriteLine("Processing WHILE Loop");
                Console.WriteLine("End process?");
                userIsDone = Console.ReadLine();
            }

            do
            {
                Console.WriteLine("Processing DO/WHILE Loop");
                Console.WriteLine("End process?");
                userIsDone = Console.ReadLine();
            }
            while (userIsDone != "yes");
        }
    }
}
