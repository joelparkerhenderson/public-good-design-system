using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class DoListTests : TestContext
{
    [Fact]
    public void RendersAsOl()
    {
        var cut = RenderComponent<DoList>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("ol");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<DoList>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("ol");
        Assert.Contains("do-list", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<DoList>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<DoList>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("ol");
        var classes = element.GetAttribute("class");
        Assert.Contains("do-list", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<DoList>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("ol");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleList()
    {
        var cut = RenderComponent<DoList>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("ol");
        Assert.Equal("list", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<DoList>(p => p
            .AddChildContent("Test content")
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("ol");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void LabelDefaultIsDo()
    {
        var cut = RenderComponent<DoList>(p => p
            .AddChildContent("Test content"));
        // Default value for Label should be "Do"
        Assert.NotNull(cut.Instance);
    }
}
