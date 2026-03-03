# ResetInput

A reset input is a UI/UX component that provides a form reset button using the native HTML `<input type="reset">` element. When clicked within a form, it resets all form fields to their initial values. The component supports custom button text through the value prop and can be disabled when form resetting should be prevented.

Reset inputs are useful in forms where users may want to clear all entered data and start over. They rely on the browser's built-in form reset behavior, which restores each field to its default value attribute.

## Implementation Notes

- Renders a single `<input type="reset">` element for native form reset behavior
- The browser automatically handles resetting all sibling form fields when clicked
- Default button text is "Reset", configurable via the `value` prop
- Supports additional attributes via `AdditionalAttributes` for extensibility (e.g., `id`, `name`, `class`)
- No ARIA attributes needed beyond the native semantics of `<input type="reset">`

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Value` | `string?` | `Reset` | The value value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<ResetInput />
```


```razor
<ResetInput value="Clear form" />
```


```razor
<ResetInput value="Start over" disabled={!formDirty} />
```


## Keyboard Interactions

- Enter: activates the reset button
- Space: activates the reset button

Note: keyboard interactions are provided natively by the `<input type="reset">` element.

## ARIA Attributes

No additional ARIA attributes are needed. The native `<input type="reset">` element has an implicit `button` role and the `value` attribute serves as its accessible name.

## References

- MDN input type="reset": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/reset
