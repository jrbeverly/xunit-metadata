using System;
using System.Linq;
using System.Reflection;
using Xunit.Metadata.Discoverer;
using Xunit.Metadata.Management;
using Xunit.Sdk;

namespace Xunit.Metadata.Tests
{
    public sealed class DiscovererTests
    {
        [Theory]
        [InlineData(typeof(BugAttribute))]
        public void AttributeHasAttributes(Type attribute)
        {
            Assert.NotNull(attribute.GetCustomAttributes(false));
        }

        [Theory]
        [InlineData(typeof(BugAttribute))]
        public void AttributeHasTraitDiscoverer(Type attribute)
        {
            var attributes = attribute.GetCustomAttributes(false);
            Assert.NotEmpty(attributes.OfType<TraitDiscovererAttribute>());
        }

        [Theory]
        [InlineData(typeof(BugAttributeDiscoverer), typeof(BugAttribute))]
        public void BugDiscovererMatchesWithAttribute(Type expected, Type attribute)
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
