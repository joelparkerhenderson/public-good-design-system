# Tooltip

A tooltip is a headless component that displays brief, contextual information when made visible. It uses `role="tooltip"` for semantic identification and is designed to be linked to a trigger element via `aria-describedby`, providing supplementary text that screen readers can announce.

Tooltips are used to clarify the function or meaning of an element without cluttering the interface, offering helpful hints, labels, or explanations on demand. The consumer controls visibility through the bindable `visible` prop and is responsible for toggling it on hover, focus, or other interaction events.

## Implementation Notes

- Renders a `<div>` with `role="tooltip"` when visible, removed from the DOM when hidden
- Uses `{#if visible}` for conditional rendering, so the tooltip is fully removed from the DOM when not shown
- Uses Blazor 5 `@bind-` for two-way binding on the `visible` prop
- The consumer is responsible for managing visibility (e.g., on hover/focus of a trigger element)
- The `id` prop enables linking the tooltip to its trigger element via `aria-describedby`
- Spreads `AdditionalAttributes` onto the div element for consumer extensibility

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Visible` | `bool` | `—` | The visible value |
| `VisibleChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Visible |
| `Id` | `string?` | `—` | The id value |

## Usage


```razor
<button aria-describedby="tip"
  onmouseenter={() => showTip = true}
  onmouseleave={() => showTip = false}
  onfocusin={() => showTip = true}
  onfocusout={() => showTip = false}
>
  Hover me
</button>
<Tooltip id="tip" label="Additional info" @bind-Visible="showTip" />
```


```razor
<Tooltip id="help-tip" label="Click to submit your form" visible=@true />
```


## Keyboard Interactions

- Escape: The consumer should hide the tooltip when Escape is pressed (not built into the component; must be handled by the consumer)
- The tooltip itself does not receive focus; it is a supplementary description for another element

## ARIA Attributes

- `role="tooltip"` -- identifies the element as a tooltip, a popup that displays a description for an element
- `id={id}` -- used with `aria-describedby` on the trigger element to create an accessible association between the trigger and the tooltip

## References

- WAI-ARIA Tooltip Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/tooltip/
- MDN aria-describedby: https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/Attributes/aria-describedby
