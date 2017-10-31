using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata.Scheduling
{
    /// <inheritdoc cref="ITraitAttribute" />
    /// <summary>Tests scheduled to run on the nightly build.</summary>
    [XunitCategory("Nightly")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public sealed partial class NightlyAttribute : Attribute, ITraitAttribute
    {
    }
}