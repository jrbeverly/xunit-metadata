using System;
using Xunit.Metadata.Common;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata
{
    /// <summary>
    /// 
    /// </summary>
    [XunitCategory("Regression")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class RegressionAttribute : Attribute, ITraitAttribute
    {
        /// <summary>
        /// Associates the test with the identifier.
        /// </summary>
        /// <param name="reference">A reference identifier.</param>
        public RegressionAttribute(string reference = null)
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
