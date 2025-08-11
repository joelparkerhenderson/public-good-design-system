using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class GrailLayoutLeftAsideTests : TestContext
{
    [Fact]
    public void RendersAsDiv()
    {
        var cut = RenderComponent<GrailLayoutLeftAside>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<GrailLayoutLeftAside>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.Contains("grail-layout-left-aside", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<GrailLayoutLeftAside>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<GrailLayoutLeftAside>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("div");
        var classes = element.GetAttribute("class");
        Assert.Contains("grail-layout-left-aside", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<GrailLayoutLeftAside>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("div");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }
}
