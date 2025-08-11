# Table Col

## Metadata

- Component: table-col
- PascalCase: TableCol
- Description: a table interactive grid column <th>
- HTML tag: <th>
- CSS class: .table-col
- Interactive: no

## Composition

- Pattern: Table/Head/Body/Foot/Col/Row/Data
- Parent: table

## Key Behaviors

- Renders a `<col>` element for column-level styling within a `<colgroup>`
- Accepts `className` for CSS class targeting
- Spreads `restProps` onto the `<col>` element for consumer customization

## Props

- `className`: string (default: `""`) -- CSS class name for the column
- `...restProps`: unknown -- additional attributes spread onto the `<col>` element

## Acceptance Criteria

- [ ] Renders <th> element with class="table-col"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .table-col in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/table-col.html
- MDN col element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/col
