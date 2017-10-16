using System;

namespace XUnit.Metadata
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal sealed class XunitCategoryAttribute : Attribute
    {
        public XunitCategoryAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
