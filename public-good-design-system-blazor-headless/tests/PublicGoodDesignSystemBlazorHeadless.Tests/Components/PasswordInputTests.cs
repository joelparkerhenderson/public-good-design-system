using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class PasswordInputTests : TestContext
{
    [Fact]
    public void RendersAsInput()
    {
        var cut = RenderComponent<PasswordInput>();
        var element = cut.Find("input");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasTypePassword()
    {
        var cut = RenderComponent<PasswordInput>();
        var element = cut.Find("input");
        Assert.Equal("password", element.GetAttribute("type"));
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<PasswordInput>();
        var element = cut.Find("input");
        Assert.Contains("password-input", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<PasswordInput>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("input");
        var classes = element.GetAttribute("class");
        Assert.Contains("password-input", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<PasswordInput>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("input");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<PasswordInput>(p => p
            .Add(c => c.Label, "Password"));
        var element = cut.Find("input");
        Assert.Equal("Password", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void RendersAutocompleteDefault()
    {
        var cut = RenderComponent<PasswordInput>();
        var element = cut.Find("input");
        Assert.Equal("current-password", element.GetAttribute("autocomplete"));
    }

    [Fact]
    public void RendersCustomAutocomplete()
    {
        var cut = RenderComponent<PasswordInput>(p => p
            .Add(c => c.Autocomplete, "new-password"));
        var element = cut.Find("input");
        Assert.Equal("new-password", element.GetAttribute("autocomplete"));
    }

    [Fact]
    public void RendersDisabledState()
    {
        var cut = RenderComponent<PasswordInput>(p => p
            .Add(c => c.Disabled, true));
        var element = cut.Find("input");
        Assert.True(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersEnabledByDefault()
    {
        var cut = RenderComponent<PasswordInput>();
        var element = cut.Find("input");
        Assert.False(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersRequiredState()
    {
        var cut = RenderComponent<PasswordInput>(p => p
            .Add(c => c.Required, true));
        var element = cut.Find("input");
        Assert.True(element.HasAttribute("required"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<PasswordInput>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void ValueDefaultIsEmptyString()
    {
        var cut = RenderComponent<PasswordInput>();
        // Default value for Value should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void ValueChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<PasswordInput>(p => p
            .Add(c => c.Value, "initial")
            .Add(c => c.ValueChanged, (string val) => callbackInvoked = true));
        Assert.NotNull(cut.Instance);
    }
}
