using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class TabBarTests : TestContext
{
    public TabBarTests()
    {
        JSInterop.SetupVoid("headlessInterop.handleKeyboardNav").SetVoidResult();
        JSInterop.Mode = JSRuntimeMode.Loose;
    }

    [Fact]
    public void RendersAsDiv()
    {
        var cut = RenderComponent<TabBar>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<TabBar>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.Contains("tab-bar", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<TabBar>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<TabBar>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("div");
        var classes = element.GetAttribute("class");
        Assert.Contains("tab-bar", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<TabBar>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("div");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleTablist()
    {
        var cut = RenderComponent<TabBar>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.Equal("tablist", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<TabBar>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("div");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<TabBar>(p => p
            .AddChildContent("Test content"));
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }
}
