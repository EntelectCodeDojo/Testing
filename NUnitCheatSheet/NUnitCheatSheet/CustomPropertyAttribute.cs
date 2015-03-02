using System;
using NUnit.Framework;

namespace NUnitCheatSheet
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class CustomPropertyAttribute : PropertyAttribute
    {
        public CustomPropertyAttribute(CustomPropertyValue value)
            : base("Custom", value.ToString())
        {
        }
    }
}