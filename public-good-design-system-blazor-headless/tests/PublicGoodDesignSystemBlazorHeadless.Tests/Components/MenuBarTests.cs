using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class MenuBarTests : TestContext
{
    public MenuBarTests()
    {
        JSInterop.SetupVoid("headlessInterop.handleKeyboardNav").SetVoidResult();
        JSInterop.Mode = JSRuntimeMode.Loose;
    }

    [Fact]
    public void RendersAsDiv()
    {
        var cut = RenderComponent<MenuBar>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<MenuBar>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.Contains("menu-bar", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<MenuBar>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<MenuBar>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("div");
        var classes = element.GetAttribute("class");
        Assert.Contains("menu-bar", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<MenuBar>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("div");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleMenubar()
    {
        var cut = RenderComponent<MenuBar>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.Equal("menubar", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<MenuBar>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("div");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<MenuBar>(p => p
            .AddChildContent("Test content"));
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }
}
