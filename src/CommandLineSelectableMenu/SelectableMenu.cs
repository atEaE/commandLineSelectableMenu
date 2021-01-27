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
        private List<T> items;

        /// <summary>
        /// Create new selectable menu instance.
        /// </summary>
        public SelectableMenu()
        {
            items = new List<T>();
        }

        /// <summary>
        /// Add a menu item.
        /// </summary>
        /// <param name="item">menu item.</param>
        public void Add(T item)
        {
            items.Add(item);
        }

        /// <summary>
        /// Add a menu item.
        /// </summary>
        /// <param name="collection">menu items.</param>
        public void AddRange(IEnumerable<T> collection)
        {
            items.AddRange(collection);
        }

        /// <summary>
        /// Draw the selectable menu.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public void DrawSelectableMenu()
        {
            if (!items.Any())
            {
                throw new InvalidOperationException("The item does not exist in the menu. Please set the item.");
            }
        }
    }
}
