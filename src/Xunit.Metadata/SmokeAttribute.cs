using System;
using Xunit.Metadata.Common;
using Xunit.Sdk;

namespace Xunit.Metadata
{
    /// <summary>
    /// Verifies that essential defects do not exist.
    /// </summary>
    [XunitCategory("Smoke")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class SmokeAttribute : Attribute, ITraitAttribute
    {
        /// <summary>
        /// Associates the test with the identifier.
        /// </summary>
        /// <param name="reference">A reference identifier.</param>
        public SmokeAttribute(string reference = null)
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
