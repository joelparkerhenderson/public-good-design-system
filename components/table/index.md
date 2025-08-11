# Table

A table is a component used to display structured data in rows and columns, making it easy to compare and analyze information at a glance. Commonly used for reports, schedules, product lists, and dashboards, tables organize content into headers and cells to improve data readability and support efficient decision-making.

This headless table component renders a semantic `<table>` element with an accessible label. The consumer provides all table content (thead, tbody, tfoot, caption, colgroup, etc.) through the children slot, maintaining full control over table structure and styling.

## Implementation Notes

- Renders as a semantic `<table>` element with `aria-label` for accessible naming
- All content (thead, tbody, tfoot, caption, colgroup, etc.) is provided through the `children` slot
- Uses props for prop destructuring with rest props spread
- Consumers are responsible for proper `<th scope="col">` and `<th scope="row">` attributes
- Consumers may add `<caption>` for a visible table title
- No built-in sorting, filtering, or pagination; consumers implement these as needed

## Props

- `label`: string (required) -- accessible label for the table via `aria-label`
- `children`: slot (required) -- table content including thead, tbody, tfoot, etc.
- `...restProps`: any -- additional HTML attributes spread onto the `<table>` element

## Usage

```html
<Table label="User accounts">
    <thead><tr><th scope="col">Name</th><th scope="col">Email</th></tr></thead>
    <tbody><tr><td>Alice</td><td>alice@example.com</td></tr></tbody>
</Table>
```

## Keyboard Interactions

- None directly -- standard table navigation is handled by screen readers and browser built-in behavior

## ARIA

- `aria-label` -- provides the accessible name for the table so screen readers can announce its purpose
- Semantic `<table>` element -- conveys tabular data structure to assistive technologies
- Consumers should use `<th scope="col">` for column headers and `<th scope="row">` for row headers

## When to Use

- Use to display structured tabular data with rows and columns, such as reports, schedules, product lists, or comparison data.
- Use when users need to scan, compare, or analyze data in a grid format.
- Avoid for layout purposes; use CSS Grid or Flexbox for page layout instead.
- Consider a DataTable when you need built-in sorting, filtering, or pagination capabilities.

## Headless

This headless component renders a semantic `<table>` element with `aria-label` for accessible naming. It provides the table structure and leaves all content (thead, tbody, tfoot, caption, colgroup) and visual styling to the consumer, including borders, striping, spacing, and responsive behavior.


## Styles

The consumer provides all CSS styling. The component renders with a `.table` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<table>` element with class `table`
- Verify aria-label` -- provides the accessible name for the table so screen readers can announce its purpose
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Use alternating row colors or subtle borders to improve scannability. Ensure column headers are visually distinct from data cells.
- **Developers**: Always use `<th scope="col">` for column headers and `<th scope="row">` for row headers to ensure screen readers announce headers correctly. Add a `<caption>` element for a visible table title when appropriate.

## References

- WAI-ARIA Table Role: https://www.w3.org/WAI/ARIA/apd/patterns/table/
- HTML Table Element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/table
