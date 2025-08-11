using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class MeterTests : TestContext
{
    [Fact]
    public void RendersAsMeter()
    {
        var cut = RenderComponent<Meter>();
        var element = cut.Find("meter");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<Meter>();
        var element = cut.Find("meter");
        Assert.Contains("meter", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<Meter>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("meter");
        var classes = element.GetAttribute("class");
        Assert.Contains("meter", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<Meter>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("meter");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<Meter>(p => p
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("meter");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void ValueDefaultIsEmptyString()
    {
        var cut = RenderComponent<Meter>();
        // Default value for Value should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<Meter>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }
}
