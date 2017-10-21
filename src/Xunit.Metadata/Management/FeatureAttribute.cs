using System;
using Xunit.Metadata.Common;
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
        /// Associates with the test with the Story category.
        /// </summary>
        public FeatureAttribute()
        {
            Namespace = null;
            Id = null;
        }

        /// <summary>
        /// Associates with the test the specified string.
        /// </summary>
        /// <param name="name">The namespace of the user story.</param>
        public FeatureAttribute(string name)
        {
            Namespace = name;
            Id = null;
        }

        /// <summary>
        /// Associates with the test the specified name and id pair.
        /// </summary>
        /// <param name="name">The namespace of the user story.</param>
        /// <param name="id">The user story identifier.</param>
        public FeatureAttribute(string name, int id)
        {
            Namespace = name;
            Id = id.ToString();
        }

        /// <summary>
        /// The namespace of the user story.
        /// </summary>
        public string Namespace { get; }

        /// <summary>
        /// The user story identifier.
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