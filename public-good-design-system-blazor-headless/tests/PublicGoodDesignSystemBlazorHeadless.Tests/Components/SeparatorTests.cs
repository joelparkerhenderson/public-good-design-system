using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class SeparatorTests : TestContext
{
    [Fact]
    public void RendersAsHr()
    {
        var cut = RenderComponent<Separator>();
        var element = cut.Find("hr");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<Separator>();
        var element = cut.Find("hr");
        Assert.Contains("separator", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<Separator>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("hr");
        var classes = element.GetAttribute("class");
        Assert.Contains("separator", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<Separator>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("hr");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleSeparator()
    {
        var cut = RenderComponent<Separator>();
        var element = cut.Find("hr");
        Assert.Equal("separator", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<Separator>(p => p
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("hr");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }
}
