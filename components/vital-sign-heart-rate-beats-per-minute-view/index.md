# Vital Sign Heart Rate Beats Per Minute View

VitalSignHeartRateBeatsPerMinuteView is a headless read-only display of a heart rate value in beats per minute (BPM). It renders a `<span>` with `role="img"` and an accessible label describing the value and unit.

Use this component to display a patient's heart rate in medical records, health dashboards, vital sign summaries, and wellness applications.

## Implementation Notes

- Renders a `<span>` element with `role="img"` for a read-only numeric display
- Uses `aria-label` for an accessible description (e.g., "72 beats per minute")
- The `value` prop is the integer heart rate in BPM
- Spreads `restProps` onto the span for consumer customization
- Companion to VitalSignHeartRateBeatsPerMinuteInput for the Input/View pattern

## Props

- `value`: number (required) -- heart rate value in beats per minute
- `label`: string (required) -- accessible description via `aria-label` (e.g., "72 beats per minute")
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Usage

```html
<VitalSignHeartRateBeatsPerMinuteView value={72} label="72 beats per minute" />
```

## Keyboard Interactions

None. This is a passive, read-only display element.

## ARIA

- `role="img"` -- identifies the span as a visual/graphic display element
- `aria-label={label}` -- provides the full value description for screen readers

## When to Use

- Use to display a heart rate reading in vital sign summaries, medical records, or health dashboards.
- Use as the display companion to VitalSignHeartRateBeatsPerMinuteInput.
- Avoid using for editable heart rate values; use VitalSignHeartRateBeatsPerMinuteInput instead.

## Headless

This headless component provides a `<span>` with `role="img"` and `aria-label`. The consumer provides all visual styling including font size, color coding for normal/abnormal ranges, and unit label display.

## Styles

The consumer provides all CSS styling. The component renders with a `.vital-sign-heart-rate-beats-per-minute-view` class for targeting. Common styling includes color coding for ranges (green for normal 60-100 BPM, red for bradycardia <60 or tachycardia >100).

## Testing

- Verify the component renders a `<span>` element with `role="img"`
- Verify `aria-label` is set from the `label` prop
- Verify the `value` is displayed as text content
- Verify `data-value` attribute is set
- Verify pass-through attributes are applied

## Advice

- **Designers**: Use color coding to indicate normal (60-100 BPM), low (<60 BPM), and high (>100 BPM) ranges. Display the "BPM" unit label alongside the number.
- **Developers**: The `label` prop should include both the value and unit for screen readers (e.g., "72 beats per minute"). Consider using `data-value` for conditional CSS styling based on range.

## Domain Knowledge

The normal resting heart rate for healthy adults is 60 to 100 beats per minute (BPM), with lower rates (40-60 BPM) common in trained athletes. Rates generally rise with age in children but stabilize to adult levels around age 13-18.

- Optimal Range: While 60-100 is standard, many experts consider a resting rate between 50 and 70 BPM more optimal for cardiovascular health.
- Factors: Rates can increase due to stress, illness, injury, or exercise, and decrease during sleep.
- Abnormalities: A rate below 60 BPM (when not a fit athlete) is called bradycardia, while over 100 BPM is tachycardia.
- Children: Newborns: 70-200 BPM or 100-160 BPM. Infants (1-12 months): 80-160 BPM. Toddlers (1-3 years): 80-130 BPM. Children (6-12 years): 70-110 BPM.

## References

- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
- American Heart Association - Target Heart Rates: https://www.heart.org/en/healthy-living/fitness/fitness-basics/target-heart-rates
