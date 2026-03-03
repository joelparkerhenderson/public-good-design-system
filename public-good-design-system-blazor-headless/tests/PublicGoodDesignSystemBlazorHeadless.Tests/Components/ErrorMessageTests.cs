using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class ErrorMessageTests : TestContext
{
    [Fact]
    public void RendersAsP()
    {
        var cut = RenderComponent<ErrorMessage>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("p");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<ErrorMessage>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("p");
        Assert.Contains("error-message", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<ErrorMessage>(p => p
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<ErrorMessage>(p => p
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("p");
        var classes = element.GetAttribute("class");
        Assert.Contains("error-message", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<ErrorMessage>(p => p
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("p");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void HasRoleAlert()
    {
        var cut = RenderComponent<ErrorMessage>(p => p
            .AddChildContent("Test content"));
        var element = cut.Find("p");
        Assert.Equal("alert", element.GetAttribute("role"));
    }
}
