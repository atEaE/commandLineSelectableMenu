using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandLineSelectableMenu
{
    /// <summary>
    /// commandLine selectable menu.
    /// </summary>
    public class SelectableMenu<T>
    {
        private List<SelectableMenuItem<T>> items;
        private int selectedIndex = 0;

        /// <summary>
        /// Create new selectable menu instance.
        /// </summary>
        public SelectableMenu()
        {
            items = new List<SelectableMenuItem<T>>();
        }

        /// <summary>
        /// Add a menu item.
        /// </summary>
        /// <param name="item">menu item.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }

            items.Add(new SelectableMenuItem<T>(item));
        }

        /// <summary>
        /// Add a menu item.
        /// </summary>
        /// <param name="collection">menu items.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddRange(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }

            items.AddRange(collection.Select(i => new SelectableMenuItem<T>(i)));
        }

        /// <summary>
        /// Draw the selectable menu.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public T Draw()
        {
            if (!items.Any())
            {
                throw new InvalidOperationException("The item does not exist in the menu. Please set the item.");
            }

            var currentRow = Console.CursorTop;
            foreach(var i in items)
            {
                i.SetPosition(currentRow);
                currentRow++;
            }            

            do
            {
                for (var i = 0; i < items.Count; i++)
                {
                    if (selectedIndex == i)
                    {
                        items[i].Draw(selected: true);
                    }
                    else
                    {
                        items[i].Draw();
                    }
                }

                var keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndexDecrement();
                        break;
                    case ConsoleKey.DownArrow:
                        selectedIndexIncrement();
                        break;
                    case ConsoleKey.Enter:
                        return items[selectedIndex].Item;
                    default:
                        break;
                }
            }
            while (true);
        }

        /// <summary>
        /// Move the index one step forward.
        /// </summary>
        private void selectedIndexIncrement()
        {
            if (selectedIndex < items.Count - 1)
            {
                selectedIndex++;
            }
        }

        /// <summary>
        /// Move the index one step back.
        /// </summary>
        private void selectedIndexDecrement()
        {
            if (selectedIndex > 0)
            {
                selectedIndex--;
            }
        }
    }
}
