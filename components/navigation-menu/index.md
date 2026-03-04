# Navigation Menu

A navigation menu provides a semantic `<nav>` landmark with an accessible label, containing navigation links or other interactive elements for site-wide or section-level navigation. It enables screen reader users to quickly locate and jump to the navigation area using landmark navigation, and it clearly communicates the purpose of the enclosed links.

This component is suitable for primary navigation bars, sidebar navigation, footer navigation, breadcrumb wrappers, and any grouped set of navigation links that benefit from landmark semantics.

## Implementation Notes

- Renders a native `<nav>` element, which is automatically recognized as a navigation landmark by screen readers.
- Uses `aria-label` to distinguish this navigation from other `<nav>` elements on the same page (e.g., "Main navigation" vs. "Footer navigation").
- Content is passed via the `children` slot, allowing any markup structure (links, lists, nested menus).
- Spreads `restProps` onto the `<nav>` for consumer customization.
- No internal state or keyboard handling; relies on native link and focus behavior.

## Props

- `label`: string (required) -- accessible name applied via `aria-label` to distinguish this nav landmark.
- `children`: slot (required) -- navigation content to render inside the `<nav>` element.
- `...restProps`: unknown -- additional attributes spread onto the `<nav>` element.

## Usage

```html
<NavigationMenu label="Main navigation">
    <a href="/">Home</a>
    <a href="/about">About</a>
</NavigationMenu>
```

```html
<NavigationMenu label="Footer navigation">
    <ul>
        <li><a href="/privacy">Privacy Policy</a></li>
        <li><a href="/terms">Terms of Service</a></li>
        <li><a href="/contact">Contact Us</a></li>
    </ul>
</NavigationMenu>
```

## Keyboard Interactions

None -- this component is a passive container. Navigation links inside use standard Tab key focus and Enter/Space key activation provided by the browser.

## ARIA

- The `<nav>` element implicitly has `role="navigation"`, making it a navigation landmark.
- `aria-label` -- provides an accessible name to distinguish this navigation from other `<nav>` landmarks on the page.

## When to Use

- Use to wrap a group of navigation links as a semantic `<nav>` landmark for site-wide, section-level, or footer navigation.
- Use when screen reader users need to quickly locate and jump to a navigation region via landmark navigation.
- Avoid using NavigationMenu for action menus or command palettes; use Menu or Command instead.

## Headless

This headless component provides a native `<nav>` element with `aria-label` for landmark identification, automatically recognized by assistive technologies. The consumer provides all visual styling, including link layout, responsive behavior, hover states, and active indicators.

## Advice

- **Designers**: Highlight the current page link in the navigation to orient users, and ensure the navigation is responsive across screen sizes.
- **Developers**: Use distinct `aria-label` values when multiple `<nav>` elements exist on the same page (e.g., "Main navigation" vs. "Footer navigation") so screen reader users can distinguish them.

## References

- WAI-ARIA Navigation Landmark: https://www.w3.org/TR/wai-aria-1.2/#navigation
- WAI-ARIA Landmarks: https://www.w3.org/WAI/ARIA/apd/practices/landmark-regions/
