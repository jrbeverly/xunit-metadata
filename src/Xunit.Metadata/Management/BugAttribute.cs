using System;
using Xunit.Metadata.Common;
using Xunit.Sdk;

namespace Xunit.Metadata.Management
{
    /// <summary>
    /// A problem which impairs or prevents the functions of the product.
    /// </summary>
    /// <remarks>
    /// Allows the referencing of a bug in an issue tracking system.
    /// </remarks>
    [XunitCategory("Bug")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class BugAttribute : Attribute, ITraitAttribute
    {
        /// <summary>
        /// Associates with the test the specified bug.
        /// </summary>
        /// <param name="reference">A reference to a bug.</param>
        public BugAttribute(string reference = null)
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