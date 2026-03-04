# Tree Nav

A tree nav is a hierarchical navigation component with expandable branches, rendering as a `<nav>` element that provides a navigation landmark for tree-structured content. It is commonly used for site navigation menus with nested sections, file browsers, documentation sidebars, and category hierarchies. The component contains a TreeNavList with TreeNavListItem children that form the tree structure.

The `<nav>` element provides the navigation landmark, while the nested TreeNavList provides the `role="tree"` semantics and keyboard navigation. This separation allows screen reader users to identify the navigation region and navigate the tree hierarchy within it.

## Implementation Notes

- Renders as a `<nav>` element to create a navigation landmark for the tree structure
- The `label` prop sets `aria-label` to identify the navigation region
- Consumer provides a TreeNavList with TreeNavListItem children inside the nav
- The TreeNavList manages tree keyboard navigation (arrow keys, Home, End)
- Spreads `...restProps` onto the `<nav>` element for consumer customization
- No internal state -- purely a structural wrapper providing the navigation landmark

## Props

- `label`: string (required) -- accessible name for the navigation landmark via `aria-label`
- `children`: slot (required) -- TreeNavList with tree navigation items
- `...restProps`: any -- additional HTML attributes spread onto the `<nav>` element

## Usage

```html
<TreeNav label="Documentation">
    <TreeNavList label="Docs tree">
        <TreeNavListItem tabindex="0" aria-expanded="true">
            Getting Started
            <ul role="group">
                <TreeNavListItem tabindex="-1">Installation</TreeNavListItem>
                <TreeNavListItem tabindex="-1">Quick Start</TreeNavListItem>
            </ul>
        </TreeNavListItem>
        <TreeNavListItem tabindex="-1" aria-expanded="false">
            Components
        </TreeNavListItem>
        <TreeNavListItem tabindex="-1">API Reference</TreeNavListItem>
    </TreeNavList>
</TreeNav>
```

```html
<TreeNav label="File browser">
    <TreeNavList label="Project files">
        <TreeNavListItem tabindex="0">src</TreeNavListItem>
        <TreeNavListItem tabindex="-1">docs</TreeNavListItem>
        <TreeNavListItem tabindex="-1">package.json</TreeNavListItem>
    </TreeNavList>
</TreeNav>
```

## Keyboard Interactions

- ArrowDown: Moves focus to the next visible tree item (managed by TreeNavList)
- ArrowUp: Moves focus to the previous visible tree item (managed by TreeNavList)
- ArrowRight: Expands a collapsed item, or moves to first child
- ArrowLeft: Collapses an expanded item, or moves to parent
- Home: Moves focus to the first tree item
- End: Moves focus to the last visible tree item

## ARIA

- `<nav aria-label="...">` -- creates a navigation landmark with a descriptive label for the tree navigation region
- Tree semantics (`role="tree"`, `role="treeitem"`) are provided by the child TreeNavList and TreeNavListItem components

## References

- WAI-ARIA Tree View Pattern: https://www.w3.org/WAI/ARIA/apg/patterns/treeview/
- WAI-ARIA Navigation Role: https://www.w3.org/TR/wai-aria-1.2/#navigation
