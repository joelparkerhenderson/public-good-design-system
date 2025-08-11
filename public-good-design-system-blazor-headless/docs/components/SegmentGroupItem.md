# SegmentGroupItem

SegmentGroupItem is a single segment option within a SegmentGroup. It renders as a `<button>` with `role="radio"` and `aria-checked`, following the WAI-ARIA radio group pattern. Each item represents one mutually exclusive option in the segmented control.

Use SegmentGroupItem inside a SegmentGroup to build custom segmented controls such as view mode toggles (grid/list), filter selections, or display density controls.

## Implementation Notes

- Renders a `<button>` element with `role="radio"` for ARIA semantics
- `aria-checked` reflects the `checked` prop to indicate selection state
- Uses roving tabindex: `tabindex="0"` when checked, `tabindex="-1"` otherwise
- `data-value` attribute exposes the segment value for CSS styling or JS queries
- Supports `disabled` prop to prevent interaction
- Spreads `AdditionalAttributes` onto the button for consumer customization
- Uses Blazor 5 `$props()` with TypeScript typing

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Checked` | `bool` | `—` | The checked value |
| `Value` | `string?` | `—` | The value value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<SegmentGroup label="View">
  <SegmentGroupItem checked={mode === 'grid'} value="grid" @onclick="HandleClick">
    Grid
  </SegmentGroupItem>
  <SegmentGroupItem checked={mode === 'list'} value="list" @onclick="HandleClick">
    List
  </SegmentGroupItem>
</SegmentGroup>
```


## Keyboard Interactions

- Tab: Focus moves to the checked segment (or first segment if none checked)
- Arrow Left / Arrow Right: Consumer should implement arrow key navigation on the parent SegmentGroup
- Space / Enter: Activates the focused segment (native button behavior)

## ARIA Attributes

- `role="radio"` -- identifies this button as a radio-like option within a radiogroup
- `aria-checked` -- indicates whether this segment is selected (`true`) or not (`false`)
- Roving tabindex -- only the checked item has `tabindex="0"`, others have `tabindex="-1"`

## References

- WAI-ARIA Radio Group Pattern: https://www.w3.org/WAI/ARIA/apg/patterns/radio/
