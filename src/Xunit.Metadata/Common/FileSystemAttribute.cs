using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata.Common
{
    /// <summary>Verifies if system meets the product requirements.</summary>
    [XunitCategory("FileSystem")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class FileSystemAttribute : Attribute, ITraitAttribute
    {
        /// <summary>Associates the test with the identifier.</summary>
        /// <param name="reference">A reference identifier.</param>
        public FileSystemAttribute(string reference = null)
        {
            Reference = reference;
        }

        /// <summary>A reference identifier.</summary>
        [XunitProperty]
        public string Reference { get; }
    }
}