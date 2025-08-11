# ImageFileInput

An image input provides a file upload control that is pre-configured to accept image files. It wraps a native `<input type="file">` element with accessible labeling and sensible defaults for image selection. This component is useful for profile photo uploads, gallery image selection, document scanning, and any form that requires image file input.

The consumer can override the accepted file types, control required/disabled states, and add additional attributes as needed.

## Implementation Notes

- Renders a single `<input type="file">` element with `accept="image/*"` by default.
- Uses `aria-label` for accessible naming since there is no visible `<label>` element.
- Supports `required` and `disabled` native input attributes.
- The `accept` prop defaults to `"image/*"` but can be narrowed (e.g., `"image/png, image/jpeg"`).
- Spreads `AdditionalAttributes` onto the `<input>` for consumer customization.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Accept` | `string?` | `image/*` | The accept value |
| `Required` | `bool` | `—` | The required value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<ImageFileInput label="Upload profile photo" />
```


```razor
<ImageFileInput label="Upload document scan" accept="image/png, image/jpeg" required />
```


## Keyboard Interactions

None -- this component uses the native `<input type="file">` element, which provides built-in keyboard support (Tab to focus, Enter or Space to open the file picker dialog).

## ARIA Attributes

- `aria-label` -- provides an accessible name for the file input when no visible label is present.

## References

- MDN Input type="file": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/file
