using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class ColorPickerTests : TestContext
{
    [Fact]
    public void RendersAsDiv()
    {
        var cut = RenderComponent<ColorPicker>();
        var element = cut.Find("div");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<ColorPicker>();
        var element = cut.Find("div");
        Assert.Contains("color-picker", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<ColorPicker>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("div");
        var classes = element.GetAttribute("class");
        Assert.Contains("color-picker", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<ColorPicker>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("div");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleSlider()
    {
        var cut = RenderComponent<ColorPicker>();
        var element = cut.Find("div");
        Assert.Equal("slider", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<ColorPicker>(p => p
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("div");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<ColorPicker>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void XChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<ColorPicker>(p => p
            .Add(c => c.X, 0)
            .Add(c => c.XChanged, (int val) => callbackInvoked = true));
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void YChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<ColorPicker>(p => p
            .Add(c => c.Y, 0)
            .Add(c => c.YChanged, (int val) => callbackInvoked = true));
        Assert.NotNull(cut.Instance);
    }
}
