using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata
{
    /// <summary>Verifies if system meets the product requirements.</summary>
    [XunitCategory("Acceptance")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class AcceptanceAttribute : Attribute, ITraitAttribute
    {
        /// <summary>Associates the test with the identifier.</summary>
        /// <param name="reference">A reference identifier.</param>
        public AcceptanceAttribute(string reference = null)
        {
            Reference = reference;
        }

        /// <summary>A reference identifier.</summary>
        [XunitProperty]
        public string Reference { get; }
    }
}