# Tree Nav List

## Metadata

- Component: tree-nav-list
- PascalCase: TreeNavList
- Description: a hierarchical list with nested expandable items
- HTML tag: <ol>
- CSS class: .tree-nav-list
- Interactive: yes

## Composition

- Pattern: Nav/List/ListItem
- Parent: tree-nav
- Children: tree-nav-list-item

## ARIA

- `role="tree"` -- identifies the container as a tree widget for hierarchical data
- `aria-label={label}` -- provides an accessible name describing the purpose of the tree

## Keyboard

- ArrowDown: Moves focus to the next tree item; wraps to the first item after the last
- ArrowUp: Moves focus to the previous tree item; wraps to the last item before the first
- Home: Moves focus to the first tree item
- End: Moves focus to the last tree item

## Acceptance Criteria

- [ ] Renders <ol> element with class="tree-nav-list"
- [ ] Has aria-label attribute
- [ ] Has role="tree"
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .tree-nav-list in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/tree-nav-list.html
- WAI-ARIA Tree View Pattern: https://www.w3.org/WAI/ARIA/apg/patterns/treeview/
- WAI-ARIA tree role: https://www.w3.org/TR/wai-aria-1.2/#tree
