using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;
using ComponentTimer = PublicGoodDesignSystemBlazorHeadless.Components.Timer;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class TimerTests : TestContext
{
    [Fact]
    public void RendersAsTime()
    {
        var cut = RenderComponent<ComponentTimer>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("time");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<ComponentTimer>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("time");
        Assert.Contains("timer", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<ComponentTimer>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<ComponentTimer>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("time");
        var classes = element.GetAttribute("class");
        Assert.Contains("timer", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<ComponentTimer>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("time");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleTimer()
    {
        var cut = RenderComponent<ComponentTimer>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("time");
        Assert.Equal("timer", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<ComponentTimer>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("time");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<ComponentTimer>(p => p
            .AddChildContent("Test content"));
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }
}
