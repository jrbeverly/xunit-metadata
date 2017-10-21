﻿using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Xunit.Metadata.Management
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
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.Management.BugAttribute"/> class.
    /// </summary>
    public sealed class BugAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Bug");
			var traitNamespace = trait.GetNamedArgument<string>("Namespace");
			if (!String.IsNullOrEmpty(traitNamespace)) 
				yield return new KeyValuePair<string, string>("Bug", traitNamespace);
			var traitId = trait.GetNamedArgument<string>("Id");
			if (!String.IsNullOrEmpty(traitId)) 
				yield return new KeyValuePair<string, string>("Bug", traitId);
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!String.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Bug", traitReference);
        }
    }
}
namespace Xunit.Metadata.Management
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.EpicAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class EpicAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.Management.EpicAttribute"/> class.
    /// </summary>
    public sealed class EpicAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Epic");
			var traitNamespace = trait.GetNamedArgument<string>("Namespace");
			if (!String.IsNullOrEmpty(traitNamespace)) 
				yield return new KeyValuePair<string, string>("Epic", traitNamespace);
			var traitId = trait.GetNamedArgument<string>("Id");
			if (!String.IsNullOrEmpty(traitId)) 
				yield return new KeyValuePair<string, string>("Epic", traitId);
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!String.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Epic", traitReference);
        }
    }
}
namespace Xunit.Metadata.Management
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.FeatureAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class FeatureAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.Management.FeatureAttribute"/> class.
    /// </summary>
    public sealed class FeatureAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Feature");
			var traitNamespace = trait.GetNamedArgument<string>("Namespace");
			if (!String.IsNullOrEmpty(traitNamespace)) 
				yield return new KeyValuePair<string, string>("Feature", traitNamespace);
			var traitId = trait.GetNamedArgument<string>("Id");
			if (!String.IsNullOrEmpty(traitId)) 
				yield return new KeyValuePair<string, string>("Feature", traitId);
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!String.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Feature", traitReference);
        }
    }
}
namespace Xunit.Metadata.Management
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.ImprovementAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class ImprovementAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.Management.ImprovementAttribute"/> class.
    /// </summary>
    public sealed class ImprovementAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Improvement");
			var traitNamespace = trait.GetNamedArgument<string>("Namespace");
			if (!String.IsNullOrEmpty(traitNamespace)) 
				yield return new KeyValuePair<string, string>("Improvement", traitNamespace);
			var traitId = trait.GetNamedArgument<string>("Id");
			if (!String.IsNullOrEmpty(traitId)) 
				yield return new KeyValuePair<string, string>("Improvement", traitId);
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!String.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Improvement", traitReference);
        }
    }
}
namespace Xunit.Metadata.Management
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.IssueAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class IssueAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.Management.IssueAttribute"/> class.
    /// </summary>
    public sealed class IssueAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Issue");
			var traitNamespace = trait.GetNamedArgument<string>("Namespace");
			if (!String.IsNullOrEmpty(traitNamespace)) 
				yield return new KeyValuePair<string, string>("Issue", traitNamespace);
			var traitId = trait.GetNamedArgument<string>("Id");
			if (!String.IsNullOrEmpty(traitId)) 
				yield return new KeyValuePair<string, string>("Issue", traitId);
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!String.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Issue", traitReference);
        }
    }
}
namespace Xunit.Metadata.Management
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.StoryAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class StoryAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.Management.StoryAttribute"/> class.
    /// </summary>
    public sealed class StoryAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Story");
			var traitNamespace = trait.GetNamedArgument<string>("Namespace");
			if (!String.IsNullOrEmpty(traitNamespace)) 
				yield return new KeyValuePair<string, string>("Story", traitNamespace);
			var traitId = trait.GetNamedArgument<string>("Id");
			if (!String.IsNullOrEmpty(traitId)) 
				yield return new KeyValuePair<string, string>("Story", traitId);
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!String.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Story", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.AcceptanceAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class AcceptanceAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.AcceptanceAttribute"/> class.
    /// </summary>
    public sealed class AcceptanceAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Acceptance");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!String.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Acceptance", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.FunctionalAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class FunctionalAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.FunctionalAttribute"/> class.
    /// </summary>
    public sealed class FunctionalAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Functional");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!String.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Functional", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.IntegrationAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class IntegrationAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.IntegrationAttribute"/> class.
    /// </summary>
    public sealed class IntegrationAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Integration");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!String.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Integration", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.PerformanceAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class PerformanceAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.PerformanceAttribute"/> class.
    /// </summary>
    public sealed class PerformanceAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Performance");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!String.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Performance", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.RegressionAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class RegressionAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.RegressionAttribute"/> class.
    /// </summary>
    public sealed class RegressionAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Regression");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!String.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Regression", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.SmokeAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class SmokeAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.SmokeAttribute"/> class.
    /// </summary>
    public sealed class SmokeAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Smoke");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!String.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Smoke", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.StressAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class StressAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.StressAttribute"/> class.
    /// </summary>
    public sealed class StressAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Stress");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!String.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Stress", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.SystemAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class SystemAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.SystemAttribute"/> class.
    /// </summary>
    public sealed class SystemAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "System");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!String.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("System", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.UnitAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class UnitAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.UnitAttribute"/> class.
    /// </summary>
    public sealed class UnitAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Unit");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!String.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Unit", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.UsabilityAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class UsabilityAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.UsabilityAttribute"/> class.
    /// </summary>
    public sealed class UsabilityAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Usability");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!String.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Usability", traitReference);
        }
    }
}
