using System;

namespace XUnit.Metadata.Common
{
    /// <inheritdoc />
    /// <summary>
    /// Represents the category property for the <see cref="T:XUnit.Metadata.Common.XunitCategoryAttribute" />.
    /// </summary>
    /// <remarks>
    /// The <see cref="T:XUnit.Metadata.Common.XunitPropertyAttribute" /> defines the property to use in sub-categorization.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Property)]
    internal sealed class XunitPropertyAttribute : Attribute
    {
    }
}