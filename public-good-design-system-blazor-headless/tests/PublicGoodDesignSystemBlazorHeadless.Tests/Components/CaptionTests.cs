using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class CaptionTests : TestContext
{
    [Fact]
    public void RendersAsFigcaption()
    {
        var cut = RenderComponent<Caption>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("figcaption");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<Caption>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("figcaption");
        Assert.Contains("caption", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<Caption>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<Caption>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("figcaption");
        var classes = element.GetAttribute("class");
        Assert.Contains("caption", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<Caption>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("figcaption");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }
}
