using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class HiddenInputTests : TestContext
{
    [Fact]
    public void RendersAsInput()
    {
        var cut = RenderComponent<HiddenInput>();
        var element = cut.Find("input");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<HiddenInput>();
        var element = cut.Find("input");
        Assert.Contains("hidden-input", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<HiddenInput>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("input");
        var classes = element.GetAttribute("class");
        Assert.Contains("hidden-input", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<HiddenInput>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("input");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void NameDefaultIsEmptyString()
    {
        var cut = RenderComponent<HiddenInput>();
        // Default value for Name should be ""
        Assert.NotNull(cut.Instance);
    }
}
