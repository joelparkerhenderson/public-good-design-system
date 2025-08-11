# Vital Sign Heart Rate As Beats Per Minute View

## Metadata

- Component: vital-sign-heart-rate-as-beats-per-minute-view
- PascalCase: VitalSignHeartRateAsBeatsPerMinuteView
- Description: number display of one vital sign heart rate in beats per minute (BPM) with integers
- HTML tag: <div>
- CSS class: .vital-sign-heart-rate-as-beats-per-minute-view
- Interactive: no

## Companion

- vital-sign-heart-rate-as-beats-per-minute-input

## Key Behaviors

- Renders a `<span>` element with `role="img"` for a read-only numeric display
- Uses `aria-label` for an accessible description (e.g., "72 beats per minute")
- The `value` prop is the integer heart rate in BPM
- Spreads `restProps` onto the span for consumer customization
- Companion to VitalSignHeartRateAsBeatsPerMinuteInput for the Input/View pattern

## ARIA

- `role="img"` -- identifies the span as a visual/graphic display element
- `aria-label={label}` -- provides the full value description for screen readers

## Props

- `value`: number (required) -- heart rate value in beats per minute
- `label`: string (required) -- accessible description via `aria-label` (e.g., "72 beats per minute")
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Acceptance Criteria

- [ ] Renders <div> element with class="vital-sign-heart-rate-as-beats-per-minute-view"
- [ ] Has aria-label attribute
- [ ] Has role="img"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-heart-rate-as-beats-per-minute-view in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-heart-rate-as-beats-per-minute-view.html
- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
- American Heart Association - Target Heart Rates: https://www.heart.org/en/healthy-living/fitness/fitness-basics/target-heart-rates
