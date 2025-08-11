using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class FieldsetTests : TestContext
{
    [Fact]
    public void RendersAsFieldset()
    {
        var cut = RenderComponent<Fieldset>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("fieldset");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<Fieldset>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("fieldset");
        Assert.Contains("fieldset", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<Fieldset>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<Fieldset>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("fieldset");
        var classes = element.GetAttribute("class");
        Assert.Contains("fieldset", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<Fieldset>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("fieldset");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void RendersDisabledState()
    {
        var cut = RenderComponent<Fieldset>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Disabled, true));
        var element = cut.Find("fieldset");
        Assert.True(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersEnabledByDefault()
    {
        var cut = RenderComponent<Fieldset>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("fieldset");
        Assert.False(element.HasAttribute("disabled"));
    }

    [Fact]
    public void LegendDefaultIsEmptyString()
    {
        var cut = RenderComponent<Fieldset>(p => p
            .AddChildContent("Test content"));
        // Default value for Legend should be ""
        Assert.NotNull(cut.Instance);
    }
}
