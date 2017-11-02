using System;
using System.Collections.Generic;
using System.Text;
using Nightlight.Core.Nodes;
using Nightlight.Core.Attributes;
using System.Reflection;

namespace Nightlight.Core.Helpers
{
    public static class AttributeReader
    {
        public static void ReadAttributes<T>(T obj)
        {
            Console.WriteLine("ReadAttributes: Got Class: " + obj.GetType().ToString());
            var properties = typeof(T).GetProperties();

            Console.WriteLine($"ReadAttributes: Got {properties.Length} Properties");

            foreach (var property in properties)
            {
                Console.WriteLine($"ReadAttributes: PropName: {property.Name}");
                GetAttributeFromProperty(property);
            }
        }

        private static void GetAttributeFromProperty(PropertyInfo propertyInfo)
        {
            foreach (object attribute in propertyInfo.GetCustomAttributes(true))
            {
                if (attribute is NightlightStringAttribute nsa)
                {
                    Console.WriteLine($"Title: {nsa.Title}");
                    Console.WriteLine($"Required: {nsa.Required}");
                    Console.WriteLine($"MinLength: {nsa.MinLength}");
                    Console.WriteLine($"MaxLength: {nsa.MaxLength}");
                }
            }
        }
    }
}
