using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class GanttTableRowTests : TestContext
{
    [Fact]
    public void RendersAsTr()
    {
        var cut = RenderComponent<GanttTableRow>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("tr");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<GanttTableRow>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("tr");
        Assert.Contains("gantt-table-row", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<GanttTableRow>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<GanttTableRow>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("tr");
        var classes = element.GetAttribute("class");
        Assert.Contains("gantt-table-row", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<GanttTableRow>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("tr");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }
}
