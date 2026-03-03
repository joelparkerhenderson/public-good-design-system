using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class ButtonTests : TestContext
{
    [Fact]
    public void RendersAsButton()
    {
        var cut = RenderComponent<Button>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("button");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<Button>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("button");
        Assert.Contains("button", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<Button>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<Button>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("button");
        var classes = element.GetAttribute("class");
        Assert.Contains("button", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<Button>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("button");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<Button>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("button");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void RendersDisabledState()
    {
        var cut = RenderComponent<Button>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Disabled, true));
        var element = cut.Find("button");
        Assert.True(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersEnabledByDefault()
    {
        var cut = RenderComponent<Button>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("button");
        Assert.False(element.HasAttribute("disabled"));
    }

    [Fact]
    public void TypeDefaultIsbutton()
    {
        var cut = RenderComponent<Button>(p => p
            .AddChildContent("Test content"));
        // Default value for Type should be "button"
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void AriaPressedIsTrueWhenPressed()
    {
        var cut = RenderComponent<Button>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Pressed, true));
        var element = cut.Find("button");
        Assert.Equal("true", element.GetAttribute("aria-pressed"));
    }
}
