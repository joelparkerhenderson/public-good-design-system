# ClipboardCopyButton

A clipboard copy button that copies specified text to the system clipboard when activated. It uses the Clipboard API (`navigator.clipboard.writeText`) and exposes success and error callbacks for consumer-defined feedback.

The component tracks a `copied` state that automatically resets after 2 seconds. This state is exposed via a `data-copied` attribute on the button, allowing consumers to show visual feedback (e.g., a "Copied!" indicator) through CSS selectors like `[data-copied="true"]`.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Text` | `string` | `—` | The text value |
| `Label` | `string` | `—` | Accessible label for the component |
| `OnClick` | `EventCallback<MouseEventArgs>` | `—` | The on click value |
| `ChildContent` | `RenderFragment?` | `—` | Child content to render inside the component |

## Usage


```razor
<ClipboardCopyButton text="https://example.com" label="Copy link" />
```


```razor
<ClipboardCopyButton text=@code label="Copy code" onsuccess=@handleCopied>
  Copy to clipboard
</ClipboardCopyButton>
```



## References

- [Clipboard API](https://developer.mozilla.org/en-US/docs/Web/API/Clipboard/writeText)
