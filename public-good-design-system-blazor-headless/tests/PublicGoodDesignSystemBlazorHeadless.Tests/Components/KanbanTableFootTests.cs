using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class KanbanTableFootTests : TestContext
{
    [Fact]
    public void RendersAsTfoot()
    {
        var cut = RenderComponent<KanbanTableFoot>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("tfoot");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<KanbanTableFoot>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("tfoot");
        Assert.Contains("kanban-table-foot", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<KanbanTableFoot>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<KanbanTableFoot>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("tfoot");
        var classes = element.GetAttribute("class");
        Assert.Contains("kanban-table-foot", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<KanbanTableFoot>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("tfoot");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }
}
