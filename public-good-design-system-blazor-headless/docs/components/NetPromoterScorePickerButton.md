# NetPromoterScorePickerButton

A button representing one score in a Net Promoter Score picker. Renders a `<button>` with `aria-pressed` to indicate the selected state and `data-value` for consumer CSS targeting.

Compound component: use with NetPromoterScorePicker.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Value` | `string` | `—` | The value value |
| `Label` | `string` | `—` | Accessible label for the component |
| `Selected` | `bool` | `—` | The selected value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
{#each Array.from({ length: 11 }, (_, i) => i) as score}
  <NetPromoterScorePickerButton
    value=@score
    label={String(score)}
    selected={nps === score}
    @onclick="HandleClick"
  />
{/each}
```



## ARIA Attributes

- `aria-label` -- accessible name for the button
- `aria-pressed` -- indicates whether the score is currently selected
- `data-value` -- exposes the score value for consumer CSS selectors

## References

- WAI-ARIA Button Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/button/
- Net Promoter Score: https://en.wikipedia.org/wiki/Net_promoter_score
