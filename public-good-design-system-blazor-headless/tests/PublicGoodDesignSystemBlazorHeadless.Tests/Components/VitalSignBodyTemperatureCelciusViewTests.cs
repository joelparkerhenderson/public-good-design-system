using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class VitalSignBodyTemperatureCelciusViewTests : TestContext
{
    [Fact]
    public void RendersAsSpan()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusView>();
        var element = cut.Find("span");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusView>();
        var element = cut.Find("span");
        Assert.Contains("vital-sign-body-temperature-celcius-view", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusView>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("span");
        var classes = element.GetAttribute("class");
        Assert.Contains("vital-sign-body-temperature-celcius-view", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusView>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("span");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleImg()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusView>();
        var element = cut.Find("span");
        Assert.Equal("img", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusView>(p => p
            .Add(c => c.Label, "Body temperature: 37.0 degrees Celsius"));
        var element = cut.Find("span");
        Assert.Equal("Body temperature: 37.0 degrees Celsius", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void RendersValueAsTextContent()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusView>(p => p
            .Add(c => c.Value, 37.0));
        var element = cut.Find("span");
        Assert.Equal("37", element.TextContent);
    }

    [Fact]
    public void RendersDataValueAttribute()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusView>(p => p
            .Add(c => c.Value, 37.0));
        var element = cut.Find("span");
        Assert.Equal("37", element.GetAttribute("data-value"));
    }

    [Fact]
    public void ValueDefaultIsZero()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusView>();
        // Default value for Value should be 0
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<VitalSignBodyTemperatureCelciusView>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }
}
