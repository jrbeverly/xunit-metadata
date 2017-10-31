using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata.Management
{
    /// <summary>A problem which impairs or prevents the functions of the product.</summary>
    [XunitCategory("Bug")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class BugAttribute : Attribute, ITraitAttribute
    {
        /// <summary>Associates the test with the Bug category.</summary>
        public BugAttribute()
        {
            Namespace = null;
            Id = null;
        }

        /// <summary>Associates the test with the specified string.</summary>
        /// <param name="name">A string identifier.</param>
        public BugAttribute(string name)
        {
            Namespace = name;
            Id = null;
        }

        /// <summary>Associates with the test the specified namespace and id.</summary>
        /// <param name="name">The namespace of the category.</param>
        /// <param name="id">A numeric identifier.</param>
        public BugAttribute(string name, int id)
        {
            Namespace = name;
            Id = id.ToString();
        }

        /// <summary>The namespace of the attribute.</summary>
        public string Namespace { get; }

        /// <summary>The numeric identifier.</summary>
        public string Id { get; }

        /// <summary>A reference identifier.</summary>
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