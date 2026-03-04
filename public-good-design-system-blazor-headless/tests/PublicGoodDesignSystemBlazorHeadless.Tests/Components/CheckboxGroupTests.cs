using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class CheckboxGroupTests : TestContext
{
    [Fact]
    public void RendersAsFieldset()
    {
        var cut = RenderComponent<CheckboxGroup>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("fieldset");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<CheckboxGroup>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("fieldset");
        Assert.Contains("checkbox-group", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<CheckboxGroup>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<CheckboxGroup>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("fieldset");
        var classes = element.GetAttribute("class");
        Assert.Contains("checkbox-group", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<CheckboxGroup>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("fieldset");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleGroup()
    {
        var cut = RenderComponent<CheckboxGroup>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("fieldset");
        Assert.Equal("group", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<CheckboxGroup>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("fieldset");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void SupportsDisabled()
    {
        var cut = RenderComponent<CheckboxGroup>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Disabled, true));
        var element = cut.Find("fieldset");
        Assert.NotNull(element.GetAttribute("disabled"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<CheckboxGroup>(p => p
            .AddChildContent("Test content"));
        Assert.NotNull(cut.Instance);
    }
}
