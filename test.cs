using System;
using System.Threading;
using System.Collections.Generic;
using System.Security.Policy;
using System.ComponentModel;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InitiateStyle();

            Dictionary<int, String> menu = InitializeMenu();
            DrawMenu(menu, 0);
            // Selection(menu);
            CycleSelection(menu);

        }

        // style function for console
        private static void InitiateStyle()
        {
            // Sets the console title.
            Console.Title = "Coloured Console";

            // set color theme
            Theme();

            // Hides the Cursor
            Console.CursorVisible = false;

            // Clears the background
            Console.Clear();

            // hard coded declaration of window dimensions
            Console.SetWindowSize(100, 20);
        }

        // choose from a color theme
        private static void Theme(String style = "")
        {
            switch (style)
            {
                case "highlight":
                    // colors to "highlight"
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    // reset colors to default
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        // menu
        private static Dictionary<int, String> InitializeMenu()
        {
            // initialize and define menu options
            Dictionary<int, String> options = new Dictionary<int, String>();

            options.Add(1, "Draw Borders");
            options.Add(2, "Loading Percentage");
            options.Add(3, "Loading Line & Percentage");
            options.Add(4, "Loading Cursor");
            options.Add(5, "Up-Down Animation");
            options.Add(6, "Screen Bounce Animation");
            options.Add(7, "Quit");

            return options;
        }

        // draw menu
        private static void DrawMenu(Dictionary<int, String> options, int selected = 0)
        {

            // print header of menu
            Console.SetCursorPosition(2, 2); // indents cursor by 2 from the top and the left
            Console.WriteLine("Menu - Please Select");

            // print options of menu
            foreach (KeyValuePair<int, String> option in options)
            {
                // highlight selected
                string currSelected = (option.Key == selected) ? "highlight" : "";
                Theme(currSelected);

                Console.SetCursorPosition(2, 2 + option.Key); // indent cursor by 2 from left
                Console.Write($"{option.Key}. {option.Value}");
            }

            Theme(); // reset theme
            Console.WriteLine();
        }

        // cycles through the menu options
        private static void CycleSelection(Dictionary<int, String> options) {

            int selected = 1;
            bool down = true;

            while (true) {
                DrawMenu(options, selected); // highlight selected option
                Thread.Sleep(300);

                // direction change on boundaries
                if (selected == 6) down = false;
                if (selected == 1) down = true;

                // move pointer
                selected = (down)? selected+1: selected-1;
            }

        }

    }
}
