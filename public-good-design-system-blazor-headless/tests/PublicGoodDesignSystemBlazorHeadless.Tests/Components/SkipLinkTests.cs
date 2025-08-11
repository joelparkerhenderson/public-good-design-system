using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class SkipLinkTests : TestContext
{
    [Fact]
    public void RendersAsA()
    {
        var cut = RenderComponent<SkipLink>();
        var element = cut.Find("a");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<SkipLink>();
        var element = cut.Find("a");
        Assert.Contains("skip-link", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<SkipLink>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("a");
        var classes = element.GetAttribute("class");
        Assert.Contains("skip-link", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<SkipLink>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("a");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HrefDefaultIscontent()
    {
        var cut = RenderComponent<SkipLink>();
        // Default value for Href should be "#content"
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void LabelDefaultIsSkiptocontent()
    {
        var cut = RenderComponent<SkipLink>();
        // Default value for Label should be "Skip to content"
        Assert.NotNull(cut.Instance);
    }
}
