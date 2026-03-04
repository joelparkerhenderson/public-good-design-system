# Fieldset

A fieldset groups related form elements together using the native `<fieldset>` and `<legend>` HTML elements. This provides both a visual grouping and a semantic association that screen readers announce when users navigate into the group, helping them understand the context of related inputs.

The component supports a `disabled` prop that disables all child form controls at once, making it useful for sections of a form that should be conditionally editable. The legend text describes the purpose of the grouped controls.

## Implementation Notes

- Uses native `<fieldset>` element with a `<legend>` child for semantic form grouping
- The `disabled` attribute on `<fieldset>` natively disables all descendant form controls
- Spreads `restProps` onto the `<fieldset>` element for consumer customization
- No custom ARIA needed because native elements handle group semantics

## Props

- `legend`: string (required) -- text for the `<legend>` element describing the group
- `disabled`: boolean (default: false) -- whether all controls in the fieldset are disabled
- `children`: slot (required) -- grouped form controls

## Usage

```html
<Fieldset legend="Contact info">
  <label>Email <input type="email" /></label>
  <label>Phone <input type="tel" /></label>
</Fieldset>
```

```html
<Fieldset legend="Shipping address" disabled={usesBillingAddress}>
  <label>Street <input type="text" /></label>
  <label>City <input type="text" /></label>
</Fieldset>
```

## Keyboard Interactions

None -- this component is a passive container. Keyboard interactions are determined by the consumer-provided child form controls.

## ARIA

- No custom ARIA attributes required -- native `<fieldset>` and `<legend>` elements provide built-in group semantics and labeling for screen readers

## When to Use

- Use to group related form controls under a shared legend, such as address fields, contact information, or payment details.
- Use when the `disabled` attribute should cascade to all child form controls at once.
- Avoid for a single form field; use Field instead.
- Consider using Form as the outermost wrapper and Fieldset for logical sub-groups within it.

## Headless

This headless component provides native `<fieldset>` and `<legend>` elements with built-in group semantics for screen readers. The `disabled` attribute natively disables all descendant form controls. The consumer provides all visual styling for the fieldset border, legend appearance, and internal layout.

## Advice

- **Designers**: Style the fieldset border and legend consistently. Use the legend text to clearly describe the purpose of the grouped fields (e.g., "Shipping address").
- **Developers**: Use the `disabled` prop to conditionally disable an entire section of the form (e.g., when "same as billing" is checked). No custom ARIA is needed because native elements handle semantics.

## Composition

Fieldset groups multiple Field components together. Each Field wraps a label and input, and Fieldset provides the semantic group boundary with a legend. Use Fieldset inside a Form for well-structured form layouts.

## References

- HTML Specification fieldset: https://html.spec.whatwg.org/multipage/form-elements.html#the-fieldset-element
