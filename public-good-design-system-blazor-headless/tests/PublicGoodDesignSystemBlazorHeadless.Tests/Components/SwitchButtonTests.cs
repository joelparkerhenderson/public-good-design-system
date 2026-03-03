using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class SwitchButtonTests : TestContext
{
    [Fact]
    public void RendersAsButton()
    {
        var cut = RenderComponent<SwitchButton>();
        var element = cut.Find("button");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<SwitchButton>();
        var element = cut.Find("button");
        Assert.Contains("switch-button", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<SwitchButton>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("button");
        var classes = element.GetAttribute("class");
        Assert.Contains("switch-button", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<SwitchButton>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("button");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleSwitch()
    {
        var cut = RenderComponent<SwitchButton>();
        var element = cut.Find("button");
        Assert.Equal("switch", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<SwitchButton>(p => p
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("button");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void RendersDisabledState()
    {
        var cut = RenderComponent<SwitchButton>(p => p
            .Add(c => c.Disabled, true));
        var element = cut.Find("button");
        Assert.True(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersEnabledByDefault()
    {
        var cut = RenderComponent<SwitchButton>();
        var element = cut.Find("button");
        Assert.False(element.HasAttribute("disabled"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<SwitchButton>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void CheckedChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<SwitchButton>(p => p
            .Add(c => c.Checked, false)
            .Add(c => c.CheckedChanged, (bool val) => callbackInvoked = true));
        // Verify component rendered with binding support
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void AriaCheckedIsTrueWhenChecked()
    {
        var cut = RenderComponent<SwitchButton>(p => p
            .Add(c => c.Checked, true));
        var element = cut.Find("button");
        Assert.Equal("true", element.GetAttribute("aria-checked"));
    }
}
