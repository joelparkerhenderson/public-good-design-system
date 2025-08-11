using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A QR code component provides a headless container for displaying a two-dimensional barcode
/// encoding data such as URLs, text, contact information, or other machine-readable content.
/// Commonly used for sharing links, mobile payments, event check-ins, product information, and
/// authentication workflows, the QR code provides a quick way to transfer information from a screen
/// to a mobile device camera.
/// </summary>
/// <example>
/// <code>
/// &lt;QrCode label="Scan to visit example.com"&gt;
///   &lt;svg&gt;&lt;!-- QR code SVG paths --&gt;&lt;/svg&gt;
/// &lt;/QrCode&gt;
/// </code>
/// </example>
public partial class QrCode : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "qr-code" : $"qr-code {CssClass}";
}
