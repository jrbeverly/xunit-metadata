using System;
using Xunit.Metadata.Common;
using Xunit.Metadata.Core;
using Xunit.Sdk;

namespace Xunit.Metadata.Scheduling
{
    /// <summary>
    /// Tests that will run in the nightly builds.
    /// </summary>
    [XunitCategory("Nightly")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public sealed partial class NightlyAttribute : Attribute, ITraitAttribute
    {
    }
}
