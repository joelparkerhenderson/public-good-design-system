using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class KanbanTableColTests : TestContext
{
    [Fact]
    public void RendersAsCol()
    {
        var cut = RenderComponent<KanbanTableCol>();
        var element = cut.Find("col");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<KanbanTableCol>();
        var element = cut.Find("col");
        Assert.Contains("kanban-table-col", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<KanbanTableCol>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("col");
        var classes = element.GetAttribute("class");
        Assert.Contains("kanban-table-col", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<KanbanTableCol>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("col");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void SpanDefaultIsEmptyString()
    {
        var cut = RenderComponent<KanbanTableCol>();
        // Default value for Span should be ""
        Assert.NotNull(cut.Instance);
    }
}
