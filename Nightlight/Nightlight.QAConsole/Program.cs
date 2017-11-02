using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nightlight.Core.Attributes;
using Nightlight.Core.Helpers;
using Nightlight.Core.Nodes;

namespace Nightlight.QAConsole
{
    public class TestClass
    {
        [NightlightString("Required String", Required = true)]
        public string RequiredString { get; set; }

        //public NightlightFormNodeString RequiredStringNode;

        [NightlightString("Optional String")]
        public string OptionalString { get; set; }

        //public NightlightFormNodeString OptionalStringNode;

        [NightlightString("Explicitly Optional String", Required = false)]
        public string ExplicitlyOptionalString { get; set; }

        //public NightlightFormNodeString ExplicitOptionalStringNode;

        [NightlightString("String Required and Longer than 3 Characters", Required = true, MinLength = 3)]
        public string RequiredStringLongerThanThreeCharacters { get; set; }

        //public NightlightFormNodeString RequiredStringLongerThanThreeCharactersNode;

    }

    class Program
    {
        

        static void Main(string[] args)
        {
            TestClass testClass = new TestClass
            {
                RequiredString = "This is my new String!"
            };

            AttributeReader.ReadAttributes(testClass);

            Console.ReadKey(true);
        }
    }
}
