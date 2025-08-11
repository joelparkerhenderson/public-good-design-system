# Calendar Table Col

## Metadata

- Component: calendar-table-col
- PascalCase: CalendarTableCol
- Description: a calendar table interactive grid column for managing dates, days, etc. <th>
- HTML tag: <th>
- CSS class: .calendar-table-col
- Interactive: no

## Composition

- Pattern: Table/Head/Body/Foot/Col/Row/Data
- Parent: calendar-table

## Key Behaviors

- Renders a `<col>` element for column-level styling within a `<colgroup>`
- Accepts `className` for CSS class targeting
- Spreads `restProps` onto the `<col>` element for consumer customization

## Props

- `className`: string (default: `""`) -- CSS class name for the column
- `...restProps`: unknown -- additional attributes spread onto the `<col>` element

## Acceptance Criteria

- [ ] Renders <th> element with class="calendar-table-col"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .calendar-table-col in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/calendar-table-col.html
- MDN col element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/col
