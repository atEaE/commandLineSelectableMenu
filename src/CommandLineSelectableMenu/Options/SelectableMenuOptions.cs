using System;

namespace CommandLineSelectableMenu
{
    /// <summary>
    /// commandLine selectable menu options.
    /// </summary>
    public class SelectableMenuOptions
    {
        private ISelectedType selectedType = new ArrowSelectedType();

        /// <summary>
        /// Define the action for the currently selected item.
        /// Default Arrow.
        /// </summary>
        public ISelectedType SelectedType 
        { 
            get => selectedType; 
            set 
            {
                if (value == null)
                {
                    throw new ArgumentException("SelectedType cannot be set to Null.");
                }
                this.selectedType = value;
            }
        }

        /// <summary>
        /// Set to true to clear the selectable menu after selection.
        /// Default false.
        /// </summary>
        public bool IsClearAfterSelection { get; set; } = false;
    }
}
