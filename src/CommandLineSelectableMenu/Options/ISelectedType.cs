using System;

namespace CommandLineSelectableMenu
{
    /// <summary>
    /// Define the action for the currently selected item.
    /// </summary>
    public interface ISelectedType
    {
        /// <summary>
        /// Sets the base text color for unselected text.
        /// </summary>
        ConsoleColor BaseColor { get; set; }

        /// <summary>
        /// Sets the text color for selection.
        /// </summary>
        ConsoleColor SelectedColor { get; set; }
    }
}
