# ReviewDate

A review date component displays a date associated with a review, audit, or scheduled check-in. It renders as a semantic HTML `<time>` element with a machine-readable `datetime` attribute in ISO 8601 format and human-readable display text provided through a ChildContent render fragment. This separation allows browsers and assistive technologies to parse the date for accurate interpretation while displaying a user-friendly formatted date.

The component is commonly used in dashboards, compliance tracking, audit logs, and scheduling interfaces where dates need to be both human-readable and machine-parseable.

## Implementation Notes

- Renders as `<time aria-label={label} datetime={datetime}>` with ChildContent render fragment
- The `datetime` attribute uses ISO 8601 format for machine readability
- Children snippet provides localized human-readable date text
- Semantic `<time>` element enables browser and assistive technology date parsing
- All additional HTML attributes are spread onto the time element via `AdditionalAttributes`

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Datetime` | `string` | `—` | The datetime value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<ReviewDate label="Next review" datetime="2025-06-15">June 15, 2025</ReviewDate>
```


```razor
<ReviewDate label="Last audit" datetime=@isoDate>@formattedDate</ReviewDate>
```


## Keyboard Interactions

None -- this is an informational display, not interactive.

## ARIA Attributes

- `aria-label` -- provides screen reader context from the `label` prop
- `datetime` -- machine-readable date attribute on the `<time>` element
