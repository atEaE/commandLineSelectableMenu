using CommandLineSelectableMenu;
using System;

namespace SelectableMenuExample
{
    /// <summary>
    /// Example program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        /// <param name="args">commandline arguments</param>
        public static void Main(string[] args)
        {
            // description
            Console.WriteLine("It is easy to create a select menu on CommandLine.");
            Console.WriteLine("You can color selections, place a cursor, etc.");
            Console.WriteLine("");

            // create selectable menu instance.
            //
            // 1. When selected, thr color is green.
            // 2. When selected, clear menu.
            var options = new SelectableMenuOptions()
            {
                SelectedType = new ArrowSelectedType()
                {
                    SelectedColor = ConsoleColor.Green,
                },
                IsClearAfterSelection = true,
            };
            var selectableMenu = new SelectableMenu<Action>(options);

            // setup menu item.
            selectableMenu.Add("Would you choose item A?", () => { Console.WriteLine("item A Selected!!"); });
            selectableMenu.Add("Would you choose item B?", () => { Console.WriteLine("item B Selected!!"); });
            selectableMenu.Add("Would you choose item C?", () => { Console.WriteLine("item C Selected!!"); });
            selectableMenu.Add("Would you choose item D?", () => { Console.WriteLine("item D Selected!!"); });

            // Draw a menu in the console.
            var selected = selectableMenu.Draw();
            selected.Invoke();

            Console.ReadKey();
        }
    }
}
