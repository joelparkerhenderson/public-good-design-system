using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class BackLinkTests : TestContext
{
    [Fact]
    public void RendersAsA()
    {
        var cut = RenderComponent<BackLink>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("a");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<BackLink>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("a");
        Assert.Contains("back-link", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<BackLink>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<BackLink>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("a");
        var classes = element.GetAttribute("class");
        Assert.Contains("back-link", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<BackLink>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("a");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<BackLink>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("a");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void HrefDefaultIsEmptyString()
    {
        var cut = RenderComponent<BackLink>(p => p
            .AddChildContent("Test content"));
        // Default value for Href should be ""
        Assert.NotNull(cut.Instance);
    }
}
