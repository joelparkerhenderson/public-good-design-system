using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class TimelineListItemTests : TestContext
{
    [Fact]
    public void RendersAsLi()
    {
        var cut = RenderComponent<TimelineListItem>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("li");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<TimelineListItem>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("li");
        Assert.Contains("timeline-list-item", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<TimelineListItem>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<TimelineListItem>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("li");
        var classes = element.GetAttribute("class");
        Assert.Contains("timeline-list-item", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<TimelineListItem>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("li");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }
}
