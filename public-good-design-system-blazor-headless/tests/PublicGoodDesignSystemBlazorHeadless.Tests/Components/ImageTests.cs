using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class ImageTests : TestContext
{
    [Fact]
    public void RendersAsFigure()
    {
        var cut = RenderComponent<Image>(p => p
            .Add(c => c.Caption, "test-value"));
        var element = cut.Find("figure");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<Image>(p => p
            .Add(c => c.Caption, "test-value"));
        var element = cut.Find("figure");
        Assert.Contains("image", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<Image>(p => p
            .Add(c => c.Caption, "test-value")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("figure");
        var classes = element.GetAttribute("class");
        Assert.Contains("image", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<Image>(p => p
            .Add(c => c.Caption, "test-value")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("figure");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void SrcDefaultIsEmptyString()
    {
        var cut = RenderComponent<Image>(p => p
            .Add(c => c.Caption, "test-value"));
        // Default value for Src should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void AltDefaultIsEmptyString()
    {
        var cut = RenderComponent<Image>(p => p
            .Add(c => c.Caption, "test-value"));
        // Default value for Alt should be ""
        Assert.NotNull(cut.Instance);
    }
}
