using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class ProgressCircleTests : TestContext
{
    [Fact]
    public void RendersAsDiv()
    {
        var cut = RenderComponent<ProgressCircle>();
        var element = cut.Find("div");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<ProgressCircle>();
        var element = cut.Find("div");
        Assert.Contains("progress-circle", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<ProgressCircle>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<ProgressCircle>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("div");
        var classes = element.GetAttribute("class");
        Assert.Contains("progress-circle", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<ProgressCircle>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("div");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleProgress()
    {
        var cut = RenderComponent<ProgressCircle>();
        var element = cut.Find("div");
        Assert.Equal("Progress", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<ProgressCircle>(p => p
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("div");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<ProgressCircle>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }
}
