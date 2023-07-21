using System.Net.Security;

namespace Repetition
{
    internal class Repetition
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int number; 
            double average;
            int upperbound = 100;

            //Task 1 
            Console.WriteLine("Task 1: ");
            for (number = 1; number <= upperbound; number++)
            {
                sum += number;
                Console.WriteLine("Current Number: " + number + " the sum is " + sum);
            }
            average = (double)sum / upperbound;  //Computed average + casting int to double 
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);

            //Task 2
            Console.WriteLine("Task 2: ");
            number = 1;
            sum = 0;
            while (number <= upperbound)
            {
                sum += number;
                // tracing for variables. 
                Console.WriteLine("Current Number: " + number + " the sum is " + sum);
                number++;
            }

            //Task 3
            Console.WriteLine("Task 3: ");
            number = 1;
            sum = 0;
            do
            {
                sum += number;
                Console.WriteLine("Current Number: " + number + " the sum is " + sum);
                number++;
            } while (number <= upperbound);
        }
    }
}