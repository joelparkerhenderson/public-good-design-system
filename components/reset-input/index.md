# Reset Input

A reset input is a UI/UX component that provides a form reset button using the native HTML `<input type="reset">` element. When clicked within a form, it resets all form fields to their initial values. The component supports custom button text through the value prop and can be disabled when form resetting should be prevented.

Reset inputs are useful in forms where users may want to clear all entered data and start over. They rely on the browser's built-in form reset behavior, which restores each field to its default value attribute.

## Implementation Notes

- Renders a single `<input type="reset">` element for native form reset behavior
- The browser automatically handles resetting all sibling form fields when clicked
- Default button text is "Reset", configurable via the `value` prop
- Supports rest props via `...restProps` for extensibility (e.g., `id`, `name`, `class`)
- No ARIA attributes needed beyond the native semantics of `<input type="reset">`

## Props

- `value`: string (default: "Reset") -- the visible button text
- `disabled`: boolean (default: false) -- whether the button is disabled
- `...restProps`: spread onto the `<input>` element

## Usage

```html
<ResetInput />
```

```html
<ResetInput value="Clear form" />
```

```html
<ResetInput value="Start over" disabled={!formDirty} />
```

## Keyboard Interactions

- Enter: activates the reset button
- Space: activates the reset button

Note: keyboard interactions are provided natively by the `<input type="reset">` element.

## ARIA

No additional ARIA attributes are needed. The native `<input type="reset">` element has an implicit `button` role and the `value` attribute serves as its accessible name.

## When to Use

- Use ResetInput in forms where users may want to clear all entered data and restore fields to their initial values.
- Use ResetInput alongside SubmitInput to provide a complete set of form actions.
- Avoid using ResetInput on forms with many fields or long workflows, as accidental resets can frustrate users.
- Consider a confirmation dialog before resetting if the form contains significant user input.

## Headless

The ResetInput headless component provides a native `<input type="reset">` with configurable button text via the `value` prop and `disabled` state. The browser handles all form reset behavior natively. The consumer provides all visual styling for the button appearance.


## Styles

The consumer provides all CSS styling. The component renders with a `.reset-input` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<input>` element with class `reset-input`
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Style the reset button with less visual emphasis than the submit button to reduce accidental clicks, and position it away from the primary action.
- **Developers**: Use the `disabled` prop to disable reset when the form is in its initial state (not dirty), preventing unnecessary resets.

## References

- MDN input type="reset": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/reset
