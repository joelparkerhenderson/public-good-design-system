# Error Message

An error message component informs users when something has gone wrong, such as incorrect input, failed actions, or system issues. It uses `role="alert"` to ensure screen readers announce the error immediately when it appears, without requiring user focus.

The component renders a `<p>` element with `role="alert"`, making it an assertive live region. This means the error text is announced to assistive technology users as soon as it enters the DOM, which is critical for form validation feedback and system error notifications.

## Implementation Notes

- Renders a `<p>` element with `role="alert"` for immediate screen reader announcement
- The alert role creates an implicit `aria-live="assertive"` region
- Children provide the error text content via a slot
- Spreads `restProps` onto the `<p>` element for consumer customization

## Props

- `children`: slot (required) -- error message text content

## Usage

```html
<ErrorMessage>Password is required</ErrorMessage>
```

```html
{#if error}
  <ErrorMessage>{error}</ErrorMessage>
{/if}
```

## Keyboard Interactions

None -- this component is a passive container for displaying error text.

## ARIA

- `role="alert"` -- creates an assertive live region so the error message is announced immediately by screen readers when it appears

## When to Use

- Use to display a single validation error or system error message associated with a form field or action.
- Use when the error needs to be announced immediately to screen readers without requiring user focus.
- Avoid for summarizing multiple errors; use ErrorSummary instead.
- Consider Alert for general status messages that are not field-specific errors.

## Headless

This headless component provides a `<p>` element with `role="alert"`, creating an assertive live region that is announced immediately by screen readers when it appears in the DOM. The consumer provides all visual styling such as color, typography, spacing, and error icons.

## Advice

- **Designers**: Use a distinct error color (typically red) and consider an error icon to make the message visually prominent. Position the error message directly below the associated input field.
- **Developers**: Conditionally render the ErrorMessage so it only appears when an error exists. The `role="alert"` ensures it is announced on insertion without extra ARIA live-region setup.

## References

- WAI-ARIA Alert Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/alert/
