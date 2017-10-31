using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata
{
    /// <summary>Verifies if system meets the product requirements.</summary>
    [XunitCategory("Sanity")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class SanityAttribute : Attribute, ITraitAttribute
    {
        /// <summary>Associates the test with the identifier.</summary>
        /// <param name="reference">A reference identifier.</param>
        public SanityAttribute(string reference = null)
        {
            Reference = reference;
        }

        /// <summary>A reference identifier.</summary>
        [XunitProperty]
        public string Reference { get; }
    }
}