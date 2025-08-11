# DontListItem

A single discouraged-practice item within a "Don't" list. Renders a semantic `<li>` element representing a guideline or practice that users should avoid. Commonly used in design system documentation, style guides, and instructional content alongside `DoListItem`.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
@code {

}

<ul aria-label="Practices to avoid">
    <DontListItem>Use color alone to convey meaning</DontListItem>
    <DontListItem>Remove focus outlines without replacement</DontListItem>
    <DontListItem>Rely solely on placeholder text as labels</DontListItem>
</ul>
```


