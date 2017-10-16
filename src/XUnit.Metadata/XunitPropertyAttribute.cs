using System;

namespace XUnit.Metadata
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal sealed class XunitPropertyAttribute : Attribute
    {
        public XunitPropertyAttribute()
        {
        }
    }
}
