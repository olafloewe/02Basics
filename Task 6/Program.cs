using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6 {
    internal class Program {
        static void Main(string[] args) {

            int num;

            while (true) {

                // getting user input and guardian clauses for miss input
                Console.WriteLine("Enter a number from 1-10 to calculate the factorial of the number: ");
                Console.Write("Number: ");
                if (!int.TryParse(Console.ReadLine(), out num)) continue;
                if(num < 1 || num > 10) continue;

                Console.WriteLine($"Factorial of {num}: {Factorial(num)}");
            }

        }

        // recursive factorial calculation
        private static int Factorial(int input) {
            if (input == 1) return 1; 
            return input * Factorial(input - 1);
        }
    }
}
