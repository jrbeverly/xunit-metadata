using System;
using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;


namespace XUnit.Metadata.Management
{
    [TraitDiscoverer("XUnit.Metadata.Discoverer.BugAttributeDiscoverer", "XUnit.Metadata")]
    public sealed partial class BugAttribute : Attribute, ITraitAttribute
    {
    }
}

namespace XUnit.Metadata.Discoverer
{
	/// <inheritdoc/>
    /// <summary>
    /// Implements a 
    /// </summary>
    public sealed class BugAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc/>
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Bug");
			var trait_Reference = trait.GetNamedArgument<string>("Reference");
			if (trait_Reference != null) 
			{
				yield return new KeyValuePair<string, string>("Bug", trait_Reference);
			}
        }
    }
}

