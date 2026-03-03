# DropdownMenu

A dropdown menu triggered by a button that reveals a list of actions or options. This component combines a toggle button with a menu panel, providing a compact way to present multiple actions or choices without taking up permanent screen space. Common use cases include action menus, settings menus, context-sensitive options, and navigation.

The component manages its own focus lifecycle: when the menu opens, focus moves automatically to the first menu item. Arrow key navigation cycles through items with wrapping, and Escape closes the menu. The trigger button communicates its state to assistive technology via `aria-haspopup` and `aria-expanded`.

## Implementation Notes

- Renders a wrapper `<div>` containing a `<button>` trigger and a conditionally rendered menu `<div>`
- Uses `@bind-` on the `open` prop for two-way binding with the parent
- Uses `private field` to track the `menuRef` DOM reference for querying menu items
- Uses `$effect()` to auto-focus the first `[role="menuitem"]` element when the menu opens
- Menu items are discovered dynamically via `querySelectorAll("[role='menuitem']")`
- ArrowDown/ArrowUp navigation wraps around from last to first and first to last
- Home and End keys jump to first and last menu items respectively
- Escape key closes the menu
- The trigger button displays the `label` text and uses it as `aria-label`
- Spreads `AdditionalAttributes` onto the outer wrapper `<div>`

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Open` | `bool` | `—` | The open value |
| `OpenChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Open |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<DropdownMenu label="Options" @bind-Open>
  <li role="menuitem" tabindex="-1">Edit</li>
  <li role="menuitem" tabindex="-1">Duplicate</li>
  <li role="menuitem" tabindex="-1">Delete</li>
</DropdownMenu>
```


```razor
@code {
  private bool menuOpen = false;;

  function handleAction(action: string) {
    console.log(action);
    menuOpen = false;
  }
}

<DropdownMenu label="Actions" @bind-Open="menuOpen">
  <li role="menuitem" tabindex="-1" @onclick="HandleClick">Edit</li>
  <li role="menuitem" tabindex="-1" @onclick="HandleClick">Delete</li>
</DropdownMenu>
```


## Keyboard Interactions

- Enter or Space (on button): toggles the menu open/closed
- ArrowDown: moves focus to the next menu item, wraps from last to first
- ArrowUp: moves focus to the previous menu item, wraps from first to last
- Home: moves focus to the first menu item
- End: moves focus to the last menu item
- Escape: closes the menu

## ARIA Attributes

- `aria-haspopup="true"` -- on the trigger button, indicates it opens a menu
- `aria-expanded="{open}"` -- on the trigger button, communicates whether the menu is currently shown
- `aria-label="{label}"` -- on both the trigger button and the menu, provides an accessible name
- `role="menu"` -- on the menu container, identifies it as a menu widget
- `role="menuitem"` -- expected on each child item provided by the consumer

## References

- WAI-ARIA Menu Button Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/menubutton/
- WAI-ARIA menu role: https://www.w3.org/TR/wai-aria-1.2/#menu
- WAI-ARIA menuitem role: https://www.w3.org/TR/wai-aria-1.2/#menuitem
