using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class CalendarTableDataTests : TestContext
{
    [Fact]
    public void RendersAsTd()
    {
        var cut = RenderComponent<CalendarTableData>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("td");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<CalendarTableData>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("td");
        Assert.Contains("calendar-table-data", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<CalendarTableData>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<CalendarTableData>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("td");
        var classes = element.GetAttribute("class");
        Assert.Contains("calendar-table-data", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<CalendarTableData>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("td");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleGridcell()
    {
        var cut = RenderComponent<CalendarTableData>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("td");
        Assert.Equal("gridcell", element.GetAttribute("role"));
    }

    [Fact]
    public void AriaSelectedIsTrueWhenSelected()
    {
        var cut = RenderComponent<CalendarTableData>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Selected, true));
        var element = cut.Find("td");
        Assert.Equal("true", element.GetAttribute("aria-selected"));
    }

    [Fact]
    public void AriaSelectedIsFalseWhenNotSelected()
    {
        var cut = RenderComponent<CalendarTableData>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Selected, false));
        var element = cut.Find("td");
        Assert.Equal("false", element.GetAttribute("aria-selected"));
    }
}
