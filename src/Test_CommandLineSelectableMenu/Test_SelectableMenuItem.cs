using CommandLineSelectableMenu;
using System;
using Xunit;

namespace Test_CommandLineSelectableMenu
{
    public class Test_SelectableMenuItem
    {
        [Fact]
        public void NewNullArgument()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => { new SelectableMenuItem<string>(null); });
            ex.Message.Is("Value cannot be null.");
        }
    }
}