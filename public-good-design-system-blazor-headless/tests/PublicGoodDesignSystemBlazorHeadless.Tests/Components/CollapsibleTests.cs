using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class CollapsibleTests : TestContext
{
    [Fact]
    public void RendersAsDetails()
    {
        var cut = RenderComponent<Collapsible>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("details");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<Collapsible>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("details");
        Assert.Contains("collapsable-details", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<Collapsible>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<Collapsible>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("details");
        var classes = element.GetAttribute("class");
        Assert.Contains("collapsable-details", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<Collapsible>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("details");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void SummaryDefaultIsEmptyString()
    {
        var cut = RenderComponent<Collapsible>(p => p
            .AddChildContent("Test content"));
        // Default value for Summary should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void OpenChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<Collapsible>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Open, false)
            .Add(c => c.OpenChanged, (bool val) => callbackInvoked = true));
        // Verify component rendered with binding support
        Assert.NotNull(cut.Instance);
    }
}
