# Vital Sign Heart Rate Variability Input

VitalSignHeartRateVariabilityInput is a headless number input for entering a heart rate variability (HRV) value in milliseconds. It wraps a native `<input type="number">` with integer-only constraints and accessible labelling.

Use this component in medical forms, health assessments, fitness tracking screens, and wellness applications where users need to enter a heart rate variability measurement.

## Implementation Notes

- Renders a native `<input type="number">` element
- Uses `aria-label` for an accessible name describing the input purpose
- The `value` prop uses two-way binding with an initial undefined state
- Defaults: `min=0`, `max=500`, `step=1` for integer-only millisecond entry
- Supports `required` and `disabled` boolean states
- Spreads `restProps` onto the input for consumer customization
- Companion to VitalSignHeartRateVariabilityView for the Input/View pattern

## Props

- `label`: string (required) -- accessible name for the input via `aria-label`
- `value`: number | undefined (default: `undefined`) -- current HRV value in milliseconds; bindable with two-way binding
- `min`: number (default: `0`) -- minimum allowed value
- `max`: number (default: `500`) -- maximum allowed value
- `step`: number (default: `1`) -- increment step size (integer)
- `required`: boolean (default: `false`) -- whether the input is required
- `disabled`: boolean (default: `false`) -- whether the input is disabled
- `...restProps`: unknown -- additional attributes spread onto the `<input>` element

## Usage

```html
<VitalSignHeartRateVariabilityInput label="Heart rate variability (ms)" value={value} />
```

```html
<VitalSignHeartRateVariabilityInput label="HRV" value={hrv} required />
```

## Keyboard Interactions

- Up Arrow: increment value by 1 (native browser behavior)
- Down Arrow: decrement value by 1 (native browser behavior)

## ARIA

- `aria-label={label}` -- provides an accessible name describing the purpose of the HRV input

## When to Use

- Use for form fields that accept a heart rate variability measurement in milliseconds.
- Use as the input companion to VitalSignHeartRateVariabilityView.
- Consider using NumberInput for generic numeric values that are not specifically HRV.

## Headless

This headless component wraps a native `<input type="number">` with `aria-label`, two-way bindable value, and HRV-appropriate defaults (min=0, max=500, step=1). The consumer provides all visual styling including input dimensions, borders, validation error display, and unit label.

## Styles

The consumer provides all CSS styling. The component renders with a `.vital-sign-heart-rate-variability-input` class for targeting. Common styling includes displaying "ms" as a suffix label.

## Testing

- Verify the component renders an `<input>` element with `type="number"`
- Verify `aria-label` is set from the `label` prop
- Verify default `min=0`, `max=500`, `step=1` attributes
- Verify `disabled` and `required` attributes propagate correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Display "ms" as a unit label near the input. Since HRV varies widely by individual, focus on personal trend display rather than absolute range indicators. Provide placeholder text like "20-200" to hint at common ranges.
- **Developers**: Use the default min/max/step constraints for standard HRV entry. The max of 500 accommodates extreme values. Focus on trend-based validation rather than absolute thresholds.

## Domain Knowledge

Heart Rate Variability (HRV) measures the subtle fluctuation in time between consecutive heartbeats, serving as a key indicator of autonomic nervous system health, stress levels, and recovery. A higher, more flexible HRV generally indicates better cardiovascular fitness and resilience, while lower, more rigid values can signal stress, illness, or fatigue.

- Physiological Basis: HRV reflects the balance between the sympathetic ("fight-or-flight") and parasympathetic ("rest-and-digest") nervous systems.
- Typical Ranges: Normal HRV varies widely by individual, typically ranging from below 20 to over 200 milliseconds, and decreases with age.
- Tracking Metrics: Wearables (e.g., Oura, Whoop, Garmin) often use RMSSD (root mean squared of successive differences) to measure HRV, usually while sleeping for the most accurate data.
- Improving HRV: Consistent positive lifestyle habits such as adequate sleep, regular exercise, reduced alcohol consumption, and stress management can increase HRV.
- Decreases: High stress, illness, fatigue, alcohol, dehydration, and increasing age.
- Increases: Good cardiovascular fitness, proper recovery, and positive emotional states.
- Individual Focus: It is important to focus on personal trends over time rather than comparing absolute numbers with others, as individual baselines differ significantly.

## References

- HTML number input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number
- WAI-ARIA spinbutton role: https://www.w3.org/TR/wai-aria-1.2/#spinbutton
- Harvard Health - Heart Rate Variability: https://www.health.harvard.edu/blog/heart-rate-variability-new-way-track-well-2017112212789
