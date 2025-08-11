# Select

A select is a headless component that wraps the native HTML `<select>` element, providing a dropdown menu for choosing one option from a list. It is commonly used in forms for selecting a country, category, status, or any other value from a predefined set of choices.

The consumer provides `<option>` elements as children, giving full control over the available choices. The component uses `aria-label` for accessible naming and supports two-way binding on the selected value.

## Implementation Notes

- Renders a single `<select>` element containing consumer-provided `<option>` children
- Uses `aria-label` for accessible naming instead of a visible `<label>` element
- Supports two-way binding on the `value` prop
- Uses slot for the `children` prop to render `<option>` elements
- Spreads `restProps` onto the select element for consumer extensibility

## Props

- `label`: string (required) -- accessible name applied via `aria-label`
- `value`: string (default: "") -- bindable string representing the currently selected value
- `required`: boolean (default: false) -- whether the select is required for form submission
- `disabled`: boolean (default: false) -- whether the select is disabled
- `children`: slot (required) -- `<option>` elements to render inside the select
- `...restProps`: unknown -- additional attributes spread onto the select element

## Usage

```html
<Select label="Country" value={value}>
  <option value="us">United States</option>
  <option value="uk">United Kingdom</option>
</Select>
```

```html
<Select label="Priority" value={priority} required>
  <option value="">Select priority...</option>
  <option value="low">Low</option>
  <option value="medium">Medium</option>
  <option value="high">High</option>
</Select>
```

```html
<Select label="Status" value={value} disabled={isReadOnly}>
  <option value="active">Active</option>
  <option value="inactive">Inactive</option>
</Select>
```

## Keyboard Interactions

- Tab: Moves focus to and from the select element (native browser behavior)
- Space/Enter: Opens the dropdown list when focused (native browser behavior)
- Arrow Up/Down: Navigates through options (native browser behavior)
- Escape: Closes the dropdown list (native browser behavior)
- Home/End: Jumps to first/last option (native browser behavior)
- Type-ahead: Typing characters jumps to matching options (native browser behavior)

## ARIA

- `aria-label={label}` -- provides an accessible name for the select element since there is no visible `<label>` element
- The `<select>` element implicitly has `role="combobox"` or `role="listbox"` depending on the browser, with built-in accessible semantics

## When to Use

- Use Select for choosing one option from a predefined list, such as country, category, or status fields in forms.
- Use Select when the list of options is moderate in length (roughly 5-15 items) and does not require filtering.
- Avoid using Select for very short lists (2-3 options); use RadioGroup instead to show all options at once.
- Consider Combobox or SelectWithExtras when users need to search or filter a large option list.

## Headless

The Select headless component provides a native `<select>` element with `aria-label` for accessible naming and two-way value binding. Consumer-provided `<option>` children define the available choices. The browser handles all keyboard navigation and dropdown behavior. The consumer provides all visual styling.


## Styles

The consumer provides all CSS styling. The component renders with a `.select` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<select>` element with class `select`
- Verify aria-label={label}` -- provides an accessible name for the select element since there is no visible `<label>` element
- Verify The `<select>` element implicitly has `role="combobox"` or `role="listbox"` depending on the browser, with built-in accessible semantics
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Include a placeholder option (e.g., "Select a country...") as the first item to guide users, and avoid overly long option lists that are hard to scan.
- **Developers**: Set the placeholder option's `value` to an empty string and combine with the `required` prop to enforce selection, ensuring form validation works correctly.

## References

- MDN select element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/select
