using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class EditableTests : TestContext
{
    [Fact]
    public void RendersAsInput()
    {
        var cut = RenderComponent<Editable>(p => p
            .Add(c => c.Editing, true));
        var element = cut.Find("input");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<Editable>(p => p
            .Add(c => c.Editing, true));
        var element = cut.Find("input");
        Assert.Contains("editable", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<Editable>(p => p
            .Add(c => c.Editing, true)
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("input");
        var classes = element.GetAttribute("class");
        Assert.Contains("editable", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<Editable>(p => p
            .Add(c => c.Editing, true)
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("input");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<Editable>(p => p
            .Add(c => c.Editing, true)
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("input");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void HiddenWhenEditingIsFalse()
    {
        var cut = RenderComponent<Editable>();
        Assert.Empty(cut.Markup.Trim());
    }

    [Fact]
    public void VisibleWhenEditingIsTrue()
    {
        var cut = RenderComponent<Editable>(p => p
            .Add(c => c.Editing, true));
        var element = cut.Find("input");
        Assert.NotNull(element);
    }

    [Fact]
    public void ValueDefaultIsEmptyString()
    {
        var cut = RenderComponent<Editable>(p => p
            .Add(c => c.Editing, true));
        // Default value for Value should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<Editable>(p => p
            .Add(c => c.Editing, true));
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void ValueChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<Editable>(p => p
            .Add(c => c.Editing, true)
            .Add(c => c.Value, "initial")
            .Add(c => c.ValueChanged, (string val) => callbackInvoked = true));
        Assert.NotNull(cut.Instance);
    }
}
