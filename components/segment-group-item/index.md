# Segment Group Item

SegmentGroupItem is a single segment option within a SegmentGroup. It renders as a `<button>` with `role="radio"` and `aria-checked`, following the WAI-ARIA radio group pattern. Each item represents one mutually exclusive option in the segmented control.

Use SegmentGroupItem inside a SegmentGroup to build custom segmented controls such as view mode toggles (grid/list), filter selections, or display density controls.

## Implementation Notes

- Renders a `<button>` element with `role="radio"` for ARIA semantics
- `aria-checked` reflects the `checked` prop to indicate selection state
- Uses roving tabindex: `tabindex="0"` when checked, `tabindex="-1"` otherwise
- `data-value` attribute exposes the segment value for CSS styling or JS queries
- Supports `disabled` prop to prevent interaction
- Spreads `restProps` onto the button for consumer customization

## Props

- `checked`: boolean (default `false`) -- whether this segment is currently selected
- `value`: string (default `""`) -- value associated with this segment, exposed as `data-value`
- `disabled`: boolean (default `false`) -- whether the segment is disabled
- `children`: slot (required) -- label content to render inside the button
- `...restProps`: unknown -- additional attributes spread onto the `<button>` element

## Usage

```html
<SegmentGroup label="View">
  <SegmentGroupItem checked={mode === 'grid'} value="grid" onclick={() => mode = 'grid'}>
    Grid
  </SegmentGroupItem>
  <SegmentGroupItem checked={mode === 'list'} value="list" onclick={() => mode = 'list'}>
    List
  </SegmentGroupItem>
</SegmentGroup>
```

## Keyboard Interactions

- Tab: Focus moves to the checked segment (or first segment if none checked)
- Arrow Left / Arrow Right: Consumer should implement arrow key navigation on the parent SegmentGroup
- Space / Enter: Activates the focused segment (native button behavior)

## ARIA

- `role="radio"` -- identifies this button as a radio-like option within a radiogroup
- `aria-checked` -- indicates whether this segment is selected (`true`) or not (`false`)
- Roving tabindex -- only the checked item has `tabindex="0"`, others have `tabindex="-1"`

## When to Use

- Use SegmentGroupItem inside a SegmentGroup to represent one mutually exclusive option in a segmented control.
- Use SegmentGroupItem for custom toggle button UIs such as view mode switches, filter options, or density controls.
- Avoid using SegmentGroupItem outside of a SegmentGroup; it requires the parent radiogroup context for proper semantics.

## Headless

The SegmentGroupItem headless component provides a `<button>` with `role="radio"`, `aria-checked`, roving `tabindex`, and `data-value` for CSS targeting. The consumer provides all visual styling for the segment button, including selected and disabled states.


## Styles

The consumer provides all CSS styling. The component renders with a `.segment-group-item` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<div>` element with class `segment-group-item`
- Verify role="radio"` -- identifies this button as a radio-like option within a radiogroup
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Make the selected segment visually distinct with a filled background or bold text, and ensure disabled segments are visually muted.
- **Developers**: Use the `checked` prop to control `aria-checked` and tabindex; ensure only one item in the group has `checked={true}` at a time.

## References

- WAI-ARIA Radio Group Pattern: https://www.w3.org/WAI/ARIA/apg/patterns/radio/
