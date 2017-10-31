using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata.Scheduling
{
    /// <inheritdoc cref="ITraitAttribute" />
    /// <summary>Tests scheduled to run on the weekly build.</summary>
    [XunitCategory("Weekly")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public sealed partial class WeeklyAttribute : Attribute, ITraitAttribute
    {
    }
}