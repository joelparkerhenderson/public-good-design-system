using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class DataTableRowTests : TestContext
{
    [Fact]
    public void RendersAsTr()
    {
        var cut = RenderComponent<DataTableRow>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("tr");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<DataTableRow>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("tr");
        Assert.Contains("data-table-row", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<DataTableRow>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<DataTableRow>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("tr");
        var classes = element.GetAttribute("class");
        Assert.Contains("data-table-row", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<DataTableRow>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("tr");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }
}
