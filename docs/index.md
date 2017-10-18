# 
<h1 align="center">
    <img alt="Xunit.Metadata" src="icon/icon.png" width="200px" height="200px" />
    <br /> Xunit.Metadata
</h1>

<p align="center">
    Strongly-typed attributes for the management and organization of tests.
</p>
<div align="center">
    <a href="https://gitlab.com/jrbeverly/Xunit.Metadata/commits/master"><img alt="pipeline status" src="https://gitlab.com/jrbeverly/Xunit.Metadata/badges/master/pipeline.svg" /></a>
    <a href="LICENSE"><img alt="license" src="https://img.shields.io/badge/license-MIT-blue.svg" /></a>
    <a href="https://gitlab.com/jrbeverly/Xunit.Metadata"><img alt="repository" src="https://img.shields.io/badge/gitlab-Xunit.Metadata-red.svg" /></a>
</div>
<br />

---

## Summary

Strongly-typed attributes for the management and organization of tests. As opposed to using strings throughout the code, `[Trait("Category", "Unit")]`, you can use strongly-typed attributes for organizing tests.

### Usage

You can use the just as you would a [`TraitAttribute`](https://xunit.github.io/docs/comparisons.html) from xUnit v2.

```csharp
[Fact]
[Unit]
[Nighty]
public void ExceptionWhenDivideByZero()
{
    var value = 10;
    Assert.Throws<ArgumentException>(() => _adder.Divide(value, 0));
}
```

Or as a class method

```csharp
[Unit]
public sealed class AdderTests
{
    [Theory]
    [Nighty]
    [InlineData(3, 1, 2)]
    [InlineData(4, 2, 2)]
    [InlineData(1, 1, 0)]
    [InlineData(0, -2, 2)]
    public void AddSet(int expected, int a, int b)
    {
        Assert.Equal(expected, _adder.Add(a, b));
    }

    [Fact]
    public void ExceptionWhenDivideByZero()
    {
        var value = 10;
        Assert.Throws<ArgumentException>(() => _adder.Divide(value, 0));
    }
}
```

## Acknowledgements

The project icon is by [Ana Paula Tello from the Noun Project](docs/icon/README.md).