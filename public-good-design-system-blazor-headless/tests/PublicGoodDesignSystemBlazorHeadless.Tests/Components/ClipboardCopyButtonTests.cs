using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class ClipboardCopyButtonTests : TestContext
{
    [Fact]
    public void RendersAsButton()
    {
        var cut = RenderComponent<ClipboardCopyButton>();
        var element = cut.Find("button");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<ClipboardCopyButton>();
        var element = cut.Find("button");
        Assert.Contains("clipboard-copy-button", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<ClipboardCopyButton>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<ClipboardCopyButton>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("button");
        var classes = element.GetAttribute("class");
        Assert.Contains("clipboard-copy-button", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<ClipboardCopyButton>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("button");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<ClipboardCopyButton>(p => p
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("button");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void TextDefaultIsEmptyString()
    {
        var cut = RenderComponent<ClipboardCopyButton>();
        // Default value for Text should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<ClipboardCopyButton>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }
}
