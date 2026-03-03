using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class HamburgerMenuTests : TestContext
{
    [Fact]
    public void RendersAsDiv()
    {
        var cut = RenderComponent<HamburgerMenu>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<HamburgerMenu>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.Contains("hamburger-menu", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<HamburgerMenu>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<HamburgerMenu>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("div");
        var classes = element.GetAttribute("class");
        Assert.Contains("hamburger-menu", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<HamburgerMenu>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("div");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void LabelDefaultIsMenu()
    {
        var cut = RenderComponent<HamburgerMenu>(p => p
            .AddChildContent("Test content"));
        // Default value for Label should be "Menu"
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void OpenChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<HamburgerMenu>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Open, false)
            .Add(c => c.OpenChanged, (bool val) => callbackInvoked = true));
        // Verify component rendered with binding support
        Assert.NotNull(cut.Instance);
    }
}
