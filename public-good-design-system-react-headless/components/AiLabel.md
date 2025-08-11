# AiLabel

AiLabel is a headless inline indicator that communicates the presence of AI-generated content and provides a pathway to AI explainability. It renders a `<span>` element with visible text and an accessible label.

## Implementation Notes

- Renders a `<span>` element for inline placement
- Uses `aria-label` for accessible naming, defaulting to "AI"
- Uses React functional component with TypeScript interface for props

## Props

- `label`: string (default: "AI") -- accessible name via `aria-label`
- `text`: string (default: "AI") -- visible text displayed inside the indicator
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Usage

```tsx
<AiLabel />
<AiLabel text="AI generated" label="AI generated content" />
<p>This summary was created by <AiLabel /> based on your documents.</p>
```

## ARIA

- `aria-label={label}` -- provides an accessible name for the AI indicator

## References

- Carbon Design System AI Label: https://carbondesignsystem.com/components/ai-label/usage/
