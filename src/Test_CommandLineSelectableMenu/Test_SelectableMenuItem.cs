using CommandLineSelectableMenu;
using System;
using Xunit;

namespace Test_CommandLineSelectableMenu
{
    public class Test_SelectableMenuItem
    {
        [Fact]
        public void NewNullArgument_item()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => { new SelectableMenuItem<string>(null, new SelectableMenuOptions()); });
            ex.Message.Is("Value cannot be null. (Parameter 'item')");
        }

        [Fact]
        public void NewNullArgument_options()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => { new SelectableMenuItem<string>("Sample1", null); });
            ex.Message.Is("Value cannot be null. (Parameter 'options')");
        }
    }
}