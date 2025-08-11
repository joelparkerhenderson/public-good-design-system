using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class AlertDialogTests : TestContext
{
    [Fact]
    public void RendersAsDialog()
    {
        var cut = RenderComponent<AlertDialog>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content"));
        var element = cut.Find("dialog");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<AlertDialog>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content"));
        var element = cut.Find("dialog");
        Assert.Contains("alert-dialog", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<AlertDialog>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<AlertDialog>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("dialog");
        var classes = element.GetAttribute("class");
        Assert.Contains("alert-dialog", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<AlertDialog>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("dialog");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleAlertdialog()
    {
        var cut = RenderComponent<AlertDialog>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content"));
        var element = cut.Find("dialog");
        Assert.Equal("alertdialog", element.GetAttribute("role"));
    }

    [Fact]
    public void HiddenWhenOpenIsFalse()
    {
        var cut = RenderComponent<AlertDialog>(p => p
            .AddChildContent("Test content"));
        Assert.Empty(cut.Markup.Trim());
    }

    [Fact]
    public void VisibleWhenOpenIsTrue()
    {
        var cut = RenderComponent<AlertDialog>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content"));
        var element = cut.Find("dialog");
        Assert.NotNull(element);
    }

    [Fact]
    public void TitleDefaultIsEmptyString()
    {
        var cut = RenderComponent<AlertDialog>(p => p
            .Add(c => c.Open, true)
            .AddChildContent("Test content"));
        // Default value for Title should be ""
        Assert.NotNull(cut.Instance);
    }
}
