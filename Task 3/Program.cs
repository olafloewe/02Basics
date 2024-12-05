using System;

namespace Task_3 {
    internal class Program {
        static void Main(string[] args) {
            // basic variable decleration
            float[] numbers = new float[3];

            while (true) {
                bool err = false;

                // getting user input
                Console.WriteLine($"Enter {numbers.Length} numbers to be sorted in an ascending order:");
                for (int i = 0; i < numbers.Length; i++) {
                    Console.Write($"{i + 1}: ");
                    // err on non numerical input
                    if (!float.TryParse(Console.ReadLine(), out numbers[i])) err = true;
                }

                // re ask in case of err
                if (err) continue;

                // im assuming we are allowed to use this function since there was no mentioned of not being allowed to use it
                Array.Sort(numbers);

                for (int i = 0; i < numbers.Length; i++) {
                    Console.Write($"{numbers[i]}, ");
                }

                Console.WriteLine();
            }
        }
    }
}
