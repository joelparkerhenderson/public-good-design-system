# FileInput

A file input wraps a native `<input type="file">` element with accessible labelling. It allows users to select one or more files from their device for upload. The component supports filtering by accepted file types, multiple file selection, and standard form states.

This component is useful in upload forms, profile editors, document management interfaces, and anywhere users need to attach files. It provides a headless wrapper around the native file picker, leaving all visual presentation to the consumer.

## Implementation Notes

- Renders a native `<input type="file">` element
- Uses `aria-label` for accessible naming (no visible label element included; consumers can add their own)
- Supports `accept` attribute for restricting file types (e.g., `"image/*"`, `".pdf,.doc"`)
- Supports `multiple` attribute for allowing selection of more than one file
- Supports standard HTML form attributes: `required`, `disabled`
- Spreads `AdditionalAttributes` for consumer customization (e.g., `capture`, event handlers)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Accept` | `string?` | `—` | The accept value |
| `Multiple` | `bool` | `—` | The multiple value |
| `Required` | `bool` | `—` | The required value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<FileInput label="Upload photo" accept="image/*" />
```


```razor
<FileInput label="Attach documents" accept=".pdf,.doc,.docx" multiple=@true />
```


```razor
<FileInput label="Profile picture" accept="image/png,image/jpeg" required=@true />
```


## Keyboard Interactions

None beyond native input behavior -- **Enter** or **Space** opens the file picker dialog when the input is focused (browser-native behavior).

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name for the file input since no visible `<label>` element is included

## References

- MDN input type="file": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/file
