using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class AiLabelTests : TestContext
{
    [Fact]
    public void RendersAsSpan()
    {
        var cut = RenderComponent<AiLabel>();
        var element = cut.Find("span");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<AiLabel>();
        var element = cut.Find("span");
        Assert.Contains("ai-label", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersDefaultText()
    {
        var cut = RenderComponent<AiLabel>();
        Assert.Contains("AI", cut.Markup);
    }

    [Fact]
    public void RendersCustomText()
    {
        var cut = RenderComponent<AiLabel>(p => p
            .Add(c => c.Text, "AI generated"));
        Assert.Contains("AI generated", cut.Markup);
    }

    [Fact]
    public void HasDefaultAriaLabel()
    {
        var cut = RenderComponent<AiLabel>();
        var element = cut.Find("span");
        Assert.Equal("AI", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void HasCustomAriaLabel()
    {
        var cut = RenderComponent<AiLabel>(p => p
            .Add(c => c.Label, "AI content"));
        var element = cut.Find("span");
        Assert.Equal("AI content", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<AiLabel>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("span");
        var classes = element.GetAttribute("class");
        Assert.Contains("ai-label", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<AiLabel>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("span");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }
}
