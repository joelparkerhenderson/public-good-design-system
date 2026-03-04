# File Upload

A file upload component provides a button-triggered file picker for uploading files. It combines a hidden file input with a visible button and a live status region that announces how many files have been selected. This pattern is useful for document uploads, image uploads, or any form that accepts file attachments.

## Implementation Notes

- Renders a `<div>` container with a `<button>`, hidden `<input type="file">`, and a status `<span>`
- The button triggers the hidden file input via `click()` on the input ref
- Uses reactive state for the input element reference (`inputRef`) and the selected file count (`fileCount`)
- The status `<span>` uses `aria-live="polite"` to announce file selection changes to screen readers
- Exposes a `data-file-count` attribute on the status span for consumer CSS or testing
- The `onchange` callback receives the native `FileList` object
- Prevents default submit behavior by using `type="button"` on the trigger

## Props

- `label`: string (required) -- accessible name for the upload button, also used as visible button text
- `accept`: string (default: `undefined`) -- accepted file types (e.g., `".pdf"`, `"image/*"`)
- `multiple`: boolean (default: `false`) -- whether to allow selecting multiple files
- `disabled`: boolean (default: `false`) -- whether the button is disabled
- `onchange`: function (default: `undefined`) -- callback receiving `FileList | null` when files are selected
- `...restProps`: unknown -- additional attributes spread onto the outer `<div>`

## Usage

```html
<FileUpload label="Upload files" accept=".pdf" onchange={handleFiles} />
```

## Keyboard Interactions

None beyond native button behavior -- Tab to focus the button, Enter or Space to activate the file picker dialog.

## ARIA

- `aria-label="..."` -- provides an accessible name for the upload button
- `aria-live="polite"` -- on the status span, announces file selection count without interrupting the user

## When to Use

- Use when you want a styled button-triggered file picker with a live status region announcing selected file count.
- Use when a more polished upload experience is needed compared to a raw FileInput.
- Avoid when a simple native file input is sufficient; use FileInput instead.
- Consider a drag-and-drop area pattern when users should be able to drop files directly onto the page.

## Headless

This headless component provides a `<button>` trigger, a hidden `<input type="file">`, and a status `<span>` with `aria-live="polite"` that announces file selection changes. It manages the input ref and file count internally. The consumer provides all visual styling for the button, status text, and overall layout.

## Advice

- **Designers**: Style the upload button prominently and display the file count or file names near the button after selection. Include accepted file type hints in nearby text.
- **Developers**: Use the `onchange` callback to receive the `FileList` for processing. The `data-file-count` attribute on the status span can be used for conditional CSS styling or testing.

## References

- MDN `<input type="file">`: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/file
