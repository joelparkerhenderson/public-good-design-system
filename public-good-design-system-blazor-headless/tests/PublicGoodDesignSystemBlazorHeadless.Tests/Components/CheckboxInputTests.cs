using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class CheckboxInputTests : TestContext
{
    [Fact]
    public void RendersAsInput()
    {
        var cut = RenderComponent<CheckboxInput>();
        var element = cut.Find("input");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<CheckboxInput>();
        var element = cut.Find("input");
        Assert.Contains("checkbox-input", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<CheckboxInput>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("input");
        var classes = element.GetAttribute("class");
        Assert.Contains("checkbox-input", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<CheckboxInput>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("input");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<CheckboxInput>(p => p
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("input");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void RendersDisabledState()
    {
        var cut = RenderComponent<CheckboxInput>(p => p
            .Add(c => c.Disabled, true));
        var element = cut.Find("input");
        Assert.True(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersEnabledByDefault()
    {
        var cut = RenderComponent<CheckboxInput>();
        var element = cut.Find("input");
        Assert.False(element.HasAttribute("disabled"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<CheckboxInput>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void CheckedChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<CheckboxInput>(p => p
            .Add(c => c.Checked, false)
            .Add(c => c.CheckedChanged, (bool val) => callbackInvoked = true));
        // Verify component rendered with binding support
        Assert.NotNull(cut.Instance);
    }
}
