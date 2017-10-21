using System;
using Xunit.Metadata.Common;
using Xunit.Sdk;

namespace Xunit.Metadata.Management
{
    /// <summary>
    /// A generic issue type, as defined by your organization.
    /// </summary>
    [XunitCategory("Issue")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class IssueAttribute : Attribute, ITraitAttribute
    {
        /// <summary>
        /// Associates with the test with the Story category.
        /// </summary>
        public IssueAttribute()
        {
            Namespace = null;
            Id = null;
        }

        /// <summary>
        /// Associates with the test the specified string.
        /// </summary>
        /// <param name="name">The namespace of the user story.</param>
        public IssueAttribute(string name)
        {
            Namespace = name;
            Id = null;
        }

        /// <summary>
        /// Associates with the test the specified name and id pair.
        /// </summary>
        /// <param name="name">The namespace of the user story.</param>
        /// <param name="id">The user story identifier.</param>
        public IssueAttribute(string name, int id)
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