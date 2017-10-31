using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata.Management
{
    /// <summary>An epic is a large body of work that can be broken down into a number of smaller stories.</summary>
    [XunitCategory("Epic")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class EpicAttribute : Attribute, ITraitAttribute
    {
        /// <summary>Associates the test with the Epic category.</summary>
        public EpicAttribute()
        {
            Namespace = null;
            Id = null;
        }

        /// <summary>Associates the test with the specified string.</summary>
        /// <param name="name">A string identifier.</param>
        public EpicAttribute(string name)
        {
            Namespace = name;
            Id = null;
        }

        /// <summary>Associates with the test the specified namespace and id.</summary>
        /// <param name="name">The namespace of the category.</param>
        /// <param name="id">A numeric identifier.</param>
        public EpicAttribute(string name, int id)
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