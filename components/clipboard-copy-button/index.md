# Clipboard Copy Button

A clipboard component provides a button that copies specified text to the system clipboard when activated. It uses the ClipboardCopyButton API (`navigator.clipboard.writeText`) and exposes success and error callbacks for consumer-defined feedback.

The component tracks a `copied` state that automatically resets after 2 seconds. This state is exposed via a `data-copied` attribute on the button, allowing consumers to show visual feedback (e.g., a "Copied!" indicator) through CSS selectors like `[data-copied="true"]`.

## Implementation Notes

- Renders a `<button type="button">` with `aria-label` for the copy action
- Uses `navigator.clipboard.writeText` for async clipboard access
- reactive state tracks `copied` status, which auto-resets to `false` after 2 seconds via `setTimeout`
- The `data-copied` attribute reflects the copied state for CSS-based feedback
- Optional `children` slot allows custom button content
- Callbacks `onsuccess` and `onerror` let consumers respond to copy results

## Props

- `text`: string (required) -- the text to copy to the clipboard
- `label`: string (required) -- accessible label for the copy button via `aria-label`
- `onsuccess`: () => void (default: undefined) -- callback invoked after a successful copy
- `onerror`: (error: unknown) => void (default: undefined) -- callback invoked if the copy fails
- `children`: slot (default: undefined) -- optional custom button content

## Usage

```html
<ClipboardCopyButton text="https://example.com" label="Copy link" />
```

```html
<ClipboardCopyButton text={code} label="Copy code" onsuccess={handleCopied}>
  Copy to clipboard
</ClipboardCopyButton>
```

## Keyboard Interactions

- Enter/Space: Activate the copy button (native button behavior)

## ARIA

- `aria-label` -- describes the copy action for screen readers
- `data-copied` -- reflects `"true"` or `"false"` for CSS-based visual feedback (not an ARIA attribute, but useful for consumer styling)

## When to Use

- Use a ClipboardCopyButton next to text content that users frequently need to copy, such as URLs, code snippets, or API keys.
- Use a ClipboardCopyButton when a one-click copy action improves user efficiency over manual text selection.
- Avoid using a ClipboardCopyButton for content that is rarely copied or where selection-based copying is sufficient.

## Headless

This headless ClipboardCopyButton component provides a `<button>` with `aria-label`, Clipboard API integration (`navigator.clipboard.writeText`), automatic `copied` state tracking with 2-second reset, and `data-copied` attribute for styling hooks. The consumer provides all visual styling including button appearance, copy/success icons, tooltip feedback, and animations.

## Advice

- **Designers**: Provide clear visual feedback when copying succeeds, such as a checkmark icon or "Copied!" text. Keep the button close to the content it copies.
- **Developers**: Use the `data-copied` attribute (e.g., `[data-copied="true"]`) in CSS to show success state. Handle the `onerror` callback for browsers that restrict clipboard access.

## References

- ClipboardCopyButton API: https://developer.mozilla.org/en-US/docs/Web/API/ClipboardCopyButton/writeText
