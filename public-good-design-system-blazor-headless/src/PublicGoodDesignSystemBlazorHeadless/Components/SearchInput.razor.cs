using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A search input is a UI/UX component that provides a text field specifically for search queries.
/// It uses the native HTML `&lt;input type="search"&gt;` element, which provides semantic meaning
/// and may trigger search-specific browser behaviors such as a clear button or search icon. The
/// component includes aria-label for accessibility and supports bindable value for two-way data
/// binding, making it easy to integrate with search functionality in any application.
/// </summary>
/// <example>
/// <code>
/// &lt;SearchInput label="Search" @bind-Value /&gt;
/// </code>
/// </example>
public partial class SearchInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "search" : $"search {CssClass}";
}
