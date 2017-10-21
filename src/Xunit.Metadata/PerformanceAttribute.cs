using System;
using Xunit.Metadata.Common;
using Xunit.Sdk;

namespace Xunit.Metadata
{
    /// <summary>
    /// Verifies that the system meets performance requirements.
    /// </summary>
    [XunitCategory("Performance")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class PerformanceAttribute : Attribute, ITraitAttribute
    {
        /// <summary>
        /// Associates the test with the identifier.
        /// </summary>
        /// <param name="reference">A reference identifier.</param>
        public PerformanceAttribute(string reference = null)
        {
            Reference = reference;
        }

        /// <summary>
        /// A reference identifier.
        /// </summary>
        [XunitProperty]
        public string Reference { get; }
    }
}
