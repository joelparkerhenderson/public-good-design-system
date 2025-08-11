# NetPromoterScoreView

A Net Promoter Score (NPS) rating view is a display component that presents an NPS score value as read-only text. It is used to show previously captured NPS data in dashboards, reports, or detail views. NPS scores range from 0 to 10, with respondents classified as Detractors (0-6), Passives (7-8), or Promoters (9-10).

This headless component renders as a `<span>` element with an accessible label, providing the semantic structure and accessibility features while allowing consumers to apply their own visual styling, such as color-coding by score range.

## Implementation Notes

- Renders as a `<span>` element with `aria-label` for accessible naming
- Displays the NPS score value as inline text content
- Read-only display component, not interactive
- Uses Blazor 5 `$props()` for prop destructuring with additional attributes spread
- Value defaults to empty string when not provided
- No score validation or classification logic; consumers handle categorization and styling
- No hardcoded strings; all text comes through props for internationalization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |

## Usage


```razor
<NetPromoterScoreView label="NPS Score" value="8" />
```


```razor
<NetPromoterScoreView label="Customer rating" value=@score />
```


## Keyboard Interactions

- None -- this is a passive informational display, not interactive

## ARIA Attributes

- `aria-label` -- provides the accessible name from the `label` prop so screen readers can announce the context of the displayed score

## References

- Net Promoter Score: https://en.wikipedia.org/wiki/Net_promoter_score
