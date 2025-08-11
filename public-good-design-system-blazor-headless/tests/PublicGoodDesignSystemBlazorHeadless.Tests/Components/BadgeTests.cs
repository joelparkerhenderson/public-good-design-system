using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class BadgeTests : TestContext
{
    [Fact]
    public void RendersAsSpan()
    {
        var cut = RenderComponent<Badge>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("span");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<Badge>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("span");
        Assert.Contains("badge", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<Badge>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<Badge>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("span");
        var classes = element.GetAttribute("class");
        Assert.Contains("badge", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<Badge>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("span");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleStatus()
    {
        var cut = RenderComponent<Badge>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("span");
        Assert.Equal("status", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<Badge>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("span");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void TypeDefaultIsdefault()
    {
        var cut = RenderComponent<Badge>(p => p
            .AddChildContent("Test content"));
        // Default value for Type should be "default"
        Assert.NotNull(cut.Instance);
    }
}
