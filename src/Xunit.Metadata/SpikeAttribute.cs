using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata
{
    /// <inheritdoc cref="ITraitAttribute" />
    /// <summary>System experiences a bursts of activity with varying degrees of load.</summary>
    [XunitCategory("Spike")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class SpikeAttribute : Attribute, ITraitAttribute
    {
        /// <inheritdoc />
        /// <summary>Associates the test with the Spike category and optional reference.</summary>
        /// <param name="reference">A reference identifier.</param>
        public SpikeAttribute(string reference = null)
        {
            Reference = reference;
        }

        /// <summary>A reference identifier.</summary>
        [XunitCategoryProperty]
        public string Reference { get; }
    }
}