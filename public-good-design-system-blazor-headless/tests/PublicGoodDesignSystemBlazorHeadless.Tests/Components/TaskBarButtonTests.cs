using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class TaskBarButtonTests : TestContext
{
    [Fact]
    public void RendersAsButton()
    {
        var cut = RenderComponent<TaskBarButton>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("button");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<TaskBarButton>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("button");
        Assert.Contains("task-bar-button", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<TaskBarButton>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<TaskBarButton>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("button");
        var classes = element.GetAttribute("class");
        Assert.Contains("task-bar-button", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<TaskBarButton>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("button");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void RendersDisabledState()
    {
        var cut = RenderComponent<TaskBarButton>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Disabled, true));
        var element = cut.Find("button");
        Assert.True(element.HasAttribute("disabled"));
    }

    [Fact]
    public void RendersEnabledByDefault()
    {
        var cut = RenderComponent<TaskBarButton>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("button");
        Assert.False(element.HasAttribute("disabled"));
    }
}
