using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata.Common
{
    /// <inheritdoc cref="ITraitAttribute" />
    /// <summary>Access to an external dependency is a required for the test.</summary>
    [XunitCategory("External Dependency")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class ExternalDependencyAttribute : Attribute, ITraitAttribute
    {
        /// <inheritdoc />
        /// <summary>Associates the test with the External dependency category.</summary>
        /// <param name="reference">A reference identifier.</param>
        public ExternalDependencyAttribute(string reference = null)
        {
            Reference = reference;
        }

        /// <summary>A reference identifier.</summary>
        [XunitCategoryProperty]
        public string Reference { get; }
    }
}