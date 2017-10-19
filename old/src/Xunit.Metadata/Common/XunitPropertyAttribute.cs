using System;

namespace Xunit.Metadata.Common
{
    /// <inheritdoc />
    /// <summary>
    /// Represents the category property for the <see cref="T:Xunit.Metadata.Common.XunitCategoryAttribute" />.
    /// </summary>
    /// <remarks>
    /// The <see cref="T:Xunit.Metadata.Common.XunitPropertyAttribute" /> defines the property to use in sub-categorization.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Property)]
    internal sealed class XunitPropertyAttribute : Attribute
    {
    }
}