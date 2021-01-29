using CommandLineSelectableMenu;
using System;
using System.Collections.Generic;
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
            ex.Message.Is("Value cannot be null. (Parameter 'item')");
        }

        [Fact]
        public void NullAdd_Title()
        {
            // setup
            var selectableMenu = new SelectableMenu<string>();

            var ex = Assert.Throws<ArgumentNullException>(() => { selectableMenu.Add(null, "sample"); });
            ex.Message.Is("Value cannot be null. (Parameter 'title')");
        }

        [Fact]
        public void NullAdd_Item()
        {
            // setup
            var selectableMenu = new SelectableMenu<string>();

            var ex = Assert.Throws<ArgumentNullException>(() => { selectableMenu.Add("title", null); });
            ex.Message.Is("Value cannot be null. (Parameter 'item')");
        }

        [Fact]
        public void NullAdd_KvPKey()
        {
            // setup
            var selectableMenu = new SelectableMenu<string>();

            var ex = Assert.Throws<ArgumentNullException>(() => { selectableMenu.Add(new KeyValuePair<string, string>(null, "sample")); });
            ex.Message.Is("Value cannot be null. (Parameter 'item.Key')");
        }

        [Fact]
        public void NullAdd_NullAdd_KvPValue()
        {
            // setup
            var selectableMenu = new SelectableMenu<string>();

            var ex = Assert.Throws<ArgumentNullException>(() => { selectableMenu.Add(new KeyValuePair<string, string>("title", null)); });
            ex.Message.Is("Value cannot be null. (Parameter 'item.Value')");
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
