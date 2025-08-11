# ImageInput

An image input is a UI/UX component that provides a graphical form submission button using the native HTML `<input type="image">` element. When clicked within a form, it submits the form and sends the click coordinates (x, y) as part of the form data. The component requires a source image URL and alt text for accessibility.

Image inputs are useful when a form needs a custom graphical submit button rather than a plain text button. They combine the visual richness of an image with the semantic behavior of a form submission control.

## Implementation Notes

- Renders a single `<input type="image">` element for native form submission behavior
- The browser automatically triggers the containing form's `submit` event when clicked
- Requires `src` (image URL) and `alt` (accessible text) props
- Supports optional `width` and `height` props for image dimensions
- Supports rest props via `...restProps` for extensibility (e.g., `id`, `name`, `class`)
- No ARIA attributes needed beyond the native semantics of `<input type="image">`
- When used within a form, clicking this input also triggers built-in browser validation

## Props

- `src`: string (required) -- the URL of the image to display
- `alt`: string (required) -- alternative text describing the image button
- `width`: number (optional) -- the display width of the image in pixels
- `height`: number (optional) -- the display height of the image in pixels
- `disabled`: boolean (default: false) -- whether the input is disabled
- `...restProps`: spread onto the `<input>` element

## Usage

```vue
<ImageInput src="/submit.png" alt="Submit" />
```

```vue
<ImageInput src="/submit.png" alt="Submit" :width="100" :height="40" />
```

```vue
<ImageInput src="/submit.png" alt="Submit" disabled />
```

## Keyboard Interactions

- Enter: activates the image button
- Space: activates the image button

Note: keyboard interactions are provided natively by the `<input type="image">` element.

## ARIA

No additional ARIA attributes are needed. The native `<input type="image">` element has an implicit `button` role and the `alt` attribute serves as its accessible name.

## References

- MDN input type="image": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/image
