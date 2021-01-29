using CommandLineSelectableMenu;
using System;
using Xunit;

namespace Test_CommandLineSelectableMenu
{
    public class Test_SelectableMenuItem
    {
        [Fact]
        public void NewNullArgument_title()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => { new SelectableMenuItem<string>(null, "Sample1", new SelectableMenuOptions()); });
            ex.Message.Is("Value cannot be null. (Parameter 'title')");
        }

        [Fact]
        public void NewNullArgument_item()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => { new SelectableMenuItem<string>("Title", null, new SelectableMenuOptions()); });
            ex.Message.Is("Value cannot be null. (Parameter 'item')");
        }

        [Fact]
        public void NewNullArgument_options()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => { new SelectableMenuItem<string>("Title", "Sample1", null); });
            ex.Message.Is("Value cannot be null. (Parameter 'options')");
        }
    }
}