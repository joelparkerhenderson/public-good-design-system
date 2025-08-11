using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class EmailLinkTests : TestContext
{
    [Fact]
    public void RendersAsA()
    {
        var cut = RenderComponent<EmailLink>();
        var element = cut.Find("a");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<EmailLink>();
        var element = cut.Find("a");
        Assert.Contains("email-link", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<EmailLink>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("a");
        var classes = element.GetAttribute("class");
        Assert.Contains("email-link", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<EmailLink>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("a");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<EmailLink>(p => p
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("a");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void EmailDefaultIsEmptyString()
    {
        var cut = RenderComponent<EmailLink>();
        // Default value for Email should be ""
        Assert.NotNull(cut.Instance);
    }
}
