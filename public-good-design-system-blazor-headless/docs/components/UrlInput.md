# UrlInput

A URL input is a UI/UX component that provides a text field specifically for entering web addresses. It uses the native HTML `<input type="url">` element, which provides built-in URL validation and may trigger URL-specific keyboard layouts on mobile devices. The component includes aria-label for accessibility and supports bindable value for two-way data binding, along with standard form attributes like required and disabled.

URL inputs are commonly used in profile forms, link submission pages, and any context where users need to enter a valid web address. The browser's built-in validation ensures the entered value matches URL format before form submission.

## Implementation Notes

- Renders a single `<input type="url">` element for semantic URL input with built-in validation
- Uses `@bind-` for the `value` prop enabling two-way data binding with `@bind-Value`
- The `aria-label` prop provides an accessible name since there is no visible `<label>` element
- Supports additional attributes via `AdditionalAttributes` for extensibility (e.g., `id`, `name`, `placeholder`, `pattern`, `class`)
- Browser-native validation requires a valid URL format (including protocol) on form submission when `required` is set

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `Required` | `bool` | `—` | The required value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<UrlInput label="Website URL" @bind-Value />
```


```razor
<UrlInput label="Portfolio link" @bind-Value="portfolioUrl" required />
```


## Keyboard Interactions

None beyond native text input behavior. The `<input type="url">` element supports standard text editing keys (typing, selection, clipboard-copy-button operations) natively.

## ARIA Attributes

- `aria-label={label}` -- provides the accessible name for the URL input since no visible label element is associated

## References

- MDN input type="url": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/url
