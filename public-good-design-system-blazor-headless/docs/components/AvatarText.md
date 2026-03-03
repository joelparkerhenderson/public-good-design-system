# AvatarText

An avatar circle text is the initials/text fallback within an Avatar. It renders a `<span>` with `aria-hidden="true"` containing initials or short text that represents the user when no image is available.

## Implementation Notes

- Renders a `<span>` element with `aria-hidden="true"`
- `aria-hidden` prevents duplicate screen reader announcements (parent has `aria-label`)
- Content is provided through the ChildContent render fragment
- Passes through all additional HTML attributes via `AdditionalAttributes`
- Compound component: must be used inside an Avatar container

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<Avatar alt="Jane Doe">
  <AvatarText>JD</AvatarText>
</Avatar>
```


```razor
<Avatar alt="Jane Doe">
  <AvatarImage src="/photo.jpg" alt="Jane Doe" />
  <AvatarText>JD</AvatarText>
</Avatar>
```


## Keyboard Interactions

- None -- display-only element

## ARIA Attributes

- `aria-hidden="true"` prevents duplicate announcements from parent's `aria-label`

## References

- WAI-ARIA img role: https://www.w3.org/TR/wai-aria-1.2/#img
