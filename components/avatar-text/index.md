# Avatar Text

Avatar text is a `<span>` element rendered inside an Avatar as a fallback when no image is available or the image fails to load. It displays the user's initials or short text within the circular avatar frame.

## Help

Use AvatarText inside an Avatar to show initials when a photo is unavailable. The parent Avatar typically manages rendering this component automatically when the `src` is missing or fails. Common scenarios include placeholder avatars, anonymous users, and image load failures.

## Syntax

```svelte
<script>
  import AvatarText from "./AvatarText.svelte";
</script>

<AvatarText>JD</AvatarText>
```

## Usage

```svelte
<Avatar alt="Jane Doe">
  <AvatarText>JD</AvatarText>
</Avatar>
```

Standalone:

```svelte
<AvatarText aria-hidden="true">JD</AvatarText>
```

## Props

| Prop           | Type            | Default    | Description                                            |
| -------------- | --------------- | ---------- | ------------------------------------------------------ |
| `children`     | `Snippet`       | (required) | Initials or short text to display                      |
| `...restProps` | HTML attributes |            | Additional attributes spread onto the `<span>` element |

## Examples

Various initials:

```svelte
<Avatar alt="Alice Smith">
  <AvatarText>AS</AvatarText>
</Avatar>

<Avatar alt="Bob">
  <AvatarText>B</AvatarText>
</Avatar>
```

## Keyboard Interactions

- None -- this is a decorative/informational element, not interactive

## ARIA

- Typically marked `aria-hidden="true"` when inside an Avatar, since the parent's `aria-label` already provides the accessible name
- When used standalone, ensure the text is accessible or the parent provides an accessible label

## Claude Rules

- Always use `AvatarText` (not `AvatarText` or `AvatarInitials`)
- Place inside an Avatar container for proper accessibility
- Mark `aria-hidden="true"` when parent already has `aria-label`
- Use Svelte 5 patterns (Snippet for children)
- Component is headless/unstyled -- consumer provides all styling

## References

- WAI-ARIA Img Role: https://www.w3.org/TR/wai-aria-1.2/#img
