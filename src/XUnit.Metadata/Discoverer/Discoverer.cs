using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace XUnit.Metadata.Management
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.BugAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class BugAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// Implements a
    /// </summary>
    public sealed class BugAttributeDiscoverer : ITraitDiscoverer
    {
        /// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Bug");
            var traitReference = trait.GetNamedArgument<string>("Reference");
            if (traitReference != null)
                yield return new KeyValuePair<string, string>("Bug", traitReference);
        }
    }
}