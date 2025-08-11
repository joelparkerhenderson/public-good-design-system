# SlideOutDrawer

A slide-out drawer is a UI/UX component that slides in from the side of the
screen -- usually from the left or right -- to reveal additional content or
navigation options without leaving the current page. Often triggered by a button
or swipe gesture, it is commonly used for menus, filters, settings, or secondary
content in mobile and web applications. This component allows for efficient use
of screen space by keeping less frequently used options hidden until needed,
enhancing focus and minimizing clutter in the main interface while maintaining
easy access to extended functionality.

This component renders as a `<div>` with `role="dialog"`, `aria-label`, and
`aria-modal="true"` when open, and is completely removed from the DOM when
closed. The `open` prop is `@bind-` for two-way binding, and the Escape key
closes the drawer.

## Implementation Notes

- Renders as `<div role="dialog" aria-label={label} aria-modal="true">` when open
- Conditionally rendered with `{#if open}` -- not in the DOM when closed
- The `open` prop is `@bind-` for two-way binding
- Escape key closes the drawer via a keydown handler
- `tabindex="-1"` allows the dialog div to receive focus programmatically

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
@code {

  private bool isOpen = false;;
}

<button @onclick="HandleClick">Open menu</button>

<SlideOutDrawer label="Navigation menu" @bind-Open="isOpen">
  <nav>
    <ul>
      <li><a href="/">Home</a></li>
      <li><a href="/about">About</a></li>
      <li><a href="/contact">Contact</a></li>
    </ul>
  </nav>
  <button @onclick="HandleClick">Close</button>
</SlideOutDrawer>
```

Settings panel:

```razor
@code {

  private bool settingsOpen = false;;
}

<button @onclick="HandleClick">Settings</button>

<SlideOutDrawer label="Settings panel" @bind-Open="settingsOpen">
  <h2>Settings</h2>
  <form>
    <label>
      <input type="checkbox" /> Enable notifications
    </label>
  </form>
</SlideOutDrawer>
```


## Keyboard Interactions

- Escape closes the drawer

## ARIA Attributes

- `role="dialog"` for modal dialog semantics
- `aria-label` from the label prop provides the accessible name
- `aria-modal="true"` indicates modal behavior (content behind the drawer is inert)
- `tabindex="-1"` for programmatic focus management

## References

- WAI-ARIA Dialog Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/dialog-modal/
- WAI-ARIA dialog role: https://www.w3.org/TR/wai-aria-1.2/#dialog
