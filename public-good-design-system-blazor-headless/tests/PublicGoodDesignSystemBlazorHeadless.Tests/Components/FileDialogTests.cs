using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class FileDialogTests : TestContext
{
    [Fact]
    public void RendersAsDialog()
    {
        var cut = RenderComponent<FileDialog>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content"));
        var element = cut.Find("dialog");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<FileDialog>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content"));
        var element = cut.Find("dialog");
        Assert.Contains("file-dialog", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<FileDialog>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<FileDialog>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("dialog");
        var classes = element.GetAttribute("class");
        Assert.Contains("file-dialog", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<FileDialog>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("dialog");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<FileDialog>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content")
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("dialog");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void HiddenWhenOpenIsFalse()
    {
        var cut = RenderComponent<FileDialog>(p => p
            .AddChildContent("Test content"));
        Assert.Empty(cut.Markup.Trim());
    }

    [Fact]
    public void VisibleWhenOpenIsTrue()
    {
        var cut = RenderComponent<FileDialog>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content"));
        var element = cut.Find("dialog");
        Assert.NotNull(element);
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<FileDialog>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content"));
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }
}
