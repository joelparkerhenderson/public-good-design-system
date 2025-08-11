# Data Filter Form

A data filter component allows users to narrow down a dataset by applying criteria. It wraps filter controls in a semantic `<form>` element with `role="search"` and accessible labelling via `aria-label`. Consumers provide their own filter inputs, submit buttons, and reset buttons as children.

The component prevents default form submission behavior, allowing the consumer's `onsubmit` callback to handle filter application programmatically. This makes it suitable for client-side filtering, AJAX-based search, or any scenario where a full page reload is undesirable.

## Implementation Notes

- Renders a `<form>` element with `role="search"` for assistive technology
- Calls `event.preventDefault()` on submit to allow consumer-controlled filter logic
- Passes `onreset` directly to the form for native reset behavior
- Spreads `restProps` onto the `<form>` for consumer customization

## Props

- `label`: string (required) -- accessible name for the filter region, applied as `aria-label`
- `onsubmit`: (event: SubmitEvent) => void (default: undefined) -- callback when the filter form is submitted
- `onreset`: (event: Event) => void (default: undefined) -- callback when the filter form is reset
- `children`: slot (required) -- filter controls rendered inside the form

## Usage

```html
<DataFilterForm label="Filter results" onsubmit={applyFilters}>
  <label>Category <select>...</select></label>
  <button type="submit">Apply</button>
</DataFilterForm>
```

## Keyboard Interactions

None -- this component is a passive container. Keyboard behavior is determined by the consumer-provided form controls within the children.

## ARIA

- `role="search"` -- identifies the form as a search landmark for assistive technology
- `aria-label={label}` -- provides an accessible name for the search region

## When to Use

- Use a DataFilterForm to wrap filter controls that narrow down a dataset, such as search criteria, category selectors, or date range pickers.
- Use a DataFilterForm when filters should be submitted together as a group, with client-side or AJAX-based filtering rather than a full page reload.
- Avoid using a DataFilterForm for single-input search fields; consider a SearchInput instead.

## Headless

This headless DataFilterForm component provides a `<form>` with `role="search"` and `aria-label` for semantic landmark identification, plus `preventDefault` on submit for consumer-controlled filter logic. The consumer provides all visual styling including filter input layout, submit/reset button appearance, spacing, and responsive behavior.


## Styles

The consumer provides all CSS styling. The component renders with a `.data-filter-form` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<form>` element with class `data-filter-form`
- Verify role="search"` -- identifies the form as a search landmark for assistive technology
- Verify aria-label={label}` -- provides an accessible name for the search region
- Verify pass-through attributes are applied

## Advice

- **Designers**: Group related filter controls visually and provide clear "Apply" and "Reset" actions. Show the active filter count or summary to indicate what is currently filtered.
- **Developers**: Handle filtering in the `onsubmit` callback since default submission is prevented. Use `onreset` to clear filter state. Provide consumer form controls as children.

## References

- WAI-ARIA Landmark Roles: https://www.w3.org/WAI/ARIA/apd/practices/landmark-regions/
- ARIA search role: https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/Roles/search_role
