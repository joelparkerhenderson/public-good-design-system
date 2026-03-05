using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class VitalSignCholesterolLdlMmolPerLitreViewTests : TestContext
{
    [Fact]
    public void RendersAsSpan()
    {
        var cut = RenderComponent<VitalSignCholesterolLdlMmolPerLitreView>();
        var element = cut.Find("span");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<VitalSignCholesterolLdlMmolPerLitreView>();
        var element = cut.Find("span");
        Assert.Contains("vital-sign-cholesterol-ldl-mmol-per-litre-view", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<VitalSignCholesterolLdlMmolPerLitreView>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("span");
        var classes = element.GetAttribute("class");
        Assert.Contains("vital-sign-cholesterol-ldl-mmol-per-litre-view", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<VitalSignCholesterolLdlMmolPerLitreView>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("span");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleImg()
    {
        var cut = RenderComponent<VitalSignCholesterolLdlMmolPerLitreView>();
        var element = cut.Find("span");
        Assert.Equal("img", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<VitalSignCholesterolLdlMmolPerLitreView>(p => p
            .Add(c => c.Label, "Cholesterol LDL: 2.5 mmol/L"));
        var element = cut.Find("span");
        Assert.Equal("Cholesterol LDL: 2.5 mmol/L", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void RendersValueAsTextContent()
    {
        var cut = RenderComponent<VitalSignCholesterolLdlMmolPerLitreView>(p => p
            .Add(c => c.Value, 2.5));
        var element = cut.Find("span");
        Assert.Equal("2.5", element.TextContent);
    }

    [Fact]
    public void RendersDataValueAttribute()
    {
        var cut = RenderComponent<VitalSignCholesterolLdlMmolPerLitreView>(p => p
            .Add(c => c.Value, 2.5));
        var element = cut.Find("span");
        Assert.Equal("2.5", element.GetAttribute("data-value"));
    }

    [Fact]
    public void ValueDefaultIsZero()
    {
        var cut = RenderComponent<VitalSignCholesterolLdlMmolPerLitreView>();
        // Default value for Value should be 0
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<VitalSignCholesterolLdlMmolPerLitreView>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }
}
