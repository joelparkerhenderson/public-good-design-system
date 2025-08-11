# Kanban Table Col

## Metadata

- Component: kanban-table-col
- PascalCase: KanbanTableCol
- Description: a kanban board table interactive grid column for organizing items by status <th>
- HTML tag: <th>
- CSS class: .kanban-table-col
- Interactive: no

## Composition

- Pattern: Table/Head/Body/Foot/Col/Row/Data
- Parent: kanban-table

## Key Behaviors

- Renders a `<col>` element for column-level styling within a `<colgroup>`
- Accepts `className` for CSS class targeting
- Spreads `restProps` onto the `<col>` element for consumer customization

## Props

- `className`: string (default: `""`) -- CSS class name for the column
- `...restProps`: unknown -- additional attributes spread onto the `<col>` element

## Acceptance Criteria

- [ ] Renders <th> element with class="kanban-table-col"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .kanban-table-col in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/kanban-table-col.html
- MDN col element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/col
