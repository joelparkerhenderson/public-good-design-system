using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class CalendarTableHeadTests : TestContext
{
    [Fact]
    public void RendersAsThead()
    {
        var cut = RenderComponent<CalendarTableHead>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("thead");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<CalendarTableHead>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("thead");
        Assert.Contains("calendar-table-head", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<CalendarTableHead>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<CalendarTableHead>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("thead");
        var classes = element.GetAttribute("class");
        Assert.Contains("calendar-table-head", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<CalendarTableHead>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("thead");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }
}
