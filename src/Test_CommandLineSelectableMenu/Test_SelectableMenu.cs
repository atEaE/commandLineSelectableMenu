using CommandLineSelectableMenu;
using System;
using Xunit;

namespace Test_CommandLineSelectableMenu
{
    public class Test_SelectableMenu
    {
        [Fact]
        public void NullAdd()
        {
            // setup
            var selectableMenu = new SelectableMenu<string>();

            var ex = Assert.Throws<ArgumentNullException>(() => { selectableMenu.Add(null); });
            ex.Message.Is("Value cannot be null.");
        }

        [Fact]
        public void NullAddRange()
        {
            // setup
            var selectableMenu = new SelectableMenu<string>();

            var ex = Assert.Throws<ArgumentNullException>(() => { selectableMenu.AddRange(null); });
            ex.Message.Is("Value cannot be null.");
        }

        [Fact]
        public void DoesNotExistMenuItemDraw()
        {
            // setup
            var selectableMenu = new SelectableMenu<string>();

            var ex = Assert.Throws<InvalidOperationException>(() => { selectableMenu.Draw(); });
            ex.Message.Is("The item does not exist in the menu. Please set the item.");
        }
    }
}
