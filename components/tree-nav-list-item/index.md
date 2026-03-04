# Tree Nav List Item

A tree list item is a single item within a TreeNavList hierarchy, rendered as an `<li>` element with `role="treeitem"`. It supports keyboard focus management via `tabindex` and can represent expandable or leaf nodes in the tree structure.

## Help

Use TreeNavListItem for individual entries within a TreeNavList. Common scenarios include file browser entries, organizational chart nodes, nested navigation items, and category trees. Items can be expandable (branches) or leaf nodes.

## Syntax

```svelte
<script>
  import TreeNavListItem from "./TreeNavListItem.svelte";
</script>

<TreeNavListItem label="...">Label</TreeNavListItem>
```

## Usage

```svelte
<TreeNavList label="File browser">
  <TreeNavListItem tabindex="0">Documents</TreeNavListItem>
  <TreeNavListItem tabindex="-1">Photos</TreeNavListItem>
  <TreeNavListItem tabindex="-1">Music</TreeNavListItem>
</TreeNavList>
```

With expandable items:

```svelte
<TreeNavList label="File browser">
  <TreeNavListItem tabindex="0" aria-expanded="true">
    Documents
    <ul role="group">
      <TreeNavListItem tabindex="-1">Resume.pdf</TreeNavListItem>
      <TreeNavListItem tabindex="-1">Cover Letter.docx</TreeNavListItem>
    </ul>
  </TreeNavListItem>
  <TreeNavListItem tabindex="-1">Photos</TreeNavListItem>
</TreeNavList>
```

## Props

| Prop           | Type            | Default    | Description                                                                                          |
| -------------- | --------------- | ---------- | ---------------------------------------------------------------------------------------------------- |
| `children`     | `Snippet`       | (required) | Content for the tree item                                                                            |
| `...restProps` | HTML attributes |            | Additional attributes spread onto the `<li>` element (including `role`, `tabindex`, `aria-expanded`) |

## Examples

Navigation tree:

```svelte
<TreeNavList label="Site navigation">
  <TreeNavListItem tabindex="0" aria-expanded="false">
    Products
  </TreeNavListItem>
  <TreeNavListItem tabindex="-1" aria-expanded="false">
    Services
  </TreeNavListItem>
  <TreeNavListItem tabindex="-1">About</TreeNavListItem>
</TreeNavList>
```

## Keyboard Interactions

- ArrowDown: Moves focus to the next visible tree item (managed by parent TreeNavList)
- ArrowUp: Moves focus to the previous visible tree item (managed by parent TreeNavList)
- ArrowRight: Expands a collapsed item, or moves to first child (when applicable)
- ArrowLeft: Collapses an expanded item, or moves to parent (when applicable)
- Home: Moves focus to the first tree item (managed by parent TreeNavList)
- End: Moves focus to the last visible tree item (managed by parent TreeNavList)

## ARIA

- `role="treeitem"` -- identifies the element as an item in a tree widget
- `tabindex` -- manages focus: `0` for the active item, `-1` for others (roving tabindex)
- `aria-expanded` -- indicates whether an expandable item is open (`true`) or closed (`false`); omit for leaf nodes
- `aria-selected` -- indicates whether the item is selected (optional)

## Claude Rules

- Always use `TreeNavListItem` (not `TreeItem`)
- Always place inside a TreeNavList container
- Always include `role="treeitem"` (provided by default)
- Always set `tabindex` (`0` for the focused item, `-1` for others)
- Use `aria-expanded` only on expandable branch nodes
- Use Svelte 5 patterns (Snippet for children)
- Component is headless/unstyled -- consumer provides all styling

## References

- WAI-ARIA Tree View Pattern: https://www.w3.org/WAI/ARIA/apg/patterns/treeview/
- WAI-ARIA treeitem role: https://www.w3.org/TR/wai-aria-1.2/#treeitem
