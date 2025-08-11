# Net Promoter Score Picker

A Net Promoter Score (NPS) picker is a UI/UX component that allows users
to select a score from 0 to 10, representing their likelihood to recommend a
product, service, or organization. It is a widely used customer loyalty metric
developed by Fred Reichheld and Bain & Company. The component renders as a
fieldset with a radiogroup role containing 11 radio buttons, one for each score
value. Scores are typically categorized as Detractors (0-6), Passives (7-8),
and Promoters (9-10). This headless component provides the semantic structure
and accessibility features while allowing consumers to apply their own visual
styling.

## Implementation Notes

- Renders as `<fieldset role="radiogroup">` with 11 radio buttons (0-10)
- Each radio has `aria-label` with its numeric value for screen readers
- The `value` prop is two-way binding
- Default radio group name is "nps", customizable via `name` prop
- Radio values are strings ("0" through "10")

## Props

- `label`: string (required) -- accessible label for the radiogroup
- `value`: string (default: "") -- currently selected score, bindable
- `name`: string (default: "nps") -- name attribute for the radio group
- `...restProps`: Any additional HTML attributes spread onto the fieldset

## Usage

Basic NPS rating input:

```html
<NetPromotorScoreRatingInput label="How likely are you to recommend us?" value={score} />
<p>Selected score: {score}</p>
```

With a custom radio group name:

```html
<NetPromotorScoreRatingInput
  label="Rate our service"
  value={score}
  name="service-nps"
/>
```

With additional HTML attributes:

```html
<NetPromotorScoreRatingInput
  label="Customer satisfaction"
  value={score}
  data-section="feedback"
/>
```

## Keyboard Interactions

- Arrow keys navigate between radio buttons (native radio group behavior)
- Space selects the focused radio button
- Tab moves focus into/out of the radio group

## ARIA

- `role="radiogroup"` on the fieldset
- `aria-label` on the fieldset from the label prop
- Each radio has `aria-label` with its numeric value

## When to Use

- Use to collect a Net Promoter Score (0-10) from users in feedback forms, surveys, or satisfaction questionnaires.
- Use when you need a standardized NPS input with radio group semantics and keyboard navigation.
- Avoid using for general numeric ratings that are not on the NPS 0-10 scale; consider FiveStarRatingPicker or a custom range instead.

## Headless

This headless component provides a `<fieldset>` with `role="radiogroup"` containing 11 radio buttons (0-10) with `aria-label` on each. The consumer provides all visual styling, including button layout, color coding for Detractor/Passive/Promoter ranges, and selected-state appearance.


## Styles

The consumer provides all CSS styling. The component renders with a `.net-promoter-score-picker` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<div>` element with class `net-promoter-score-picker`
- Verify role="radiogroup"` on the fieldset
- Verify aria-label` on the fieldset from the label prop
- Verify Each radio has `aria-label` with its numeric value
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Color-code the score ranges (0-6 Detractors, 7-8 Passives, 9-10 Promoters) and add endpoint labels such as "Not at all likely" and "Extremely likely".
- **Developers**: The `value` prop is two-way bindable and stores the selected score as a string ("0" through "10"). Use the `name` prop to differentiate multiple NPS pickers on one page.

## Composition

NetPromoterScorePicker is a compound component that can contain NetPromoterScorePickerButton children. The picker provides the radiogroup container, while each button represents one score value.

```
NetPromoterScorePicker (role="radiogroup") → NetPromoterScorePickerButton (0-10)
```

## References

- Net Promoter Score: https://en.wikipedia.org/wiki/Net_promoter_score
- WAI-ARIA Radiogroup Role: https://www.w3.org/TR/wai-aria-1.2/#radiogroup
