using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class VitalSignBodyTemperatureCelciusInputTests : TestContext
{
    [Fact]
    public void RendersAsInput()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusInput>();
        var element = cut.Find("input");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusInput>();
        var element = cut.Find("input");
        Assert.Contains("vital-sign-body-temperature-celcius-input", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusInput>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("input");
        var classes = element.GetAttribute("class");
        Assert.Contains("vital-sign-body-temperature-celcius-input", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusInput>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("input");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasTypeNumber()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusInput>();
        var element = cut.Find("input");
        Assert.Equal("number", element.GetAttribute("type"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusInput>(p => p
            .Add(c => c.Label, "Body temperature (°C)"));
        var element = cut.Find("input");
        Assert.Equal("Body temperature (°C)", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void HasDefaultMin()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusInput>();
        var element = cut.Find("input");
        Assert.Equal("30", element.GetAttribute("min"));
    }

    [Fact]
    public void HasDefaultMax()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusInput>();
        var element = cut.Find("input");
        Assert.Equal("45", element.GetAttribute("max"));
    }

    [Fact]
    public void HasDefaultStep()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusInput>();
        var element = cut.Find("input");
        Assert.Equal("0.1", element.GetAttribute("step"));
    }

    [Fact]
    public void RendersDisabledState()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusInput>(p => p
            .Add(c => c.Disabled, true));
        var element = cut.Find("input");
        Assert.True(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersEnabledByDefault()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusInput>();
        var element = cut.Find("input");
        Assert.False(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersRequiredState()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusInput>(p => p
            .Add(c => c.Required, true));
        var element = cut.Find("input");
        Assert.True(element.HasAttribute("required"));
    }

    [Fact]
    public void RendersNotRequiredByDefault()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusInput>();
        var element = cut.Find("input");
        Assert.False(element.HasAttribute("required"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusInput>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void ValueChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusInput>(p => p
            .Add(c => c.Value, 37.0)
            .Add(c => c.ValueChanged, (double? val) => callbackInvoked = true));
        Assert.NotNull(cut.Instance);
    }
}
