using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8 {
    internal class Program {
        static void Main(string[] args) {

            int num;

            while (true) {
                // getting user input and guardian clauses for miss input
                Console.WriteLine("Enter a number to check if it is prime: ");
                Console.Write("Number: ");
                if (!int.TryParse(Console.ReadLine(), out num)) continue;

                Console.WriteLine($"Is {num} prime? {PrimeCheck(num)}");
            }
        }

        // check for prime attribute in a number
        private static bool PrimeCheck(int ceiling) {
            bool prime = true;

            // if number is divisable by any number smaller than itself which is not 1 => not prime
            for (int i = 2; i < ceiling; i++) {
                if (ceiling % i == 0) {
                    prime = false;
                    return prime;
                }
            }

            return prime;
        }
    }
}
