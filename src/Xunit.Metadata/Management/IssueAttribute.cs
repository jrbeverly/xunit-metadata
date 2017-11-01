using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata.Management
{
    /// <inheritdoc cref="ITraitAttribute" />
    /// <summary>A generic issue type, as defined by your organization.</summary>
    [XunitCategory("Issue")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class IssueAttribute : Attribute, ITraitAttribute
    {
        /// <inheritdoc />
        /// <summary>Associates the test with the Issue category.</summary>
        public IssueAttribute()
        {
            Key = null;
            Id = null;
        }

        /// <inheritdoc />
        /// <summary>Associates the test with the Issue category and namespace.</summary>
        /// <param name="key">The issue namespace.</param>
        public IssueAttribute(string key)
        {
            Key = key ?? throw new ArgumentNullException(nameof(key));
            Id = null;
        }

        /// <inheritdoc />
        /// <summary>Associates the test with the Issue category for the specified namespace and issue id.</summary>
        /// <param name="key">The issue namespace.</param>
        /// <param name="id">A numeric identifier.</param>
        public IssueAttribute(string key, int id)
        {
            Key = key ?? throw new ArgumentNullException(nameof(key));
            Id = Convert.ToString(id);
        }

        /// <summary>The issue namespace.</summary>
        [XunitCategoryProperty]
        public string Key { get; }

        /// <summary>The numeric identifier of the issue.</summary>
        public string Id { get; }

        /// <summary>A reference identifier.</summary>
        [XunitCategoryProperty]
        public string Reference
        {
            get
            {
                var value = string.Join(" ", Key, Id).Trim();
                return value == string.Empty ? null : value;
            }
        }
    }
}