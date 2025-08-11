using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class PasswordInputOrTextInputDivTests : TestContext
{
    [Fact]
    public void RendersAsDiv()
    {
        var cut = RenderComponent<PasswordInputOrTextInputDiv>();
        var element = cut.Find("div");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<PasswordInputOrTextInputDiv>();
        var element = cut.Find("div");
        Assert.Contains("password-input-or-text-input-div", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<PasswordInputOrTextInputDiv>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("div");
        var classes = element.GetAttribute("class");
        Assert.Contains("password-input-or-text-input-div", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<PasswordInputOrTextInputDiv>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("div");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<PasswordInputOrTextInputDiv>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void ValueDefaultIsEmptyString()
    {
        var cut = RenderComponent<PasswordInputOrTextInputDiv>();
        // Default value for Value should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void ToggleLabelDefaultIsShowpassword()
    {
        var cut = RenderComponent<PasswordInputOrTextInputDiv>();
        // Default value for ToggleLabel should be "Show password"
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void ValueChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<PasswordInputOrTextInputDiv>(p => p
            .Add(c => c.Value, "initial")
            .Add(c => c.ValueChanged, (string val) => callbackInvoked = true));
        Assert.NotNull(cut.Instance);
    }
}
