using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata.Common
{
    /// <inheritdoc cref="ITraitAttribute" />
    /// <summary>A database connection is required for the test.</summary>
    [XunitCategory("Database")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class DatabaseAttribute : Attribute, ITraitAttribute
    {
        /// <inheritdoc />
        /// <summary>Associates the test with the Database category.</summary>
        /// <param name="reference">A reference identifier.</param>
        public DatabaseAttribute(string reference = null)
        {
            Reference = reference;
        }

        /// <summary>A reference identifier.</summary>
        [XunitCategoryProperty]
        public string Reference { get; }
    }
}