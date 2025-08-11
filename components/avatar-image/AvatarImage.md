# AvatarImage

An avatar circle image is the `<img>` element rendered inside an Avatar when a valid image source is available. It displays the user's profile photo with proper `alt` text for accessibility and an `onerror` handler to trigger the initials fallback.

## Help

Use AvatarImage inside an Avatar to display a user's photo. The parent Avatar typically manages rendering this component automatically based on the `src` prop. Common scenarios include profile photos, team member headshots, and social media avatars.

## Syntax

```svelte
<script>
  import AvatarImage from "./AvatarImage.svelte";
</script>

<AvatarImage src="..." alt="..." />
```

## Usage

```svelte
<Avatar alt="Jane Doe" initials="JD">
  <AvatarImage src="/photo.jpg" alt="Jane Doe" />
</Avatar>
```

Standalone:

```svelte
<AvatarImage src="/team/alice.jpg" alt="Alice Smith" />
```

## Props

| Prop | Type | Default | Description |
|------|------|---------|-------------|
| `src` | `string` | (required) | URL of the avatar image |
| `alt` | `string` | (required) | Accessible alt text for the image |
| `...restProps` | HTML attributes | | Additional attributes spread onto the `<img>` element |

## Examples

With custom sizing:

```svelte
<AvatarImage src="/photo.jpg" alt="Jane Doe" width="48" height="48" />
```

## Keyboard Interactions

- None -- this is a decorative/informational element, not interactive

## ARIA

- Native `<img>` element with `alt` text provides accessible image semantics
- When inside an Avatar, the parent's `aria-label` provides the primary accessible name

## Claude Rules

- Always use `AvatarImage` (not `AvatarImage`)
- Always include the required `src` and `alt` props
- Place inside an Avatar container for proper fallback behavior
- Use Svelte 5 patterns
- Component is headless/unstyled -- consumer provides all styling

## References

- HTML img element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/img
- WAI-ARIA Img Role: https://www.w3.org/TR/wai-aria-1.2/#img
