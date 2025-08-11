# Collapsible

A collapsible (disclosure) component allows users to expand or collapse a section of content. Built on the native HTML `<details>` and `<summary>` elements, it provides built-in keyboard support and screen reader announcements without any JavaScript.

The summary text is always visible and acts as the toggle trigger. The content below is hidden when collapsed and revealed when expanded. The `open` prop is bindable, enabling parent components to programmatically control or observe the expanded/collapsed state.

## Implementation Notes

- Uses native `<details>` and `<summary>` elements for built-in accessibility support
- The `open` prop uses `$bindable(false)` for two-way binding with `@bind-Open`
- No custom ARIA attributes needed because native elements handle all announcements
- Spreads `AdditionalAttributes` onto the `<details>` element for consumer customization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Summary` | `string` | `—` | The summary value |
| `Open` | `bool` | `—` | The open value |
| `OpenChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Open |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<Collapsible summary="More info">
  <p>Hidden content revealed on expand.</p>
</Collapsible>
```


```razor
<Collapsible summary="Advanced settings" @bind-Open="showAdvanced">
  <p>Advanced configuration options here.</p>
</Collapsible>
```


## Keyboard Interactions

- Enter/Space: Toggle the disclosure open/closed (handled natively by `<summary>`)

## ARIA Attributes

- No custom ARIA attributes required -- native `<details>`/`<summary>` elements provide built-in expanded/collapsed state announcements to screen readers

## References

- WAI-ARIA Disclosure Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/disclosure/
