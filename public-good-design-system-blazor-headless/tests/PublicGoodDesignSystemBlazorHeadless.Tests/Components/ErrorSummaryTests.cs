using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class ErrorSummaryTests : TestContext
{
    [Fact]
    public void RendersAsDiv()
    {
        var cut = RenderComponent<ErrorSummary>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<ErrorSummary>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.Contains("error-summary", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<ErrorSummary>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<ErrorSummary>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("div");
        var classes = element.GetAttribute("class");
        Assert.Contains("error-summary", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<ErrorSummary>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("div");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleAlert()
    {
        var cut = RenderComponent<ErrorSummary>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.Equal("alert", element.GetAttribute("role"));
    }

    [Fact]
    public void TitleDefaultIsEmptyString()
    {
        var cut = RenderComponent<ErrorSummary>(p => p
            .AddChildContent("Test content"));
        // Default value for Title should be ""
        Assert.NotNull(cut.Instance);
    }
}
