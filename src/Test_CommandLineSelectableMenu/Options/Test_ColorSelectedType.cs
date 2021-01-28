using CommandLineSelectableMenu;
using System;
using Xunit;

namespace Test_CommandLineSelectableMenu
{
    public class Test_ColorSelectedType
    {
        // test instance.
        private ColorSelectedType type;

        // Setup
        public Test_ColorSelectedType()
        {
            type = new ColorSelectedType();
        }

        [Fact]
        public void DefaultValueCheck()
        {
            type.BaseColor.Is(Console.ForegroundColor);
            type.SelectedColor.Is(ConsoleColor.Yellow);
        }

        [Fact]
        public void SetPropertyCheck()
        {
            type.BaseColor = ConsoleColor.Cyan;
            type.SelectedColor = ConsoleColor.Red;

            type.BaseColor.Is(ConsoleColor.Cyan);
            type.SelectedColor.Is(ConsoleColor.Red);
        }

        [Fact]
        public void SetPropertyInvalidValue_BaseColor()
        {
            var ex = Assert.Throws<ArgumentException>(() => { type.BaseColor = (ConsoleColor)12345; });
            ex.Message.Is("The ConsoleColor enum value was not defined on that enum. Please use a defined color from the enum.");
        }

        [Fact]
        public void SetPropertyInvalidValue_SelectedColor()
        {
            var ex = Assert.Throws<ArgumentException>(() => { type.SelectedColor = (ConsoleColor)12345; });
            ex.Message.Is("The ConsoleColor enum value was not defined on that enum. Please use a defined color from the enum.");
        }
    }
}
