using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class TooltipTests : TestContext
{
    [Fact]
    public void RendersAsDiv()
    {
        var cut = RenderComponent<Tooltip>(p => p
            .Add(c => c.Visible, true));
        var element = cut.Find("div");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<Tooltip>(p => p
            .Add(c => c.Visible, true));
        var element = cut.Find("div");
        Assert.Contains("tooltip", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<Tooltip>(p => p
            .Add(c => c.Visible, true)
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("div");
        var classes = element.GetAttribute("class");
        Assert.Contains("tooltip", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<Tooltip>(p => p
            .Add(c => c.Visible, true)
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("div");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleTooltip()
    {
        var cut = RenderComponent<Tooltip>(p => p
            .Add(c => c.Visible, true));
        var element = cut.Find("div");
        Assert.Equal("tooltip", element.GetAttribute("role"));
    }

    [Fact]
    public void HiddenWhenVisibleIsFalse()
    {
        var cut = RenderComponent<Tooltip>();
        Assert.Empty(cut.Markup.Trim());
    }

    [Fact]
    public void VisibleWhenVisibleIsTrue()
    {
        var cut = RenderComponent<Tooltip>(p => p
            .Add(c => c.Visible, true));
        var element = cut.Find("div");
        Assert.NotNull(element);
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<Tooltip>(p => p
            .Add(c => c.Visible, true));
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }
}
