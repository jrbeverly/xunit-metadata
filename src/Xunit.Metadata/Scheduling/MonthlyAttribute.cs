using System;
using Xunit.Metadata.Common;
using Xunit.Sdk;

namespace Xunit.Metadata.Scheduling
{
    /// <summary>
    /// Tests that will run in the nightly builds.
    /// </summary>
    [XunitCategory("Monthly")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class MonthlyAttribute : Attribute, ITraitAttribute
    {
    }
}
