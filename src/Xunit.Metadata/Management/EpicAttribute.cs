using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata.Management
{
    /// <inheritdoc cref="ITraitAttribute" />
    /// <summary>An epic is a large body of work that can be broken down into a number of smaller stories.</summary>
    [XunitCategory("Epic")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class EpicAttribute : Attribute, ITraitAttribute
    {
        /// <inheritdoc />
        /// <summary>Associates the test with the Epic category.</summary>
        public EpicAttribute()
        {
            Key = null;
            Id = null;
        }

        /// <inheritdoc />
        /// <summary>Associates the test with the Epic category and namespace.</summary>
        /// <param name="key">The issue namespace.</param>
        public EpicAttribute(string key)
        {
            Key = key ?? throw new ArgumentNullException(nameof(key));
            Id = null;
        }

        /// <inheritdoc />
        /// <summary>Associates the test with the Epic category for the specified namespace and issue id.</summary>
        /// <param name="key">The issue namespace.</param>
        /// <param name="id">A numeric identifier.</param>
        public EpicAttribute(string key, int id)
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