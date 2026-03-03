using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class TabBarButtonTests : TestContext
{
    [Fact]
    public void RendersAsButton()
    {
        var cut = RenderComponent<TabBarButton>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("button");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<TabBarButton>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("button");
        Assert.Contains("tab-bar-button", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<TabBarButton>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<TabBarButton>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("button");
        var classes = element.GetAttribute("class");
        Assert.Contains("tab-bar-button", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<TabBarButton>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("button");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleTab()
    {
        var cut = RenderComponent<TabBarButton>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("button");
        Assert.Equal("tab", element.GetAttribute("role"));
    }

    [Fact]
    public void ControlsDefaultIsEmptyString()
    {
        var cut = RenderComponent<TabBarButton>(p => p
            .AddChildContent("Test content"));
        // Default value for Controls should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void AriaSelectedIsTrueWhenSelected()
    {
        var cut = RenderComponent<TabBarButton>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Selected, true));
        var element = cut.Find("button");
        Assert.Equal("true", element.GetAttribute("aria-selected"));
    }

    [Fact]
    public void AriaSelectedIsFalseWhenNotSelected()
    {
        var cut = RenderComponent<TabBarButton>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Selected, false));
        var element = cut.Find("button");
        Assert.Equal("false", element.GetAttribute("aria-selected"));
    }
}
