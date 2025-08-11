using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A file manager is a component that provides an interface for browsing, organizing, and managing
/// files and directories. Commonly used in content management systems, cloud storage applications,
/// document editors, and admin dashboards, the file manager enables users to navigate folder
/// hierarchies, view file listings, and perform operations such as uploading, downloading,
/// renaming, and deleting files.
/// </summary>
/// <example>
/// <code>
/// &lt;FileManager label="Project files"&gt;
///     &lt;ul&gt;
///         &lt;li&gt;document.pdf&lt;/li&gt;
///         &lt;li&gt;image.png&lt;/li&gt;
///         &lt;li&gt;data.csv&lt;/li&gt;
///     &lt;/ul&gt;
/// &lt;/FileManager&gt;
/// </code>
/// </example>
public partial class FileManager : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "file-manager" : $"file-manager {CssClass}";
}
