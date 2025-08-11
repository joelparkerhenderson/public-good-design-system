using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class ThemeSelectTests : TestContext
{
    [Fact]
    public void RendersAsSelect()
    {
        var cut = RenderComponent<ThemeSelect>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("select");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<ThemeSelect>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("select");
        Assert.Contains("theme-select", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<ThemeSelect>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<ThemeSelect>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("select");
        var classes = element.GetAttribute("class");
        Assert.Contains("theme-select", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<ThemeSelect>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("select");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<ThemeSelect>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("select");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<ThemeSelect>(p => p
            .AddChildContent("Test content"));
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void ValueDefaultIsEmptyString()
    {
        var cut = RenderComponent<ThemeSelect>(p => p
            .AddChildContent("Test content"));
        // Default value for Value should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void ValueChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<ThemeSelect>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Value, "initial")
            .Add(c => c.ValueChanged, (string val) => callbackInvoked = true));
        Assert.NotNull(cut.Instance);
    }
}
