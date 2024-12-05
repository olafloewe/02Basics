using System;

namespace Task_2 {
    internal class Program {
        static void Main(string[] args) {
            // basic variable decleration
            String readA;
            String readB;
            float numA;
            float numB;

            while (true) {

                // getting user input
                Console.WriteLine("Enter A and B to calculate (a*b) / (a+b)");
                Console.Write("A: ");
                readA = Console.ReadLine();
                Console.Write("B: ");
                readB = Console.ReadLine();

                // guardian clauses for A and B to be numerical
                if (!float.TryParse(readA.ToString(), out numA)) continue;
                if (!float.TryParse(readB.ToString(), out numB)) continue;

                Console.WriteLine($"Result of the calculation: {(float)(numA * numB) / (float)(numA + numB)}");
            }
        }
    }
}
