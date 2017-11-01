using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Xunit.Metadata.Common
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.DatabaseAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class DatabaseAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.Common.DatabaseAttribute"/> class.
    /// </summary>
    public sealed class DatabaseAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Database");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Database", traitReference);
        }
    }
}
namespace Xunit.Metadata.Common
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.ExternalDependencyAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class ExternalDependencyAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.Common.ExternalDependencyAttribute"/> class.
    /// </summary>
    public sealed class ExternalDependencyAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "External Dependency");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("External Dependency", traitReference);
        }
    }
}
namespace Xunit.Metadata.Common
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.FileSystemAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class FileSystemAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.Common.FileSystemAttribute"/> class.
    /// </summary>
    public sealed class FileSystemAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "FileSystem");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("FileSystem", traitReference);
        }
    }
}
namespace Xunit.Metadata.Common
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.OnlineAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class OnlineAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.Common.OnlineAttribute"/> class.
    /// </summary>
    public sealed class OnlineAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Online");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Online", traitReference);
        }
    }
}
namespace Xunit.Metadata.Common
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.SecurityAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class SecurityAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.Common.SecurityAttribute"/> class.
    /// </summary>
    public sealed class SecurityAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Security");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Security", traitReference);
        }
    }
}
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
			var traitKey = trait.GetNamedArgument<string>("Key");
			if (!string.IsNullOrEmpty(traitKey)) 
				yield return new KeyValuePair<string, string>("Bug", traitKey);
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
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
			var traitKey = trait.GetNamedArgument<string>("Key");
			if (!string.IsNullOrEmpty(traitKey)) 
				yield return new KeyValuePair<string, string>("Epic", traitKey);
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
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
			var traitKey = trait.GetNamedArgument<string>("Key");
			if (!string.IsNullOrEmpty(traitKey)) 
				yield return new KeyValuePair<string, string>("Feature", traitKey);
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
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
			var traitKey = trait.GetNamedArgument<string>("Key");
			if (!string.IsNullOrEmpty(traitKey)) 
				yield return new KeyValuePair<string, string>("Improvement", traitKey);
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
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
			var traitKey = trait.GetNamedArgument<string>("Key");
			if (!string.IsNullOrEmpty(traitKey)) 
				yield return new KeyValuePair<string, string>("Issue", traitKey);
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
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
			var traitKey = trait.GetNamedArgument<string>("Key");
			if (!string.IsNullOrEmpty(traitKey)) 
				yield return new KeyValuePair<string, string>("Story", traitKey);
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Story", traitReference);
        }
    }
}
namespace Xunit.Metadata.Scheduling
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.MonthlyAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class MonthlyAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.Scheduling.MonthlyAttribute"/> class.
    /// </summary>
    public sealed class MonthlyAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Monthly");
        }
    }
}
namespace Xunit.Metadata.Scheduling
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.NightlyAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class NightlyAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.Scheduling.NightlyAttribute"/> class.
    /// </summary>
    public sealed class NightlyAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Nightly");
        }
    }
}
namespace Xunit.Metadata.Scheduling
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.WeeklyAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class WeeklyAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.Scheduling.WeeklyAttribute"/> class.
    /// </summary>
    public sealed class WeeklyAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Weekly");
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
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Acceptance", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.BenchmarkAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class BenchmarkAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.BenchmarkAttribute"/> class.
    /// </summary>
    public sealed class BenchmarkAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Benchmark");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Benchmark", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.DisasterRecoveryAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class DisasterRecoveryAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.DisasterRecoveryAttribute"/> class.
    /// </summary>
    public sealed class DisasterRecoveryAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Recovery");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Recovery", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.FailoverAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class FailoverAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.FailoverAttribute"/> class.
    /// </summary>
    public sealed class FailoverAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Failover");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Failover", traitReference);
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
			if (!string.IsNullOrEmpty(traitReference)) 
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
			if (!string.IsNullOrEmpty(traitReference)) 
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
			if (!string.IsNullOrEmpty(traitReference)) 
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
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Regression", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.ReliabilityAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class ReliabilityAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.ReliabilityAttribute"/> class.
    /// </summary>
    public sealed class ReliabilityAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Reliability");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Reliability", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.SanityAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class SanityAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.SanityAttribute"/> class.
    /// </summary>
    public sealed class SanityAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Sanity");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Sanity", traitReference);
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
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Smoke", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.SoakAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class SoakAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.SoakAttribute"/> class.
    /// </summary>
    public sealed class SoakAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Soak");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Soak", traitReference);
        }
    }
}
namespace Xunit.Metadata
{
    [TraitDiscoverer("Xunit.Metadata.Discoverer.SpikeAttributeDiscoverer", "Xunit.Metadata")]
    public sealed partial class SpikeAttribute
    {
    }
}

namespace Xunit.Metadata.Discoverer
{
    /// <inheritdoc />
    /// <summary>
    /// An implementation of <see cref="ITraitDiscoverer"/> for the <see cref="Xunit.Metadata.SpikeAttribute"/> class.
    /// </summary>
    public sealed class SpikeAttributeDiscoverer : ITraitDiscoverer
    {
		/// <inheritdoc />
        public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo trait)
        {
            yield return new KeyValuePair<string, string>("Category", "Spike");
			var traitReference = trait.GetNamedArgument<string>("Reference");
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Spike", traitReference);
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
			if (!string.IsNullOrEmpty(traitReference)) 
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
			if (!string.IsNullOrEmpty(traitReference)) 
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
			if (!string.IsNullOrEmpty(traitReference)) 
				yield return new KeyValuePair<string, string>("Unit", traitReference);
        }
    }
}
