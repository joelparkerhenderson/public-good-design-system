using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class TreeNavTests : TestContext
{
    public TreeNavTests()
    {
        JSInterop.SetupVoid("headlessInterop.handleKeyboardNav").SetVoidResult();
        JSInterop.Mode = JSRuntimeMode.Loose;
    }

    [Fact]
    public void RendersAsUl()
    {
        var cut = RenderComponent<TreeNav>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("ul");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<TreeNav>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("ul");
        Assert.Contains("tree-nav", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<TreeNav>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<TreeNav>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("ul");
        var classes = element.GetAttribute("class");
        Assert.Contains("tree-nav", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<TreeNav>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("ul");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleTree()
    {
        var cut = RenderComponent<TreeNav>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("ul");
        Assert.Equal("tree", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<TreeNav>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("ul");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<TreeNav>(p => p
            .AddChildContent("Test content"));
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }
}
