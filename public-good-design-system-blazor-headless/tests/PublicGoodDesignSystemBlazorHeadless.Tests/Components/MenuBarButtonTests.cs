using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class MenuBarButtonTests : TestContext
{
    [Fact]
    public void RendersAsButton()
    {
        var cut = RenderComponent<MenuBarButton>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("button");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<MenuBarButton>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("button");
        Assert.Contains("menu-bar-button", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<MenuBarButton>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<MenuBarButton>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("button");
        var classes = element.GetAttribute("class");
        Assert.Contains("menu-bar-button", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<MenuBarButton>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("button");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleMenuitem()
    {
        var cut = RenderComponent<MenuBarButton>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("button");
        Assert.Equal("menuitem", element.GetAttribute("role"));
    }
}
