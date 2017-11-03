using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata
{
    /// <inheritdoc cref="ITraitAttribute" />
    /// <summary>System is tested against the functional requirements/specifications.</summary>
    [XunitCategory("Functional")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class FunctionalAttribute : Attribute, ITraitAttribute
    {
        /// <inheritdoc />
        /// <summary>Associates the test with the Functional category and optional reference.</summary>
        /// <param name="reference">A reference identifier.</param>
        public FunctionalAttribute(string reference = null)
        {
            Reference = reference;
        }

        /// <summary>A reference identifier.</summary>
        [XunitCategoryProperty]
        public string Reference { get; }
    }
}