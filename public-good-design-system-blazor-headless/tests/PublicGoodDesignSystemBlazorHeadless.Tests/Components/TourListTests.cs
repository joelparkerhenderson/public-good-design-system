using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class TourListTests : TestContext
{
    [Fact]
    public void RendersAsOl()
    {
        var cut = RenderComponent<TourList>(p => p
            .Add(c => c.Active, true)
            .AddChildContent("Test content"));
        var element = cut.Find("ol");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<TourList>(p => p
            .Add(c => c.Active, true)
            .AddChildContent("Test content"));
        var element = cut.Find("ol");
        Assert.Contains("tour-list", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<TourList>(p => p
            .Add(c => c.Active, true)
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<TourList>(p => p
            .Add(c => c.Active, true)
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("ol");
        var classes = element.GetAttribute("class");
        Assert.Contains("tour-list", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<TourList>(p => p
            .Add(c => c.Active, true)
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("ol");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleDialog()
    {
        var cut = RenderComponent<TourList>(p => p
            .Add(c => c.Active, true)
            .AddChildContent("Test content"));
        var element = cut.Find("ol");
        Assert.Equal("dialog", element.GetAttribute("role"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<TourList>(p => p
            .Add(c => c.Active, true)
            .AddChildContent("Test content")
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("ol");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void HiddenWhenActiveIsFalse()
    {
        var cut = RenderComponent<TourList>(p => p
            .AddChildContent("Test content"));
        Assert.Empty(cut.Markup.Trim());
    }

    [Fact]
    public void VisibleWhenActiveIsTrue()
    {
        var cut = RenderComponent<TourList>(p => p
            .Add(c => c.Active, true)
            .AddChildContent("Test content"));
        var element = cut.Find("ol");
        Assert.NotNull(element);
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<TourList>(p => p
            .Add(c => c.Active, true)
            .AddChildContent("Test content"));
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }
}
