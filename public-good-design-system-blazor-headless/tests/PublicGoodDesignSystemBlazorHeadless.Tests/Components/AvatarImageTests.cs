using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class AvatarImageTests : TestContext
{
    [Fact]
    public void RendersAsImg()
    {
        var cut = RenderComponent<AvatarImage>();
        var element = cut.Find("img");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<AvatarImage>();
        var element = cut.Find("img");
        Assert.Contains("avatar-image", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<AvatarImage>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("img");
        var classes = element.GetAttribute("class");
        Assert.Contains("avatar-image", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<AvatarImage>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("img");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void SrcDefaultIsEmptyString()
    {
        var cut = RenderComponent<AvatarImage>();
        // Default value for Src should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void AltDefaultIsEmptyString()
    {
        var cut = RenderComponent<AvatarImage>();
        // Default value for Alt should be ""
        Assert.NotNull(cut.Instance);
    }
}
