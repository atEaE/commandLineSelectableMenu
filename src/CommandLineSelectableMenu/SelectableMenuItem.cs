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
        private SelectableMenuOptions options;
        private string title;

        /// <summary>
        /// Menu title.
        /// </summary>
        internal string Title { get => title; private set { title = value; } }        

        /// <summary>
        /// draw item template.
        /// 
        /// {0} : selectable cursor.
        /// {1} : menu item.
        /// </summary>
        private const string ITEM_TEMPLATE = " {0} {1}";

        /// <summary>
        /// Create new selectable menuItem instance.
        /// </summary>
        /// <param name="title">menu title.</param>
        /// <param name="item">menu item.</param>
        /// <param name="options">menu options.</param>
        /// <exception cref="ArgumentNullException"></exception>
        internal SelectableMenuItem(string title, T item, SelectableMenuOptions options)
        {
            if (title == null)
            {
                throw new ArgumentNullException(nameof(title));
            }

            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            this.title = title;
            this.item = item;
            this.options = options;
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
            // Draws to the console only when there is a status change.
            if (this.selected != selected)
            {
                Console.SetCursorPosition(0, row);
                if (selected)
                {
                    Console.ForegroundColor = options.SelectedType.SelectedColor;
                    var cursor = options.SelectedType is ArrowSelectedType ? ((ArrowSelectedType)options.SelectedType).GetArrow() : " ";
                    Console.WriteLine(ITEM_TEMPLATE, cursor, title);
                }
                else
                {
                    Console.ForegroundColor = options.SelectedType.BaseColor;
                    Console.WriteLine(ITEM_TEMPLATE, " ", title);
                }
                Console.ResetColor();

                this.selected = selected;
            }
        }

        /// <summary>
        /// Clear the selectable menuItem.
        /// </summary>
        internal void Crear()
        {
            Console.SetCursorPosition(0, row);
            Console.Write(new string(' ', Console.WindowWidth));
        }

    }
}
