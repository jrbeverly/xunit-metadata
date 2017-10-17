using System;

namespace XUnit.Metadata.Common
{
    /// <summary>
    /// Represents the category property for the <see cref="XunitCategoryAttribute"/>.
    /// </summary>
    /// <remarks>
    /// The <see cref="XunitPropertyAttribute"/> defines the property to use in sub-categorization.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal sealed class XunitPropertyAttribute : Attribute
    {
        /// <summary>
        /// Constructs a instance of the attribute.
        /// </summary>
        public XunitPropertyAttribute()
        {
        }
    }
}
