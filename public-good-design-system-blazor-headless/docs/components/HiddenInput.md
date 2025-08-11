# HiddenInput

HiddenInput is a headless component that renders a native `<input type="hidden">` element for passing data in forms that should not be visible or editable by the user. It provides a simple, type-safe way to include hidden form values such as CSRF tokens, record IDs, or other metadata that must be submitted with a form.

This component is useful whenever a form needs to carry data that the user should not see or modify directly. The hidden input participates in form submission but has no visual presence, no keyboard interaction, and no ARIA requirements since it is not perceivable.

## Implementation Notes

- Renders a native `<input type="hidden">` element
- Requires a `name` prop for the form field name
- The `value` prop defaults to an empty string
- Spreads `AdditionalAttributes` onto the input for consumer customization (e.g., `id`, `data-*` attributes)
- No ARIA attributes needed because hidden inputs are not perceivable by any user

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Name` | `string` | `—` | The name value |
| `Value` | `string?` | `—` | The value value |

## Usage


```razor
<HiddenInput name="csrf" value=@token />
```


## Keyboard Interactions

None -- hidden inputs are not visible or focusable and have no keyboard interaction.

## ARIA Attributes

None -- hidden inputs are not perceivable by users or assistive technologies, so no ARIA attributes are needed.

## References

- HTML hidden input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/hidden
