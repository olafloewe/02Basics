using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7 {
    internal class Program {
        static void Main(string[] args) {

            int hei;
            int wid;

            while (true) {

                // getting user input and guardian clauses for miss input
                Console.WriteLine("Enter the height and width of the rectangle to be printed: ");
                Console.Write("height: ");
                if (!int.TryParse(Console.ReadLine(), out hei)) continue;
                Console.Write("width: ");
                if (!int.TryParse(Console.ReadLine(), out wid)) continue;
                Console.WriteLine();

                for (int i = 0; i < hei; i++) {
                    for (int j = 0; j < wid; j++) {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
