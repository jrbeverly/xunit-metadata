using System;
using Xunit.Metadata.Common;
using Xunit.Sdk;

namespace Xunit.Metadata
{
    /// <summary>
    /// 
    /// </summary>
    [XunitCategory("Stress")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class StressAttribute : Attribute, ITraitAttribute
    {
        /// <summary>
        /// Associates with the test the specified bug.
        /// </summary>
        /// <param name="reference">A reference to a bug.</param>
        public StressAttribute(string reference = null)
        {
            Reference = reference;
        }

        /// <summary>
        /// The reference to the bug.
        /// </summary>
        [XunitProperty]
        public string Reference { get; }
    }
}
