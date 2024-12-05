using System;
using System.Linq;

namespace Task_4 {
    internal class Program {
        static void Main(string[] args) {

            char[] operators = { '+', '-', '*', '/'};
            float numA;
            float numB;
            char operator;

            while (true) {

                // getting user input and guardian clauses for miss input
                Console.WriteLine("Enter two numbers A and B followed by a operator(+,-,*,/) you want to apply to the two numbers (A x B): ");
                if (float.TryParse(Console.Read("A: "), out numA)) continue;
                if (float.TryParse(Console.Read("B: "), out numB)) continue;
                operator = Console.ReadKey().KeyChar;
                if (!operators.Contains(operators)) continue;

                Console.WriteLine($"{numA} {numB} {operator}");
            }

        }
    }
}
