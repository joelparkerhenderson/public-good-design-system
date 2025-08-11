# TreeNavList

TreeNavList is a headless hierarchical list component that uses the ARIA `tree` role with full keyboard navigation. It provides an accessible container for displaying nested or flat tree structures such as file browsers, organizational charts, or navigation menus.

This component manages keyboard navigation between tree items using ArrowDown, ArrowUp, Home, and End keys with wrapping behavior. Consumers provide the tree items as children with `role="treeitem"` and `tabindex` attributes, and bring their own styling for indentation, expansion indicators, and visual hierarchy.

## Help

Use TreeNavList when you need a hierarchical list with keyboard navigation. Common scenarios include file browsers, folder trees, organizational charts, nested navigation menus, and category selectors. Pair with TreeNavListItem for individual items.

## Syntax

```svelte
<script>
  import TreeNavList from "./TreeNavList.svelte";
</script>

<TreeNavList label="...">
  <!-- TreeNavListItem children -->
</TreeNavList>
```

## Usage

```svelte
<TreeNavList label="File browser">
  <TreeNavListItem tabindex="0">Documents</TreeNavListItem>
  <TreeNavListItem tabindex="-1">Photos</TreeNavListItem>
</TreeNavList>
```

## Props

| Prop | Type | Default | Description |
|------|------|---------|-------------|
| `label` | `string` | (required) | Accessible name for the tree via `aria-label` |
| `children` | `Snippet` | (required) | Tree item elements with `role="treeitem"` to render inside the list |
| `...restProps` | HTML attributes | | Additional attributes spread onto the `<ul>` element |

## Examples

File browser with nesting:

```svelte
<TreeNavList label="Project files">
  <TreeNavListItem tabindex="0" aria-expanded="true">
    src
    <ul role="group">
      <TreeNavListItem tabindex="-1">index.ts</TreeNavListItem>
      <TreeNavListItem tabindex="-1">app.svelte</TreeNavListItem>
    </ul>
  </TreeNavListItem>
  <TreeNavListItem tabindex="-1">package.json</TreeNavListItem>
</TreeNavList>
```

## Keyboard Interactions

- ArrowDown: Moves focus to the next tree item; wraps to the first item after the last
- ArrowUp: Moves focus to the previous tree item; wraps to the last item before the first
- Home: Moves focus to the first tree item
- End: Moves focus to the last tree item

## ARIA

- `role="tree"` -- identifies the container as a tree widget for hierarchical data
- `aria-label={label}` -- provides an accessible name describing the purpose of the tree

## Claude Rules

- Always use `TreeNavList` (not `Tree`)
- Always include the required `label` prop
- Pair with TreeNavListItem for individual items
- Use Svelte 5 patterns (`$state` for refs, Snippet for children)
- Children must have `role="treeitem"` and `tabindex` attributes
- Component is headless/unstyled -- consumer provides all styling

## References

- WAI-ARIA Tree View Pattern: https://www.w3.org/WAI/ARIA/apg/patterns/treeview/
- WAI-ARIA tree role: https://www.w3.org/TR/wai-aria-1.2/#tree
