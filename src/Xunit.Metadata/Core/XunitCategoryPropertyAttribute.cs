using System;

namespace Xunit.Metadata.Core
{
    /// <inheritdoc />
    /// <summary>Represents the category property for the <see cref="T:Xunit.Metadata.Core.XunitCategoryAttribute" />.</summary>
    /// <remarks>The <see cref="T:Xunit.Metadata.Core.XunitPropertyAttribute" /> defines the property to use in sub-categorization.</remarks>
    [AttributeUsage(AttributeTargets.Property)]
    internal sealed class XunitCategoryPropertyAttribute : Attribute
    {
    }
}