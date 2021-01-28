using CommandLineSelectableMenu;
using System;
using Xunit;

namespace Test_CommandLineSelectableMenu
{
    public class Test_SelectableMenuOptions
    {
        private SelectableMenuOptions options;

        public Test_SelectableMenuOptions()
        {
            options = new SelectableMenuOptions();
        }

        [Fact]
        public void DefaultValueCheck()
        {
            options.SelectedType.IsNotNull();
            options.SelectedType.GetType().Is(typeof(ArrowSelectedType));
            options.IsClearAfterSelection.Is(false);
        }
    }
}
