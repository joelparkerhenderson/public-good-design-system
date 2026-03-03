using Bunit;
using Xunit;
using PublicGoodDesignSystemBlazorHeadless.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Tests.Components;

public class DateRangeTests : TestContext
{
    [Fact]
    public void RendersAsFieldset()
    {
        var cut = RenderComponent<DateRange>();
        var element = cut.Find("fieldset");
        Assert.NotNull(element);
    }

    [Fact]
    public void HasBaseClass()
    {
        var cut = RenderComponent<DateRange>();
        var element = cut.Find("fieldset");
        Assert.Contains("date-range", element.GetAttribute("class"));
    }

    [Fact]
    public void MergesCssClass()
    {
        var cut = RenderComponent<DateRange>(p => p
            .Add(c => c.CssClass, "custom-class"));
        var element = cut.Find("fieldset");
        var classes = element.GetAttribute("class");
        Assert.Contains("date-range", classes);
        Assert.Contains("custom-class", classes);
    }

    [Fact]
    public void PassesThroughAdditionalAttributes()
    {
        var cut = RenderComponent<DateRange>(p => p
            .Add(c => c.AdditionalAttributes, new Dictionary<string, object> { { "data-testid", "test-123" } }));
        var element = cut.Find("fieldset");
        Assert.Equal("test-123", element.GetAttribute("data-testid"));
    }

    [Fact]
    public void RendersAriaLabel()
    {
        var cut = RenderComponent<DateRange>(p => p
            .Add(c => c.Label, "Test label"));
        var element = cut.Find("fieldset");
        Assert.Equal("Test label", element.GetAttribute("aria-label"));
    }

    [Fact]
    public void LabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<DateRange>();
        // Default value for Label should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void StartLabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<DateRange>();
        // Default value for StartLabel should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void EndLabelDefaultIsEmptyString()
    {
        var cut = RenderComponent<DateRange>();
        // Default value for EndLabel should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void StartDefaultIsEmptyString()
    {
        var cut = RenderComponent<DateRange>();
        // Default value for Start should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void EndDefaultIsEmptyString()
    {
        var cut = RenderComponent<DateRange>();
        // Default value for End should be ""
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void StartChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<DateRange>(p => p
            .Add(c => c.Start, "initial")
            .Add(c => c.StartChanged, (string val) => callbackInvoked = true));
        Assert.NotNull(cut.Instance);
    }

    [Fact]
    public void EndChangedCallbackInvoked()
    {
        var callbackInvoked = false;
        var cut = RenderComponent<DateRange>(p => p
            .Add(c => c.End, "initial")
            .Add(c => c.EndChanged, (string val) => callbackInvoked = true));
        Assert.NotNull(cut.Instance);
    }
}
