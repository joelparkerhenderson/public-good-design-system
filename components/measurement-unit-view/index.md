# Measurement Unit View

A measurement unit view displays a measurement unit in a `<span>` element. A measurement unit is a standard quantity used to express a measurement, such as "kg", "lb", "cm", or "inch". This component is part of the Input/View pattern for measurement data, providing a read-only display of unit abbreviations or names.

The component supports an optional `aria-label` for additional accessible context, which is useful when abbreviated units may not be clear to screen reader users (e.g., labeling "lb" as "Pounds").

## Implementation Notes

- Renders as a `<span>` element displaying the measurement unit as text content
- A measurement unit is a standard quantity for expressing measurements (e.g., "kg", "lb", "cm", "inch")
- Optional `label` prop maps to `aria-label` for additional accessible context
- Text content is inherently accessible to screen readers
- Spreads `...restProps` on the root `<span>` element for consumer customization
- No hardcoded user-facing strings; all text comes through props

## Props

- `value`: string (required) -- the measurement unit to display
- `label`: string (optional) -- accessible name via aria-label for additional context

## Usage

```html
<MeasurementUnitView value="kg" />
<MeasurementUnitView value="lb" label="Pounds" />
```

## Keyboard Interactions

None -- this is a display-only component.

## ARIA

- `aria-label` -- optionally set from the `label` prop to provide additional context beyond the displayed unit abbreviation

## When to Use

- Use to display a read-only measurement unit such as "kg", "lb", or "cm" alongside a measurement value.
- Use in dashboards, reports, or detail views where the unit should be visible but not editable.
- Consider using MeasurementUnitInput instead when the user needs to enter or change the unit.

## Headless

This headless component renders a `<span>` with the measurement unit as text content and optional `aria-label` for additional accessible context. The consumer provides all visual styling, including typography, positioning relative to the value, and any abbreviation expansion.

## Advice

- **Designers**: Display units in a consistent style (e.g., smaller font size or muted color) positioned immediately after their corresponding values.
- **Developers**: Provide the `label` prop when displaying abbreviated units (e.g., labeling "lb" as "Pounds") so screen reader users understand the full meaning.

## Composition

MeasurementUnitView is part of the measurement component family. It is the read-only counterpart to MeasurementUnitInput and works alongside MeasurementInstanceView, MeasurementSystemView, and their input counterparts.
