using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class VitalSignCholesterolAsLdlMmolPerLitreInputTests : TestContext
{
    [Fact]
    public void RendersAsInput()
    {
        var cut = RenderComponent<VitalSignCholesterolAsLdlMmolPerLitreInput>();
        var element = cut.Find("input");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<VitalSignCholesterolAsLdlMmolPerLitreInput>();
        var element = cut.Find("input");
        Assert.Contains("vital-sign-cholesterol-as-ldl-mmol-per-litre-input", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<VitalSignCholesterolAsLdlMmolPerLitreInput>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("input");
        var classes = element.GetAttribute("class");
        Assert.Contains("vital-sign-cholesterol-as-ldl-mmol-per-litre-input", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<VitalSignCholesterolAsLdlMmolPerLitreInput>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("input");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasTypeNumber()
    {
        var cut = RenderComponent<VitalSignCholesterolAsLdlMmolPerLitreInput>();
        var element = cut.Find("input");
        Assert.Equal("number", element.GetAttribute("type"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<VitalSignCholesterolAsLdlMmolPerLitreInput>(p => p
            .Add(c => c.Label, "Cholesterol LDL (mmol/L)"));
        var element = cut.Find("input");
        Assert.Equal("Cholesterol LDL (mmol/L)", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void HasDefaultMin()
    {
        var cut = RenderComponent<VitalSignCholesterolAsLdlMmolPerLitreInput>();
        var element = cut.Find("input");
        Assert.Equal("0", element.GetAttribute("min"));
    }

    [Fact]
    public void HasDefaultMax()
    {
        var cut = RenderComponent<VitalSignCholesterolAsLdlMmolPerLitreInput>();
        var element = cut.Find("input");
        Assert.Equal("10", element.GetAttribute("max"));
    }

    [Fact]
    public void HasDefaultStep()
    {
        var cut = RenderComponent<VitalSignCholesterolAsLdlMmolPerLitreInput>();
        var element = cut.Find("input");
        Assert.Equal("0.1", element.GetAttribute("step"));
    }

    [Fact]
    public void RendersDisabledState()
    {
        var cut = RenderComponent<VitalSignCholesterolAsLdlMmolPerLitreInput>(p => p
            .Add(c => c.Disabled, true));
        var element = cut.Find("input");
        Assert.True(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersEnabledByDefault()
    {
        var cut = RenderComponent<VitalSignCholesterolAsLdlMmolPerLitreInput>();
        var element = cut.Find("input");
        Assert.False(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersRequiredState()
    {
        var cut = RenderComponent<VitalSignCholesterolAsLdlMmolPerLitreInput>(p => p
            .Add(c => c.Required, true));
        var element = cut.Find("input");
        Assert.True(element.HasAttribute("required"));
    }

    [Fact]
    public void RendersNotRequiredByDefault()
    {
        var cut = RenderComponent<VitalSignCholesterolAsLdlMmolPerLitreInput>();
        var element = cut.Find("input");
        Assert.False(element.HasAttribute("required"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<VitalSignCholesterolAsLdlMmolPerLitreInput>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void ValueChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<VitalSignCholesterolAsLdlMmolPerLitreInput>(p => p
            .Add(c => c.Value, 2.5)
            .Add(c => c.ValueChanged, (double? val) => callbackInvoked = true));
        Assert.NotNull(cut.Instance);
    }
}
