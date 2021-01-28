using System;

namespace CommandLineSelectableMenu
{
    /// <summary>
    /// You can change the text color of the currently selected item.
    /// </summary>
    public class ColorSelectedType : ISelectedType
    {
        private ConsoleColor baseColor = Console.ForegroundColor;
        private ConsoleColor selectedColor = ConsoleColor.Yellow;

        /// <summary>
        /// Sets the base text color for unselected text.
        /// Default Console default.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public ConsoleColor BaseColor
        { 
            get => baseColor;
            set 
            {
                if (!Enum.IsDefined(typeof(ConsoleColor), value))
                {
                    throw new ArgumentException("The ConsoleColor enum value was not defined on that enum. Please use a defined color from the enum.");
                }
                baseColor = value;
            }
        }

        /// <summary>
        /// Sets the text color for selection.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public ConsoleColor SelectedColor
        {
            get => selectedColor;
            set
            {
                if (!Enum.IsDefined(typeof(ConsoleColor), value))
                {
                    throw new ArgumentException("The ConsoleColor enum value was not defined on that enum. Please use a defined color from the enum.");
                }
                selectedColor = value;
            }
        }
    }
}
