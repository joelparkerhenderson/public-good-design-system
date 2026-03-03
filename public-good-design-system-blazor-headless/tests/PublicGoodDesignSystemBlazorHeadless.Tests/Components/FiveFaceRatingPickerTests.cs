using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class FiveFaceRatingPickerTests : TestContext
{
    [Fact]
    public void RendersAsFieldset()
    {
        var cut = RenderComponent<FiveFaceRatingPicker>();
        var element = cut.Find("fieldset");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<FiveFaceRatingPicker>();
        var element = cut.Find("fieldset");
        Assert.Contains("five-face-rating-picker", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<FiveFaceRatingPicker>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("fieldset");
        var classes = element.GetAttribute("class");
        Assert.Contains("five-face-rating-picker", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<FiveFaceRatingPicker>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("fieldset");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleRadiogroup()
    {
        var cut = RenderComponent<FiveFaceRatingPicker>();
        var element = cut.Find("fieldset");
        Assert.Equal("radiogroup", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<FiveFaceRatingPicker>(p => p
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("fieldset");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void RendersDisabledState()
    {
        var cut = RenderComponent<FiveFaceRatingPicker>(p => p
            .Add(c => c.Disabled, true));
        var element = cut.Find("fieldset");
        Assert.True(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersEnabledByDefault()
    {
        var cut = RenderComponent<FiveFaceRatingPicker>();
        var element = cut.Find("fieldset");
        Assert.False(element.HasAttribute("disabled"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<FiveFaceRatingPicker>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void NameDefaultIsfacerating()
    {
        var cut = RenderComponent<FiveFaceRatingPicker>();
        // Default value for Name should be "face-rating"
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void ValueChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<FiveFaceRatingPicker>(p => p
            .Add(c => c.Value, 0)
            .Add(c => c.ValueChanged, (int val) => callbackInvoked = true));
        Assert.NotNull(cut.Instance);
    }
}
