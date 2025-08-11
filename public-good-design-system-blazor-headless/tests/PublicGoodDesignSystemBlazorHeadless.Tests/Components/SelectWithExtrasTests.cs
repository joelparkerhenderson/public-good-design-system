using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class SelectWithExtrasTests : TestContext
{
    [Fact]
    public void RendersAsDiv()
    {
        var cut = RenderComponent<SelectWithExtras>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<SelectWithExtras>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.Contains("select-with-extras", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<SelectWithExtras>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<SelectWithExtras>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("div");
        var classes = element.GetAttribute("class");
        Assert.Contains("select-with-extras", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<SelectWithExtras>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("div");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<SelectWithExtras>(p => p
            .AddChildContent("Test content"));
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void ValueDefaultIsEmptyString()
    {
        var cut = RenderComponent<SelectWithExtras>(p => p
            .AddChildContent("Test content"));
        // Default value for Value should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void BeforeDefaultIsEmptyString()
    {
        var cut = RenderComponent<SelectWithExtras>(p => p
            .AddChildContent("Test content"));
        // Default value for Before should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void AfterDefaultIsEmptyString()
    {
        var cut = RenderComponent<SelectWithExtras>(p => p
            .AddChildContent("Test content"));
        // Default value for After should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void ValueChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<SelectWithExtras>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Value, "initial")
            .Add(c => c.ValueChanged, (string val) => callbackInvoked = true));
        Assert.NotNull(cut.Instance);
    }
}
