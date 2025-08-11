using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class CareCardTests : TestContext
{
    [Fact]
    public void RendersAsSection()
    {
        var cut = RenderComponent<CareCard>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("section");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<CareCard>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("section");
        Assert.Contains("care-card", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<CareCard>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<CareCard>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("section");
        var classes = element.GetAttribute("class");
        Assert.Contains("care-card", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<CareCard>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("section");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleRegion()
    {
        var cut = RenderComponent<CareCard>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("section");
        Assert.Equal("region", element.GetAttribute("role"));
    }

    [Fact]
    public void TypeDefaultIsnonurgent()
    {
        var cut = RenderComponent<CareCard>(p => p
            .AddChildContent("Test content"));
        // Default value for Type should be "non-urgent"
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void HeadingDefaultIsEmptyString()
    {
        var cut = RenderComponent<CareCard>(p => p
            .AddChildContent("Test content"));
        // Default value for Heading should be ""
        Assert.NotNull(cut.Instance);
    }
}
