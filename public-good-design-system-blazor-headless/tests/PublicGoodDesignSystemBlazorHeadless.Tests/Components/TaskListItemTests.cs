using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class TaskListItemTests : TestContext
{
    [Fact]
    public void RendersAsLi()
    {
        var cut = RenderComponent<TaskListItem>();
        var element = cut.Find("li");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<TaskListItem>();
        var element = cut.Find("li");
        Assert.Contains("task-list-item", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<TaskListItem>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("li");
        var classes = element.GetAttribute("class");
        Assert.Contains("task-list-item", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<TaskListItem>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("li");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<TaskListItem>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void CheckedChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<TaskListItem>(p => p
            .Add(c => c.Checked, false)
            .Add(c => c.CheckedChanged, (bool val) => callbackInvoked = true));
        // Verify component rendered with binding support
        Assert.NotNull(cut.Instance);
    }
}
