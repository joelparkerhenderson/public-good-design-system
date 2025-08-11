# Radio Input

A radio input provides a bare `<input type="radio">` element without a wrapping label. It is designed for use in custom radio group layouts where labels are provided separately or by a parent component. The component uses `aria-label` to ensure each radio button has an accessible name.

This component is useful in custom-designed radio groups, card selection interfaces, segmented controls, and any layout where the radio button and its label need to be independently positioned or styled. For simple radio groups with adjacent labels, consider wrapping this in a `<label>` element.

## Implementation Notes

- Renders a native `<input type="radio">` element
- Uses `aria-label` for accessible naming (no visible label element included)
- Supports `name` attribute for grouping radio buttons into a mutually exclusive set
- Supports `value` attribute for identifying which option is selected
- Supports `checked` and `disabled` states
- Does not use two-way binding for checked state; consumers can use event handlers or bind directly
- Spreads `restProps` for consumer customization (e.g., `onchange`, `id`)

## Props

- `label`: string (required) -- accessible name via `aria-label`
- `name`: string (default: `undefined`) -- radio group name for mutual exclusion
- `value`: string (default: `undefined`) -- the value representing this radio option
- `checked`: boolean (default: `false`) -- whether this radio button is currently selected
- `disabled`: boolean (default: `false`) -- whether the radio button is disabled
- `...restProps`: any additional HTML attributes spread onto the input

## Usage

```html
<RadioInput label="Option A" name="choice" value="a" />
```

```html
<RadioInput label="Small" name="size" value="small" checked={true} />
<RadioInput label="Medium" name="size" value="medium" />
<RadioInput label="Large" name="size" value="large" />
```

```html
<RadioInput label="Unavailable option" name="plan" value="enterprise" disabled={true} />
```

## Keyboard Interactions

Native radio input keyboard behavior is handled by the browser:

- **Tab**: Moves focus to the selected radio in the group (or the first if none selected)
- **Arrow Up / Arrow Left**: Moves selection to the previous radio in the group
- **Arrow Down / Arrow Right**: Moves selection to the next radio in the group
- **Space**: Selects the focused radio button (if not already selected)

## ARIA

- `aria-label={label}` -- provides an accessible name for the radio button since no visible `<label>` element is included

## When to Use

- Use RadioInput inside a RadioGroup when you need custom radio button layouts where the radio and its label are independently positioned or styled.
- Use RadioInput for card-selection interfaces, segmented controls, or any design that wraps radio buttons in non-standard visual containers.
- Avoid using RadioInput outside of a group context; always pair with RadioGroup or a native fieldset for proper semantics.

## Headless

The RadioInput headless component provides a native `<input type="radio">` with `aria-label` for accessible naming, and supports `name`, `value`, `checked`, and `disabled` attributes. The browser handles all radio group keyboard navigation natively. The consumer provides all visual styling.


## Styles

The consumer provides all CSS styling. The component renders with a `.radio-input` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<input>` element with class `radio-input`
- Verify aria-label={label}` -- provides an accessible name for the radio button since no visible `<label>` element is included
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Ensure the clickable area around each radio option is large enough for comfortable touch interaction, even when using custom visual designs.
- **Developers**: Always set a consistent `name` attribute across grouped RadioInput components to ensure mutual exclusion, and use `onchange` handlers to update state.

## References

- WAI-ARIA Radio Group Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/radiobutton/
- MDN input type="radio": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/radio
