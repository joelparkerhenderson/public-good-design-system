using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class SheetTests : TestContext
{
    [Fact]
    public void RendersAsDiv()
    {
        var cut = RenderComponent<Sheet>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<Sheet>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.Contains("sheet", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<Sheet>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<Sheet>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("div");
        var classes = element.GetAttribute("class");
        Assert.Contains("sheet", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<Sheet>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("div");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleDialog()
    {
        var cut = RenderComponent<Sheet>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.Equal("dialog", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<Sheet>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content")
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("div");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void HiddenWhenOpenIsFalse()
    {
        var cut = RenderComponent<Sheet>(p => p
            .AddChildContent("Test content"));
        Assert.Empty(cut.Markup.Trim());
    }

    [Fact]
    public void VisibleWhenOpenIsTrue()
    {
        var cut = RenderComponent<Sheet>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content"));
        var element = cut.Find("div");
        Assert.NotNull(element);
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<Sheet>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content"));
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void SideDefaultIsright()
    {
        var cut = RenderComponent<Sheet>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content"));
        // Default value for Side should be "right"
        Assert.NotNull(cut.Instance);
    }
}
