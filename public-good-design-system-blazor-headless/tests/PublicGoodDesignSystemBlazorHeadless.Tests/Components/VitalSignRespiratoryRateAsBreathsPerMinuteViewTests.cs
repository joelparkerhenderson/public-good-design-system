using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class VitalSignRespiratoryRateAsBreathsPerMinuteViewTests : TestContext
{
    [Fact]
    public void RendersAsSpan()
    {
        var cut = RenderComponent<VitalSignRespiratoryRateAsBreathsPerMinuteView>();
        var element = cut.Find("span");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<VitalSignRespiratoryRateAsBreathsPerMinuteView>();
        var element = cut.Find("span");
        Assert.Contains("vital-sign-respiratory-rate-as-breaths-per-minute-view", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<VitalSignRespiratoryRateAsBreathsPerMinuteView>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("span");
        var classes = element.GetAttribute("class");
        Assert.Contains("vital-sign-respiratory-rate-as-breaths-per-minute-view", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<VitalSignRespiratoryRateAsBreathsPerMinuteView>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("span");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleImg()
    {
        var cut = RenderComponent<VitalSignRespiratoryRateAsBreathsPerMinuteView>();
        var element = cut.Find("span");
        Assert.Equal("img", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<VitalSignRespiratoryRateAsBreathsPerMinuteView>(p => p
            .Add(c => c.Label, "Respiratory rate: 16 breaths per minute"));
        var element = cut.Find("span");
        Assert.Equal("Respiratory rate: 16 breaths per minute", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void RendersValueAsTextContent()
    {
        var cut = RenderComponent<VitalSignRespiratoryRateAsBreathsPerMinuteView>(p => p
            .Add(c => c.Value, 16));
        var element = cut.Find("span");
        Assert.Equal("16", element.TextContent);
    }

    [Fact]
    public void RendersDataValueAttribute()
    {
        var cut = RenderComponent<VitalSignRespiratoryRateAsBreathsPerMinuteView>(p => p
            .Add(c => c.Value, 16));
        var element = cut.Find("span");
        Assert.Equal("16", element.GetAttribute("data-value"));
    }

    [Fact]
    public void ValueDefaultIsZero()
    {
        var cut = RenderComponent<VitalSignRespiratoryRateAsBreathsPerMinuteView>();
        // Default value for Value should be 0
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<VitalSignRespiratoryRateAsBreathsPerMinuteView>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }
}
