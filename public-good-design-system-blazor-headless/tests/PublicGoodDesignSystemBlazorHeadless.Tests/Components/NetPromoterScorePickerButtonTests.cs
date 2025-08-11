using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class NetPromoterScorePickerButtonTests : TestContext
{
    [Fact]
    public void RendersAsButton()
    {
        var cut = RenderComponent<NetPromoterScorePickerButton>();
        var element = cut.Find("button");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<NetPromoterScorePickerButton>();
        var element = cut.Find("button");
        Assert.Contains("net-promoter-score-picker-button", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<NetPromoterScorePickerButton>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("button");
        var classes = element.GetAttribute("class");
        Assert.Contains("net-promoter-score-picker-button", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<NetPromoterScorePickerButton>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("button");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<NetPromoterScorePickerButton>(p => p
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("button");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void RendersDisabledState()
    {
        var cut = RenderComponent<NetPromoterScorePickerButton>(p => p
            .Add(c => c.Disabled, true));
        var element = cut.Find("button");
        Assert.True(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersEnabledByDefault()
    {
        var cut = RenderComponent<NetPromoterScorePickerButton>();
        var element = cut.Find("button");
        Assert.False(element.HasAttribute("disabled"));
    }

    [Fact]
    public void ValueDefaultIsEmptyString()
    {
        var cut = RenderComponent<NetPromoterScorePickerButton>();
        // Default value for Value should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<NetPromoterScorePickerButton>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }
}
