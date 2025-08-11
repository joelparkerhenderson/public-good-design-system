using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class BreadcrumbNavListTests : TestContext
{
    [Fact]
    public void RendersAsOl()
    {
        var cut = RenderComponent<BreadcrumbNavList>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("ol");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<BreadcrumbNavList>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("ol");
        Assert.Contains("breadcrumb-nav-list", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<BreadcrumbNavList>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<BreadcrumbNavList>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("ol");
        var classes = element.GetAttribute("class");
        Assert.Contains("breadcrumb-nav-list", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<BreadcrumbNavList>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("ol");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }
}
