using CommandLineSelectableMenu;
using System;
using Xunit;

namespace Test_CommandLineSelectableMenu
{
    public class Test_SelectableMenu
    {
        [Fact]
        public void DoesNotExistMenuItemDraw()
        {
            // setup
            var selectableMenu = new SelectableMenu<string>();

            var ex = Assert.Throws<InvalidOperationException>(() => { selectableMenu.DrawSelectableMenu(); });
            ex.Message.Is("The item does not exist in the menu. Please set the item.");
        }
    }
}
