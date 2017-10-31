using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata.Common
{
    /// <summary>A category that marks tests that require an internet connection.</summary>
    [XunitCategory("Online")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class OnlineAttribute : Attribute, ITraitAttribute
    {
        /// <summary>Associates the test with the identifier.</summary>
        /// <param name="reference">A reference identifier.</param>
        public OnlineAttribute(string reference = null)
        {
            Reference = reference;
        }

        /// <summary>A reference identifier.</summary>
        [XunitProperty]
        public string Reference { get; }
    }
}