using System;
using Xunit.Metadata.Common;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata.Management
{
    /// <summary>
    /// A new feature of the product.
    /// </summary>
    [XunitCategory("Feature")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class FeatureAttribute : Attribute, ITraitAttribute
    {
        /// <summary>
        /// Associates the test with the Feature category.
        /// </summary>
        public FeatureAttribute()
        {
            Namespace = null;
            Id = null;
        }

        /// <summary>
        /// Associates the test with the specified string.
        /// </summary>
        /// <param name="name">A string identifier.</param>
        public FeatureAttribute(string name)
        {
            Namespace = name;
            Id = null;
        }

        /// <summary>
        /// Associates with the test the specified namespace and id.
        /// </summary>
        /// <param name="name">The namespace of the category.</param>
        /// <param name="id">A numeric identifier.</param>
        public FeatureAttribute(string name, int id)
        {
            Namespace = name;
            Id = id.ToString();
        }

        /// <summary>
        /// The namespace of the attribute.
        /// </summary>
        public string Namespace { get; }

        /// <summary>
        /// The numeric identifier.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// A reference identifier.
        /// </summary>
        [XunitProperty]
        public string Reference
        {
            get
            {
                var value = string.Join(" ", Namespace, Id).Trim();
                return value == string.Empty ? null : value;
            }
        }
    }
}