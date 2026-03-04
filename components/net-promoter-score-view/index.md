# Net Promotor Score View

A Net Promoter Score (NPS) view is a display component that presents an NPS score value as read-only text. It is used to show previously captured NPS data in dashboards, reports, or detail views. NPS scores range from 0 to 10, with respondents classified as Detractors (0-6), Passives (7-8), or Promoters (9-10).

This headless component renders as a `<span>` element with an accessible label, providing the semantic structure and accessibility features while allowing consumers to apply their own visual styling, such as color-coding by score range.

## Implementation Notes

- Renders as a `<span>` element with `aria-label` for accessible naming
- Displays the NPS score value as inline text content
- Read-only display component, not interactive
- Uses props for prop destructuring with rest props spread
- Value defaults to empty string when not provided
- No score validation or classification logic; consumers handle categorization and styling
- No hardcoded strings; all text comes through props for internationalization

## Props

- `label`: string (required) -- accessible label for screen readers via `aria-label`
- `value`: string (default: `""`) -- the NPS score to display
- `...restProps`: any -- additional HTML attributes spread onto the `<span>` element

## Usage

```html
<NetPromotorScoreRatingView label="NPS Score" value="8" />
```

```html
<NetPromotorScoreRatingView label="Customer rating" value={score} />
```

## Keyboard Interactions

- None -- this is a passive informational display, not interactive

## ARIA

- `aria-label` -- provides the accessible name from the `label` prop so screen readers can announce the context of the displayed score

## When to Use

- Use to display a previously captured NPS score in dashboards, reports, or detail views.
- Use when the score should be visible but not editable by the user.
- Consider using NetPromoterScorePicker instead when the user needs to select or change the score.

## Headless

This headless component renders a `<span>` with the NPS score as text content and `aria-label` for accessible context. The consumer provides all visual styling, including typography, color coding by score range (Detractor, Passive, Promoter), and layout.

## Advice

- **Designers**: Color-code displayed scores by range (e.g., red for Detractors 0-6, yellow for Passives 7-8, green for Promoters 9-10) and display the category label alongside the number.
- **Developers**: Provide a descriptive `label` prop (e.g., "Customer NPS score") so screen reader users understand the context of the displayed number.

## References

- Net Promoter Score: https://en.wikipedia.org/wiki/Net_promoter_score
