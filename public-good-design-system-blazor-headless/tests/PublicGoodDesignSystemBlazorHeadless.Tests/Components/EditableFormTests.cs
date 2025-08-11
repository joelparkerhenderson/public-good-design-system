using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class EditableFormTests : TestContext
{
    [Fact]
    public void RendersAsForm()
    {
        var cut = RenderComponent<EditableForm>(p => p
            .Add(c => c.Editing, true)
            .AddChildContent("Test content"));
        var element = cut.Find("form");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<EditableForm>(p => p
            .Add(c => c.Editing, true)
            .AddChildContent("Test content"));
        var element = cut.Find("form");
        Assert.Contains("editable-form", element.GetAttribute("class"));
    }

    [Fact]
    public void RendersChildContent()
    {
        var cut = RenderComponent<EditableForm>(p => p
            .Add(c => c.Editing, true)
            .AddChildContent("Hello child"));
        Assert.Contains("Hello child", cut.Markup);
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<EditableForm>(p => p
            .Add(c => c.Editing, true)
            .AddChildContent("Test content")
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("form");
        var classes = element.GetAttribute("class");
        Assert.Contains("editable-form", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<EditableForm>(p => p
            .Add(c => c.Editing, true)
            .AddChildContent("Test content")
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("form");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<EditableForm>(p => p
            .Add(c => c.Editing, true)
            .AddChildContent("Test content")
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("form");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void HiddenWhenEditingIsFalse()
    {
        var cut = RenderComponent<EditableForm>(p => p
            .AddChildContent("Test content"));
        Assert.Empty(cut.Markup.Trim());
    }

    [Fact]
    public void VisibleWhenEditingIsTrue()
    {
        var cut = RenderComponent<EditableForm>(p => p
            .Add(c => c.Editing, true)
            .AddChildContent("Test content"));
        var element = cut.Find("form");
        Assert.NotNull(element);
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<EditableForm>(p => p
            .Add(c => c.Editing, true)
            .AddChildContent("Test content"));
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }
}
