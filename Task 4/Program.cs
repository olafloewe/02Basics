using System;
using System.Linq;

namespace Task_4 {
    internal class Program {
        static void Main(string[] args) {

            char[] operators = { '+', '-', '*', '/'};
            float numA;
            float numB;
            float result = 0;
            char op;

            while (true) {

                // getting user input and guardian clauses for miss input
                Console.WriteLine("Enter two numbers A and B followed by a operator(+,-,*,/) you want to apply to the two numbers (A x B): ");
                Console.Write("A: ");
                if (!float.TryParse(Console.ReadLine(), out numA)) continue;
                Console.Write("B: ");
                if (!float.TryParse(Console.ReadLine(), out numB)) continue;
                Console.Write("Operator: ");
                op = Console.ReadKey().KeyChar;
                if (!operators.Contains(op)) continue;
                Console.WriteLine();

                switch (op) {
                    case '+':
                        result = numA + numB;
                        break;
                    case '-':
                        result = numA - numB;
                        break;
                    case '*':
                        result = numA * numB;
                        break;
                    case '/':
                        result = numA / numB;
                        break;
                }

                Console.WriteLine($"Result: {result}");
            }

        }
    }
}
