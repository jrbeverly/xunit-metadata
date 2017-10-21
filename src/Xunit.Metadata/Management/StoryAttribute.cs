using System;
using Xunit.Metadata.Common;
using Xunit.Sdk;

namespace Xunit.Metadata.Management
{
    /// <summary>
    /// User stories are short, simple descriptions of a feature told from the perspective of the person.
    /// </summary>
    [XunitCategory("Story")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class StoryAttribute : Attribute, ITraitAttribute
    {
        /// <summary>
        /// Associates the test with the Story category.
        /// </summary>
        public StoryAttribute()
        {
            Namespace = null;
            Id = null;
        }

        /// <summary>
        /// Associates the test with the specified string.
        /// </summary>
        /// <param name="name">A string identifier.</param>
        public StoryAttribute(string name)
        {
            Namespace = name;
            Id = null;
        }

        /// <summary>
        /// Associates with the test the specified namespace and id.
        /// </summary>
        /// <param name="name">The namespace of the category.</param>
        /// <param name="id">A numeric identifier.</param>
        public StoryAttribute(string name, int id)
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