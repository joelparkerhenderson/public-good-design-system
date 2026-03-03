# SelectWithExtras

SelectWithExtras is a headless enhanced select component that wraps a native `<select>` element with optional content areas before and after it. This allows consumers to place supplementary elements such as icons, flags, status indicators, or helper text alongside the select without breaking its accessibility.

Use SelectWithExtras when you need a native select dropdown with additional visual context. For example, displaying a country flag before a country selector, showing a unit label after a measurement selector, or adding an icon before a category picker. The component preserves full native select behavior including keyboard navigation, form submission, and screen reader support.

## Implementation Notes

- Renders a wrapper `<div>` containing optional `before` snippet, a native `<select>`, and optional `after` snippet
- The `<select>` element receives `aria-label` for accessibility, with `@bind-Value` for two-way binding
- Supports `required` and `disabled` attributes on the native select
- Uses Blazor 5 `@bind-` for the `value` prop, enabling `@bind-Value` from the parent
- The `before` and `after` snippets are conditionally rendered only when provided
- Spreads `AdditionalAttributes` onto the wrapper div for consumer customization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `Required` | `bool` | `—` | The required value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |
| `Before` | `string` | `—` | The before value |
| `After` | `string` | `—` | The after value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<SelectWithExtras label="Country" @bind-Value>
  {#snippet before()}<span>Flag:</span>{/snippet}
  <option value="us">USA</option>
  <option value="uk">United Kingdom</option>
</SelectWithExtras>
```


## Keyboard Interactions

- Tab: Moves focus to the native select element
- Arrow Up / Arrow Down: Navigates between options (native select behavior)
- Space / Enter: Opens the select dropdown on some platforms (native select behavior)
- Escape: Closes the dropdown if open (native select behavior)

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name for the select element so screen readers announce its purpose

## References

- WAI-ARIA Listbox Pattern: https://www.w3.org/WAI/ARIA/apg/patterns/listbox/
- HTML `<select>` element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/select
