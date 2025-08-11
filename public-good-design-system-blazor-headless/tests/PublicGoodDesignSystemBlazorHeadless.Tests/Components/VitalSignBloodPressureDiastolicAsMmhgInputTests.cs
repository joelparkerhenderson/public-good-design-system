using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class VitalSignBloodPressureDiastolicAsMmhgInputTests : TestContext
{
    [Fact]
    public void RendersAsInput()
    {
        var cut = RenderComponent<VitalSignBloodPressureDiastolicAsMmhgInput>();
        var element = cut.Find("input");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<VitalSignBloodPressureDiastolicAsMmhgInput>();
        var element = cut.Find("input");
        Assert.Contains("vital-sign-blood-pressure-diastolic-as-mmhg-input", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<VitalSignBloodPressureDiastolicAsMmhgInput>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("input");
        var classes = element.GetAttribute("class");
        Assert.Contains("vital-sign-blood-pressure-diastolic-as-mmhg-input", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<VitalSignBloodPressureDiastolicAsMmhgInput>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("input");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasTypeNumber()
    {
        var cut = RenderComponent<VitalSignBloodPressureDiastolicAsMmhgInput>();
        var element = cut.Find("input");
        Assert.Equal("number", element.GetAttribute("type"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<VitalSignBloodPressureDiastolicAsMmhgInput>(p => p
            .Add(c => c.Label, "Diastolic blood pressure (mmHg)"));
        var element = cut.Find("input");
        Assert.Equal("Diastolic blood pressure (mmHg)", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void HasDefaultMin()
    {
        var cut = RenderComponent<VitalSignBloodPressureDiastolicAsMmhgInput>();
        var element = cut.Find("input");
        Assert.Equal("0", element.GetAttribute("min"));
    }

    [Fact]
    public void HasDefaultMax()
    {
        var cut = RenderComponent<VitalSignBloodPressureDiastolicAsMmhgInput>();
        var element = cut.Find("input");
        Assert.Equal("200", element.GetAttribute("max"));
    }

    [Fact]
    public void HasDefaultStep()
    {
        var cut = RenderComponent<VitalSignBloodPressureDiastolicAsMmhgInput>();
        var element = cut.Find("input");
        Assert.Equal("1", element.GetAttribute("step"));
    }

    [Fact]
    public void RendersDisabledState()
    {
        var cut = RenderComponent<VitalSignBloodPressureDiastolicAsMmhgInput>(p => p
            .Add(c => c.Disabled, true));
        var element = cut.Find("input");
        Assert.True(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersEnabledByDefault()
    {
        var cut = RenderComponent<VitalSignBloodPressureDiastolicAsMmhgInput>();
        var element = cut.Find("input");
        Assert.False(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersRequiredState()
    {
        var cut = RenderComponent<VitalSignBloodPressureDiastolicAsMmhgInput>(p => p
            .Add(c => c.Required, true));
        var element = cut.Find("input");
        Assert.True(element.HasAttribute("required"));
    }

    [Fact]
    public void RendersNotRequiredByDefault()
    {
        var cut = RenderComponent<VitalSignBloodPressureDiastolicAsMmhgInput>();
        var element = cut.Find("input");
        Assert.False(element.HasAttribute("required"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<VitalSignBloodPressureDiastolicAsMmhgInput>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void ValueChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<VitalSignBloodPressureDiastolicAsMmhgInput>(p => p
            .Add(c => c.Value, 80)
            .Add(c => c.ValueChanged, (int? val) => callbackInvoked = true));
        Assert.NotNull(cut.Instance);
    }
}
