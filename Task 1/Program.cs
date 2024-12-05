using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1 {
    internal class Program {
        static void Main(string[] args) {
            String readLine;
            int num;
            string evenOdd;

            while (true) {
                Console.Write("Enter a Number to see it its even or odd ");
                readLine = Console.ReadLine();
                if (!int.TryParse(readLine.ToString(), out num)) continue;
                evenOdd = (num % 2 == 0)? "even" : "odd";
                Console.WriteLine($"{num} is {evenOdd}");
            }
        }
    }
}
