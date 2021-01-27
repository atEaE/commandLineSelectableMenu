using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Test_CommandLineSelectableMenu")]
namespace CommandLineSelectableMenu
{
    /// <summary>
    /// commandLine selectable menu item.
    /// </summary>
    internal class SelectableMenuItem<T>
    {
        private T item;
        private bool? selected;
        private int row;

        /// <summary>
        /// Create new selectable menuItem instance.
        /// </summary>
        /// <param name="item">menu item.</param>
        /// <exception cref="ArgumentNullException"></exception>
        internal SelectableMenuItem(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }

            this.item = item;
        }

        /// <summary>
        /// Returns the item stored inside.
        /// </summary>
        internal T Item { get => item; }

        /// <summary>
        /// Sets the display position of the item.
        /// </summary>
        /// <param name="row">console row number</param>
        internal void SetPosition(int row)
        {
            this.row = row;
        }

        /// <summary>
        /// Draw the selectable menuItem.
        /// </summary>
        internal void Draw(bool selected = false)
        {
            if (this.selected != selected)
            {
                if (selected)
                {
                    Console.SetCursorPosition(0, row);
                    Console.WriteLine($" > {item}");
                }
                else
                {
                    Console.SetCursorPosition(0, row);
                    Console.WriteLine($"   {item}");
                }

                this.selected = selected;
            }
        }
    }
}
