# BackLink

A back link is a navigational component that allows users to return to a previous page or step within an application. It renders as a semantic anchor (`<a>`) element with optional `aria-label` for enhanced screen reader context.

Back links are especially important in mobile and multi-step interfaces, helping users maintain their sense of orientation and providing a clear, intuitive way to reverse navigation without relying solely on the browser's back button. Consumers add visual indicators (left arrow, chevron) via CSS or children content.

## Implementation Notes

- Renders as a semantic `<a>` element for backward navigation
- Same HTML pattern as a standard link but semantically represents "going back"
- Supports an optional `aria-label` override for more descriptive screen reader text
- All link text is provided through the ChildContent render fragment
- Spreads `AdditionalAttributes` onto the `<a>` element

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Href` | `string` | `—` | The href value |
| `Label` | `string?` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<BackLink href="/previous-page">Back to previous page</BackLink>
<BackLink href="/dashboard" label="Return to dashboard">Back</BackLink>
```


## Keyboard Interactions

- Tab: Focus the link
- Enter: Activate the link (browser default)

## ARIA Attributes

- Implicit `link` role from the `<a>` element
- `aria-label` -- optional override for descriptive screen reader text, set from the `label` prop
