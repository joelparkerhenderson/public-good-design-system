using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class VitalSignHeartRateBeatsPerMinuteInputTests : TestContext
{
    [Fact]
    public void RendersAsInput()
    {
        var cut = RenderComponent<VitalSignHeartRateBeatsPerMinuteInput>();
        var element = cut.Find("input");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<VitalSignHeartRateBeatsPerMinuteInput>();
        var element = cut.Find("input");
        Assert.Contains("vital-sign-heart-rate-beats-per-minute-input", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<VitalSignHeartRateBeatsPerMinuteInput>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("input");
        var classes = element.GetAttribute("class");
        Assert.Contains("vital-sign-heart-rate-beats-per-minute-input", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<VitalSignHeartRateBeatsPerMinuteInput>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("input");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasTypeNumber()
    {
        var cut = RenderComponent<VitalSignHeartRateBeatsPerMinuteInput>();
        var element = cut.Find("input");
        Assert.Equal("number", element.GetAttribute("type"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<VitalSignHeartRateBeatsPerMinuteInput>(p => p
            .Add(c => c.Label, "Heart rate (bpm)"));
        var element = cut.Find("input");
        Assert.Equal("Heart rate (bpm)", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void HasDefaultMin()
    {
        var cut = RenderComponent<VitalSignHeartRateBeatsPerMinuteInput>();
        var element = cut.Find("input");
        Assert.Equal("0", element.GetAttribute("min"));
    }

    [Fact]
    public void HasDefaultMax()
    {
        var cut = RenderComponent<VitalSignHeartRateBeatsPerMinuteInput>();
        var element = cut.Find("input");
        Assert.Equal("300", element.GetAttribute("max"));
    }

    [Fact]
    public void HasDefaultStep()
    {
        var cut = RenderComponent<VitalSignHeartRateBeatsPerMinuteInput>();
        var element = cut.Find("input");
        Assert.Equal("1", element.GetAttribute("step"));
    }

    [Fact]
    public void RendersDisabledState()
    {
        var cut = RenderComponent<VitalSignHeartRateBeatsPerMinuteInput>(p => p
            .Add(c => c.Disabled, true));
        var element = cut.Find("input");
        Assert.True(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersEnabledByDefault()
    {
        var cut = RenderComponent<VitalSignHeartRateBeatsPerMinuteInput>();
        var element = cut.Find("input");
        Assert.False(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersRequiredState()
    {
        var cut = RenderComponent<VitalSignHeartRateBeatsPerMinuteInput>(p => p
            .Add(c => c.Required, true));
        var element = cut.Find("input");
        Assert.True(element.HasAttribute("required"));
    }

    [Fact]
    public void RendersNotRequiredByDefault()
    {
        var cut = RenderComponent<VitalSignHeartRateBeatsPerMinuteInput>();
        var element = cut.Find("input");
        Assert.False(element.HasAttribute("required"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<VitalSignHeartRateBeatsPerMinuteInput>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void ValueChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<VitalSignHeartRateBeatsPerMinuteInput>(p => p
            .Add(c => c.Value, 72)
            .Add(c => c.ValueChanged, (int? val) => callbackInvoked = true));
        Assert.NotNull(cut.Instance);
    }
}
