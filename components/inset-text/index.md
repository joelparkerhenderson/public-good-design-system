# Inset Text

An inset text component is used to distinguish a block of content from the surrounding text, drawing attention to important information that a user needs to know. It is commonly used in government and institutional design systems to highlight supplementary information, processing times, eligibility criteria, or important notices without using an alert or warning pattern.

The component renders its content within a semantic container that screen readers announce as a note, making it clear that the content is supplementary or distinguished from the main flow.

## Implementation Notes

- Renders a `<div>` with `role="note"` to semantically indicate supplementary content.
- Content is passed via the `children` slot, allowing any markup structure inside the inset.
- Spreads `restProps` onto the container for consumer customization.
- No internal state management; this is a purely presentational container.
- Inspired by the GOV.UK and NHS England design system "inset text" pattern.

## Props

- `children`: slot (required) -- content to display inside the inset text block.
- `...restProps`: unknown -- additional attributes spread onto the container `<div>`.

## Usage

```html
<InsetText>It can take up to 8 weeks to process.</InsetText>
```

```html
<InsetText>
    <p>You must apply before the deadline. Late applications will not be accepted.</p>
</InsetText>
```

## Keyboard Interactions

None -- this component is a passive container with no interactive behavior.

## ARIA

- `role="note"` -- identifies the content as a note or supplementary information, so screen readers announce it with appropriate context.

## When to Use

- Use to highlight supplementary information, processing times, eligibility criteria, or important notices that need to stand out without using an alert.
- Use in government or institutional interfaces where the inset text pattern is a recognized convention.
- Avoid for critical warnings or errors; use WarningCallout or Alert instead. Avoid for general emphasis; use InformationCallout for tips and notes.

## Headless

This headless component provides a `<div>` with `role="note"` for semantic supplementary content. The consumer provides all visual styling including the characteristic left border, indentation, padding, and font treatment.


## Styles

The consumer provides all CSS styling. The component renders with a `.inset-text` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<div>` element with class `inset-text`
- Verify role="note"` -- identifies the content as a note or supplementary information, so screen readers announce it with appropriate context.
- Verify pass-through attributes are applied

## Advice

- **Designers**: Use a thick left border (typically 4-10px) as the primary visual indicator. Keep inset text visually distinct from blockquotes and callouts.
- **Developers**: Keep inset text content concise. Avoid nesting interactive elements inside the inset text; use it for informational content only.

## References

- WAI-ARIA Note Role: https://www.w3.org/TR/wai-aria-1.2/#note
- GOV.UK Inset Text: https://design-system.service.gov.uk/components/inset-text/
- NHS England Inset Text: https://service-manual.nhs.uk/design-system/components/inset-text
