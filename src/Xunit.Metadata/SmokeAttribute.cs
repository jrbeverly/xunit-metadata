using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata
{
    /// <inheritdoc cref="ITraitAttribute" />
    /// <summary>Initial testing to check whether the software is stable.</summary>
    [XunitCategory("Smoke")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class SmokeAttribute : Attribute, ITraitAttribute
    {
        /// <inheritdoc />
        /// <summary>Associates the test with the Smoke category and optional reference.</summary>
        /// <param name="reference">A reference identifier.</param>
        public SmokeAttribute(string reference = null)
        {
            Reference = reference;
        }

        /// <summary>A reference identifier.</summary>
        [XunitCategoryProperty]
        public string Reference { get; }
    }
}