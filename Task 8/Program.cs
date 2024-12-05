using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8 {
    internal class Program {
        static void Main(string[] args) {

            int heiInput;

            while (true) {
                // getting user input and guardian clauses for miss input
                Console.WriteLine("Enter the height of the pyramid to be printed: ");
                Console.Write("height: ");
                if (!int.TryParse(Console.ReadLine(), out heiInput)) continue;
                Console.WriteLine();

                DrawPyramid(heiInput);
            }
        }

        // draw pyramid function
        private static void DrawPyramid(int hei) {
            for (int i = 0; i < hei; i++) {
                for (int j = 0; j < (hei * 2); j++) {
                    // boundaries between which a * is printed
                    if (j >= hei - i && j <= hei + i) {
                        Console.Write('*');
                        continue;
                    }
                    Console.Write(' ');
                }
                Console.WriteLine(); // line break after each succesfull line print
            }

        }
    }
}
