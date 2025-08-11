# Textarea

A textarea is a headless component that wraps the native HTML `<textarea>` element, providing a multi-line text input area. It is commonly used in forms for comments, messages, descriptions, feedback, code input, and any scenario where users need to enter extended text content.

Unlike a single-line text input, a textarea provides a larger, scrollable text area that supports multiple lines. The component uses `aria-label` for accessible naming and supports two-way binding on the value.

## Implementation Notes

- Renders a single `<textarea>` element with no wrapper
- Uses `aria-label` for accessible naming instead of a visible `<label>` element
- Supports two-way binding on the `value` prop
- The `rows` prop controls the visible height of the text area
- Spreads `restProps` onto the textarea element for consumer extensibility

## Props

- `label`: string (required) -- accessible name applied via `aria-label`
- `value`: string (default: "") -- bindable text content of the textarea
- `rows`: number (default: undefined) -- number of visible text rows (browser default if unset)
- `required`: boolean (default: false) -- whether the textarea is required for form submission
- `disabled`: boolean (default: false) -- whether the textarea is disabled
- `...restProps`: unknown -- additional attributes spread onto the textarea element

## Usage

```html
<Textarea label="Comments" value={value} rows={5} />
```

```html
<Textarea label="Description" value={description} required />
```

```html
<Textarea label="Notes" value={value} disabled={isReadOnly} />
```

## Keyboard Interactions

- Tab: Moves focus to and from the textarea (native browser behavior)
- All standard text editing keys function normally within the textarea (native browser behavior)
- Enter: Inserts a new line (does not submit forms, unlike single-line inputs)

## ARIA

- `aria-label={label}` -- provides an accessible name for the textarea since there is no visible `<label>` element

## When to Use

- Use for multi-line text entry such as comments, messages, descriptions, feedback, or code input.
- Use when the expected input is longer than a single line and benefits from a larger, scrollable text area.
- Avoid for short, single-line text; use TextInput instead.
- Consider adding a CharacterCounter alongside the Textarea when there is a maximum length constraint.

## Headless

This headless component renders a native `<textarea>` element with `aria-label`, two-way value binding, and configurable `rows`. It provides multi-line text input semantics with required/disabled states. The consumer provides all visual styling including borders, padding, resize behavior, and responsive sizing.


## Styles

The consumer provides all CSS styling. The component renders with a `.textarea` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<textarea>` element with class `textarea`
- Verify aria-label={label}` -- provides an accessible name for the textarea since there is no visible `<label>` element
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Set a visible height (via `rows`) that reflects the expected content length. Allow vertical resizing so users can expand the area if needed.
- **Developers**: Use the `rows` prop to set an appropriate initial height. Wrap the textarea with a Field and Label component for a complete accessible form field. Consider debouncing the bound value for expensive reactive operations.

## References

- MDN textarea element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/textarea
