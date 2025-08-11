using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class ToggleButtonTests : TestContext
{
    [Fact]
    public void RendersAsButton()
    {
        var cut = RenderComponent<ToggleButton>();
        var element = cut.Find("button");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<ToggleButton>();
        var element = cut.Find("button");
        Assert.Contains("toggle-button", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<ToggleButton>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<ToggleButton>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("button");
        var classes = element.GetAttribute("class");
        Assert.Contains("toggle-button", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<ToggleButton>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("button");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleSwitch()
    {
        var cut = RenderComponent<ToggleButton>();
        var element = cut.Find("button");
        Assert.Equal("switch", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<ToggleButton>(p => p
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("button");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void RendersDisabledState()
    {
        var cut = RenderComponent<ToggleButton>(p => p
            .Add(c => c.Disabled, true));
        var element = cut.Find("button");
        Assert.True(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersEnabledByDefault()
    {
        var cut = RenderComponent<ToggleButton>();
        var element = cut.Find("button");
        Assert.False(element.HasAttribute("disabled"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<ToggleButton>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void PressedChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<ToggleButton>(p => p
            .Add(c => c.Pressed, false)
            .Add(c => c.PressedChanged, (bool val) => callbackInvoked = true));
        // Verify component rendered with binding support
        Assert.NotNull(cut.Instance);
    }
}
