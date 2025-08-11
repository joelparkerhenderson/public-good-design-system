using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class GanttTableBodyTests : TestContext
{
    [Fact]
    public void RendersAsTbody()
    {
        var cut = RenderComponent<GanttTableBody>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("tbody");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<GanttTableBody>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("tbody");
        Assert.Contains("gantt-table-body", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<GanttTableBody>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<GanttTableBody>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("tbody");
        var classes = element.GetAttribute("class");
        Assert.Contains("gantt-table-body", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<GanttTableBody>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("tbody");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }
}
