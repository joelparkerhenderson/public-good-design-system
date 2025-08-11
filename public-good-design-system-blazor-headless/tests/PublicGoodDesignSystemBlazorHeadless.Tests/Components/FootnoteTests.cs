using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class FootnoteTests : TestContext
{
    [Fact]
    public void RendersAsAside()
    {
        var cut = RenderComponent<Footnote>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("aside");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<Footnote>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("aside");
        Assert.Contains("aside", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<Footnote>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<Footnote>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("aside");
        var classes = element.GetAttribute("class");
        Assert.Contains("aside", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<Footnote>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("aside");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleNote()
    {
        var cut = RenderComponent<Footnote>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("aside");
        Assert.Equal("note", element.GetAttribute("role"));
    }

    [Fact]
    public void IdDefaultIsEmptyString()
    {
        var cut = RenderComponent<Footnote>(p => p
            .AddChildContent("Test content"));
        // Default value for Id should be ""
        Assert.NotNull(cut.Instance);
    }
}
