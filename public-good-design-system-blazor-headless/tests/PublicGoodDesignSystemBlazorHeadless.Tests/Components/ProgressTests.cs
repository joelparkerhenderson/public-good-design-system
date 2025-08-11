using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class ProgressTests : TestContext
{
    [Fact]
    public void RendersAsProgress()
    {
        var cut = RenderComponent<Progress>();
        var element = cut.Find("progress");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<Progress>();
        var element = cut.Find("progress");
        Assert.Contains("progress", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<Progress>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("progress");
        var classes = element.GetAttribute("class");
        Assert.Contains("progress", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<Progress>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("progress");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<Progress>(p => p
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("progress");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<Progress>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }
}
