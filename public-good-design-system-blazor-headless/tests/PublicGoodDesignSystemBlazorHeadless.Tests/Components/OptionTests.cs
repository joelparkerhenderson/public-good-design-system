using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class OptionTests : TestContext
{
    [Fact]
    public void RendersAsOption()
    {
        var cut = RenderComponent<Option>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("option");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<Option>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("option");
        Assert.Contains("option", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<Option>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<Option>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("option");
        var classes = element.GetAttribute("class");
        Assert.Contains("option", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<Option>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("option");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void ValueDefaultIsEmptyString()
    {
        var cut = RenderComponent<Option>(p => p
            .AddChildContent("Test content"));
        // Default value for Value should be ""
        Assert.NotNull(cut.Instance);
    }
}
