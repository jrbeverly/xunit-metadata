using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata
{
    /// <inheritdoc cref="ITraitAttribute" />
    /// <summary>System is assessed in terms of responsiveness and stability under various workloads.</summary>
    [XunitCategory("Performance")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class PerformanceAttribute : Attribute, ITraitAttribute
    {
        /// <inheritdoc />
        /// <summary>Associates the test with the Performance category and optional reference.</summary>
        /// <param name="reference">A reference identifier.</param>
        public PerformanceAttribute(string reference = null)
        {
            Reference = reference;
        }

        /// <summary>A reference identifier.</summary>
        [XunitCategoryProperty]
        public string Reference { get; }
    }
}