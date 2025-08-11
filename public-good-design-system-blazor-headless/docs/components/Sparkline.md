# Sparkline

A sparkline is a compact, minimalist component used to represent trends or variations in data within a small, simple graph, typically embedded within text or tables. Unlike full-scale charts, sparklines display data as tiny, unadorned line, bar, or win/loss charts, offering a quick at-a-glance view of patterns such as fluctuations in sales, stock prices, or performance over time.

This headless component provides a semantic container with `role="img"` and an accessible label. The consumer is responsible for providing the actual SVG, canvas, or other visualization content as children.

## Implementation Notes

- Renders a `<div>` with `role="img"` to semantically represent a graphical image
- Consumer provides all chart rendering (SVG, canvas, etc.) via the `ChildContent` snippet
- Accepts `AdditionalAttributes` for forwarding additional attributes to the container
- No internal state or effects -- purely a structural wrapper

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<Sparkline label="Sales trend over past 7 days">
    <svg><!-- your sparkline SVG here --></svg>
</Sparkline>
```


## Keyboard Interactions

None -- this component is a passive container for data visualization.

## ARIA Attributes

- `role="img"` -- identifies the container as a graphical image to assistive technologies
- `aria-label={label}` -- provides an accessible name describing what the sparkline represents

## References

- WAI-ARIA img role: https://www.w3.org/TR/wai-aria-1.2/#img
