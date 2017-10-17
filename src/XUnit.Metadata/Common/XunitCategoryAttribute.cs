using System;

namespace XUnit.Metadata.Common
{
    /// <summary>
    /// Represents an <see cref="Xunit.Sdk.ITraitAttribute"/> for xUnit.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal sealed class XunitCategoryAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XunitCategoryAttribute"/> class flagging the attribute for code generation.
        /// </summary>
        /// <param name="name">The name as a string literal.</param>
        /// <remarks>
        /// The T4 Template that generated all the boilerplate code for the trait discoverers requires that the provided argument is a string literal, not a constant.
        /// </remarks>
        public XunitCategoryAttribute(string name)
        {
            Name = name;
        }

        /// <summary>
        /// The name of the category.
        /// </summary>
        public string Name { get; }
    }
}
