 

using System;
using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace XUnit.Metadata.Common
{
    [TraitDiscoverer("XUnit.Metadata.Discoverer.BugDiscoverer", "XUnit.Metadata")]
    public partial class BugAttribute : Attribute, ITraitAttribute
    {
    }
}

namespace XUnit.Metadata.Discoverer
{
    public sealed class BugDiscoverer : ITraitDiscoverer
    {
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
        {
            yield return new KeyValuePair<string, string>("Category", "Bug");
        }
    }
}