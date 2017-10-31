using System;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata.Scheduling
{
    /// <inheritdoc cref="ITraitAttribute" />
    /// <summary>Tests scheduled to run on the monthly build.</summary>
    [XunitCategory("Monthly")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public sealed partial class MonthlyAttribute : Attribute, ITraitAttribute
    {
    }
}