using System;
using Xunit.Sdk;

namespace XUnit.Metadata.Common
{
    /// <summary>
    /// [PH]
    /// </summary>
    [XunitCategory("Bug")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class BugAttribute : Attribute, ITraitAttribute
    {
        public BugAttribute(string id = null)
        {
            Identifier = id;
        }

        [XunitProperty]
        public string Identifier { get; }
    }
}
