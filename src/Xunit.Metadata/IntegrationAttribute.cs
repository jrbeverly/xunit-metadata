using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata
{
    /// <inheritdoc cref="ITraitAttribute" />
    /// <summary>A group of components are combined to produce a result.</summary>
    [XunitCategory("Integration")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class IntegrationAttribute : Attribute, ITraitAttribute
    {
        /// <inheritdoc />
        /// <summary>Associates the test with the Integration category and optional reference.</summary>
        /// <param name="reference">A reference identifier.</param>
        public IntegrationAttribute(string reference = null)
        {
            Reference = reference;
        }

        /// <summary>A reference identifier.</summary>
        [XunitCategoryProperty]
        public string Reference { get; }
    }
}