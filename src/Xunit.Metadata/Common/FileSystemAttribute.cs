using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata.Common
{
    /// <inheritdoc cref="ITraitAttribute" />
    /// <summary>Access to the file system is a required for the test.</summary>
    [XunitCategory("FileSystem")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class FileSystemAttribute : Attribute, ITraitAttribute
    {
        /// <inheritdoc />
        /// <summary>Associates the test with the Filesystem category.</summary>
        /// <param name="reference">A reference identifier.</param>
        public FileSystemAttribute(string reference = null)
        {
            Reference = reference;
        }

        /// <summary>A reference identifier.</summary>
        [XunitCategoryProperty]
        public string Reference { get; }
    }
}