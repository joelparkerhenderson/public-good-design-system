# Sidebar

Sidebar is a headless complementary region that uses the semantic `<aside>` element. It provides a labeled landmark for content that is tangentially related to the main content, such as navigation menus, filters, related links, or supplementary information.

Use Sidebar when you need a distinct region alongside main content that assistive technologies can identify and navigate to as a landmark. The `<aside>` element inherently carries the ARIA `complementary` role, so screen readers will announce it as a complementary landmark. The component applies no visual styling, leaving layout, width, positioning, and appearance entirely to the consumer.

## Implementation Notes

- Renders an `<aside>` element, which has an implicit `complementary` landmark role
- The `aria-label` attribute provides an accessible name to distinguish this sidebar from other landmarks
- Spreads `AdditionalAttributes` onto the aside for consumer customization
- Uses Blazor 5 `$props()` with TypeScript typing
- No internal state management; this is a purely structural component

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<Sidebar label="Navigation">
  <nav>...</nav>
</Sidebar>
```


## Keyboard Interactions

None -- this component is a passive container. Keyboard navigation depends on the interactive content placed inside it by the consumer.

## ARIA Attributes

- Implicit `complementary` role via the `<aside>` element -- identifies the container as a complementary landmark
- `aria-label={label}` -- provides an accessible name so screen readers can distinguish this sidebar from other landmarks on the page

## References

- WAI-ARIA Complementary Role: https://www.w3.org/TR/wai-aria-1.2/#complementary
- WAI-ARIA Landmark Regions: https://www.w3.org/WAI/ARIA/apg/practices/landmark-regions/
- HTML `<aside>` element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/aside
