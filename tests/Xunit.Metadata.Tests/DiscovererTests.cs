using System;
using System.Linq;
using System.Reflection;
using Xunit.Metadata.Discoverer;
using Xunit.Metadata.Management;
using Xunit.Metadata.Scheduling;
using Xunit.Sdk;

namespace Xunit.Metadata.Tests
{
    public sealed class DiscovererTests
    {
        [Theory]
        [Unit]
        [InlineData(typeof(MonthlyAttribute))]
        [InlineData(typeof(NightlyAttribute))]
        [InlineData(typeof(WeeklyAttribute))]
        [InlineData(typeof(BugAttribute))]
        [InlineData(typeof(EpicAttribute))]
        [InlineData(typeof(FeatureAttribute))]
        [InlineData(typeof(ImprovementAttribute))]
        [InlineData(typeof(IssueAttribute))]
        [InlineData(typeof(StoryAttribute))]
        [InlineData(typeof(AcceptanceAttribute))]
        [InlineData(typeof(FunctionalAttribute))]
        [InlineData(typeof(IntegrationAttribute))]
        [InlineData(typeof(PerformanceAttribute))]
        [InlineData(typeof(RegressionAttribute))]
        [InlineData(typeof(SmokeAttribute))]
        [InlineData(typeof(StressAttribute))]
        [InlineData(typeof(SystemAttribute))]
        [InlineData(typeof(UnitAttribute))]
        public void AttributeHasAttributes(Type attribute)
        {
            Assert.NotNull(attribute.GetCustomAttributes(false));
        }

        [Theory]
        [Unit]
        [InlineData(typeof(MonthlyAttribute))]
        [InlineData(typeof(NightlyAttribute))]
        [InlineData(typeof(WeeklyAttribute))]
        [InlineData(typeof(BugAttribute))]
        [InlineData(typeof(EpicAttribute))]
        [InlineData(typeof(FeatureAttribute))]
        [InlineData(typeof(ImprovementAttribute))]
        [InlineData(typeof(IssueAttribute))]
        [InlineData(typeof(StoryAttribute))]
        [InlineData(typeof(AcceptanceAttribute))]
        [InlineData(typeof(FunctionalAttribute))]
        [InlineData(typeof(IntegrationAttribute))]
        [InlineData(typeof(PerformanceAttribute))]
        [InlineData(typeof(RegressionAttribute))]
        [InlineData(typeof(SmokeAttribute))]
        [InlineData(typeof(StressAttribute))]
        [InlineData(typeof(SystemAttribute))]
        [InlineData(typeof(UnitAttribute))]
        public void AttributeHasTraitDiscoverer(Type attribute)
        {
            var attributes = attribute.GetCustomAttributes(false);
            Assert.NotEmpty(attributes.OfType<TraitDiscovererAttribute>());
        }

        [Theory]
        [Unit]
        [InlineData(typeof(MonthlyAttributeDiscoverer), typeof(MonthlyAttribute))]
        [InlineData(typeof(NightlyAttributeDiscoverer), typeof(NightlyAttribute))]
        [InlineData(typeof(WeeklyAttributeDiscoverer), typeof(WeeklyAttribute))]
        [InlineData(typeof(BugAttributeDiscoverer), typeof(BugAttribute))]
        [InlineData(typeof(EpicAttributeDiscoverer), typeof(EpicAttribute))]
        [InlineData(typeof(FeatureAttributeDiscoverer), typeof(FeatureAttribute))]
        [InlineData(typeof(ImprovementAttributeDiscoverer), typeof(ImprovementAttribute))]
        [InlineData(typeof(IssueAttributeDiscoverer), typeof(IssueAttribute))]
        [InlineData(typeof(StoryAttributeDiscoverer), typeof(StoryAttribute))]
        [InlineData(typeof(AcceptanceAttributeDiscoverer), typeof(AcceptanceAttribute))]
        [InlineData(typeof(FunctionalAttributeDiscoverer), typeof(FunctionalAttribute))]
        [InlineData(typeof(IntegrationAttributeDiscoverer), typeof(IntegrationAttribute))]
        [InlineData(typeof(PerformanceAttributeDiscoverer), typeof(PerformanceAttribute))]
        [InlineData(typeof(RegressionAttributeDiscoverer), typeof(RegressionAttribute))]
        [InlineData(typeof(SmokeAttributeDiscoverer), typeof(SmokeAttribute))]
        [InlineData(typeof(StressAttributeDiscoverer), typeof(StressAttribute))]
        [InlineData(typeof(SystemAttributeDiscoverer), typeof(SystemAttribute))]
        [InlineData(typeof(UnitAttributeDiscoverer), typeof(UnitAttribute))]
        public void DiscovererMatchesWithAttribute(Type expected, Type attribute)
        {
            var data = CustomAttributeData.GetCustomAttributes(attribute).Where(p => p.AttributeType == typeof(TraitDiscovererAttribute)).ToArray();
            Assert.Single(data);

            var trait = data[0];
            Assert.Equal(2, trait.ConstructorArguments.Count);
            
            var typeName = trait.ConstructorArguments[0].Value;
            var assemblyName = trait.ConstructorArguments[1].Value;
            Assert.Equal(expected.FullName, typeName);
            Assert.Equal(expected.Assembly.GetName().Name, assemblyName);
        }
    }
}
