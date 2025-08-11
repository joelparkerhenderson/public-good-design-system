# AvatarCircleText

An avatar circle text is a `<span>` element rendered inside an AvatarCircle as a fallback when no image is available or the image fails to load. It displays the user's initials or short text within the circular avatar frame.

## Help

Use AvatarCircleText inside an AvatarCircle to show initials when a photo is unavailable. The parent AvatarCircle typically manages rendering this component automatically when the `src` is missing or fails. Common scenarios include placeholder avatars, anonymous users, and image load failures.

## Syntax

```svelte
<script>
  import AvatarCircleText from "./AvatarCircleText.svelte";
</script>

<AvatarCircleText>JD</AvatarCircleText>
```

## Usage

```svelte
<AvatarCircle alt="Jane Doe">
  <AvatarCircleText>JD</AvatarCircleText>
</AvatarCircle>
```

Standalone:

```svelte
<AvatarCircleText aria-hidden="true">JD</AvatarCircleText>
```

## Props

| Prop | Type | Default | Description |
|------|------|---------|-------------|
| `children` | `Snippet` | (required) | Initials or short text to display |
| `...restProps` | HTML attributes | | Additional attributes spread onto the `<span>` element |

## Examples

Various initials:

```svelte
<AvatarCircle alt="Alice Smith">
  <AvatarCircleText>AS</AvatarCircleText>
</AvatarCircle>

<AvatarCircle alt="Bob">
  <AvatarCircleText>B</AvatarCircleText>
</AvatarCircle>
```

## Keyboard Interactions

- None -- this is a decorative/informational element, not interactive

## ARIA

- Typically marked `aria-hidden="true"` when inside an AvatarCircle, since the parent's `aria-label` already provides the accessible name
- When used standalone, ensure the text is accessible or the parent provides an accessible label

## Claude Rules

- Always use `AvatarCircleText` (not `AvatarText` or `AvatarInitials`)
- Place inside an AvatarCircle container for proper accessibility
- Mark `aria-hidden="true"` when parent already has `aria-label`
- Use Svelte 5 patterns (Snippet for children)
- Component is headless/unstyled -- consumer provides all styling

## References

- WAI-ARIA Img Role: https://www.w3.org/TR/wai-aria-1.2/#img
