# ErrorSummary

An error summary displays a consolidated list of form validation errors at the top of a form. It alerts users to problems that need correction and provides links to the specific fields with errors, following the pattern used by GOV.UK and NHS England design systems.

This component uses `role="alert"` to ensure screen readers announce the error summary immediately when it appears. The `tabindex="-1"` attribute allows programmatic focus (e.g., via JavaScript `focus()`) so the user's attention is directed to the error list after form submission. A heading identifies the summary, and children typically contain a list of linked error messages.

## Implementation Notes

- Renders a `<div>` with `role="alert"` for live-region announcement
- Uses `aria-labelledby` to associate the container with its heading
- Contains an `<h2>` element with a randomly generated ID for the `aria-labelledby` reference
- `tabindex="-1"` allows programmatic focus but does not place the element in the tab order
- Children snippet is rendered after the heading for the error list content
- Spreads `AdditionalAttributes` on the outer `<div>` element
- Heading ID is generated with `Math.random().toString(36).slice(2, 9)` to avoid collisions

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Title` | `string` | `—` | The title value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<ErrorSummary title="There is a problem">
    <ul>
        <li><a href="#name">Enter your name</a></li>
        <li><a href="#email">Enter a valid email address</a></li>
    </ul>
</ErrorSummary>
```


```razor
<ErrorSummary title="Please fix the following errors">
    <ul>
        <li><a href="#password">Password must be at least 8 characters</a></li>
    </ul>
</ErrorSummary>
```


## Keyboard Interactions

- **Tab**: Moves focus through the error links within the summary
- The container itself can receive programmatic focus via `element.focus()` due to `tabindex="-1"`

## ARIA Attributes

- `role="alert"` -- creates a live region that announces content to screen readers when the summary appears
- `aria-labelledby={titleId}` -- associates the alert region with its heading for context
- `tabindex="-1"` -- allows the error summary to receive programmatic focus without being in the natural tab order

## References

- GOV.UK Error Summary: https://design-system.service.gov.uk/components/error-summary/
- WAI-ARIA Alert Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/alert/
