using CommandLineSelectableMenu;
using System;
using Xunit;

namespace Test_CommandLineSelectableMenu
{
    public class Test_ArrowSelectedType
    {
        // test instance.
        private ArrowSelectedType type;
        
        // Setup
        public Test_ArrowSelectedType()
        {
            type = new ArrowSelectedType();
        }

        [Fact]
        public void DefaultValueCheck()
        {
            type.BaseColor.Is(Console.ForegroundColor);
            type.SelectedColor.Is(Console.ForegroundColor);
            type.ArrowType.Is(ArrowType.Arrow);
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

        [Fact]
        public void SetPropertyInvalidValue_ArrowType()
        {
            var ex = Assert.Throws<ArgumentException>(() => { type.ArrowType = (ArrowType)777; });
            ex.Message.Is("ArrowType can only be set to Asterisk, Plus, or Arrow.");
        }

        [Fact]
        public void GetArrow()
        {
            var testCases = new[] 
            {
                new { verificationType = new ArrowSelectedType(){ ArrowType = ArrowType.Arrow }, assertArrow = ">" },
                new { verificationType = new ArrowSelectedType(){ ArrowType = ArrowType.Asterisk }, assertArrow = "*" },
                new { verificationType = new ArrowSelectedType(){ ArrowType = ArrowType.Plus }, assertArrow = "+" },
            };

            foreach(var tc in testCases)
            {
                tc.verificationType.GetArrow().Is(tc.assertArrow);
            }
        }
    }
}
