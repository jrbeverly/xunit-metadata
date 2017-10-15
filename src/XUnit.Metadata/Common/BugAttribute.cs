using System;
using Xunit.Sdk;

namespace XUnit.Metadata.Common
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public partial class BugAttribute : Attribute, ITraitAttribute
    {
        public BugAttribute()
        {

        }
    }
}
