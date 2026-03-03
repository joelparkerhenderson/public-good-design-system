# AvatarImage

An avatar circle image is the profile photo element within an Avatar. It renders a native `<img>` element with `aria-hidden="true"` to prevent duplicate announcements (since the parent Avatar already has `aria-label`).

## Implementation Notes

- Renders a native `<img>` element
- `aria-hidden="true"` prevents duplicate screen reader announcements
- Passes through all additional HTML attributes via `AdditionalAttributes`
- Compound component: must be used inside an Avatar container

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Src` | `string` | `—` | The src value |
| `Alt` | `string` | `—` | The alt value |

## Usage


```razor
<Avatar alt="Jane Doe">
  <AvatarImage src="/photos/jane.jpg" alt="Jane Doe" />
</Avatar>
```


## Keyboard Interactions

- None -- display-only element

## ARIA Attributes

- `aria-hidden="true"` prevents duplicate announcements from parent's `aria-label`
- Native `<img>` with `alt` text for image fallback contexts

## References

- HTML img element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/img
