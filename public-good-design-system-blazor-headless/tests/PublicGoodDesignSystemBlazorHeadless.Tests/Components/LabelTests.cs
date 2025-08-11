using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class LabelTests : TestContext
{
    [Fact]
    public void RendersAsLabel()
    {
        var cut = RenderComponent<Label>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("label");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<Label>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("label");
        Assert.Contains("label", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<Label>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<Label>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("label");
        var classes = element.GetAttribute("class");
        Assert.Contains("label", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<Label>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("label");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }
}
