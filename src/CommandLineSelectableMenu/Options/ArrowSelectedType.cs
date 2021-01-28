using System;

namespace CommandLineSelectableMenu
{
    /// <summary>
    /// An arrow(>) will appear on the currently selected item.
    /// </summary>
    public class ArrowSelectedType : ISelectedType
    {
        private ConsoleColor baseColor = Console.ForegroundColor;
        private ConsoleColor selectedColor = Console.ForegroundColor;
        private ArrowType arrowType;

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

        /// <summary>
        /// Selection arrow type
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public ArrowType ArrowType {
            get => arrowType;
            
            set 
            {
                if (!Enum.IsDefined(typeof(ArrowType), value))
                {
                    throw new ArgumentException("ArrowType can only be set to Asterisk, Plus, or Arrow.");
                }
                arrowType = value;
            } 
        }

        /// <summary>
        /// Gets the arrow according to the ArrowType.
        /// </summary>
        /// <returns>arrow</returns>
        internal string GetArrow()
        {
            switch (arrowType)
            {
                case ArrowType.Arrow:
                    return ">";
                case ArrowType.Asterisk:
                    return "*";
                case ArrowType.Plus:
                    return "+";
                default:
                    throw new ArgumentException("ArrowType can only be set to Asterisk, Plus, or Arrow.");
            }
        }
    }

    /// <summary>
    /// Selection arrow type
    /// </summary>
    public enum ArrowType
    {
        /// <summary>
        /// Arrow Type(>)
        /// </summary>
        Arrow,

        /// <summary>
        /// Arrow Type(*)
        /// </summary>
        Asterisk,

        /// <summary>
        /// Arrow Type(+)
        /// </summary>
        Plus,
    }
}
