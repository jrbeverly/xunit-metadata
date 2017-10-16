 
 
using System;
using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;


namespace XUnit.Metadata.Common
{
    [TraitDiscoverer("XUnit.Metadata.Discoverer.BugAttributeDiscoverer", "XUnit.Metadata")]
    public sealed partial class BugAttribute : Attribute, ITraitAttribute
    {
    }
}

namespace XUnit.Metadata.Discoverer
{
    /// <summary>
    /// [PH]
    /// </summary>
    public sealed class BugAttributeDiscoverer : ITraitDiscoverer
    {
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Bug");
			var trait_Identifier = trait.GetNamedArgument<string>("Identifier");
			if (trait_Identifier != null) 
			{
				yield return new KeyValuePair<string, string>("Bug", trait_Identifier);
			}
        }
    }
}

