# Review Date

A review date component displays a date associated with a review, audit, or scheduled check-in. It renders as a semantic HTML `<time>` element with a machine-readable `datetime` attribute in ISO 8601 format and human-readable display text provided through a children slot. This separation allows browsers and assistive technologies to parse the date for accurate interpretation while displaying a user-friendly formatted date.

The component is commonly used in dashboards, compliance tracking, audit logs, and scheduling interfaces where dates need to be both human-readable and machine-parseable.

## Implementation Notes

- Renders as `<time aria-label={label} datetime={datetime}>` with children slot
- The `datetime` attribute uses ISO 8601 format for machine readability
- Children slot provides localized human-readable date text
- Semantic `<time>` element enables browser and assistive technology date parsing
- All additional HTML attributes are spread onto the time element via `restProps`

## Props

- `label`: string (required) -- accessible label for screen readers via `aria-label`
- `datetime`: string (required) -- ISO 8601 date/time string for machine readability
- `children`: slot (required) -- human-readable display text for the date
- `...restProps`: any -- additional HTML attributes spread onto the time element

## Usage

```html
<ReviewDate label="Next review" datetime="2025-06-15">June 15, 2025</ReviewDate>
```

```html
<ReviewDate label="Last audit" datetime={isoDate}>{formattedDate}</ReviewDate>
```

## Keyboard Interactions

None -- this is an informational display, not interactive.

## ARIA

- `aria-label` -- provides screen reader context from the `label` prop
- `datetime` -- machine-readable date attribute on the `<time>` element

## When to Use

- Use ReviewDate in compliance tracking, audit logs, and scheduling interfaces where a review or check-in date needs to be displayed with machine-readable precision.
- Use ReviewDate when both human-readable display text and ISO 8601 machine-readable dates are needed.
- Avoid using ReviewDate for general text display; use a plain `<time>` or `<span>` if semantic date parsing is not needed.

## Headless

The ReviewDate headless component provides a `<time>` element with `aria-label` for accessible naming and a `datetime` attribute in ISO 8601 format for machine readability. The children slot renders human-readable text. The consumer provides all visual styling and date formatting.

## Advice

- **Designers**: Display dates in a format familiar to your target audience (e.g., "June 15, 2025" for US, "15 June 2025" for UK) and visually distinguish upcoming vs. past review dates.
- **Developers**: Always pass a valid ISO 8601 string to `datetime` and format the children text using locale-appropriate date formatting for human readability.
