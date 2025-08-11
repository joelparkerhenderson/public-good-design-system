# Avatar

An avatar circle is a component that displays a user's profile image or fallback initials within a circular frame, commonly used to represent a user identity in apps, websites, and social platforms. This visual element provides a quick, recognizable way for users to identify themselves or others, often appearing in headers, comments, chat interfaces, and account menus.

The component handles image loading gracefully: if an image source is provided, it renders an AvatarImage; if the image fails to load or no source is provided, it falls back to displaying the user's initials via AvatarCircleText.

## Help

Use Avatar as the outer container for user avatars. It renders either an AvatarCircleImage (when a photo is available) or an AvatarCircleText (initials fallback). Common scenarios include user profiles, comment threads, chat interfaces, account menus, and team member lists.

## Syntax

```svelte
<script>
  import Avatar from "./AvatarCircle.svelte";
</script>

<Avatar alt="..." src="..." initials="..." />
```

## Usage

With image:

```svelte
<Avatar src="/photo.jpg" alt="Jane Doe" />
```

With initials fallback:

```svelte
<Avatar initials="JD" alt="Jane Doe" />
```

With both (image with initials fallback on error):

```svelte
<Avatar src="/photo.jpg" alt="Jane Doe" initials="JD" />
```

## Props

| Prop | Type | Default | Description |
|------|------|---------|-------------|
| `src` | `string` | (optional) | URL of the avatar image |
| `alt` | `string` | (required) | Accessible description of the person, used as `aria-label` on the container and `alt` on the image |
| `initials` | `string` | (optional) | Fallback text displayed when no image is available or the image fails to load |
| `...restProps` | HTML attributes | | Additional attributes spread onto the outer `<span>` element |

## Examples

Team member list:

```svelte
<Avatar src="/team/alice.jpg" alt="Alice Smith" initials="AS" />
<Avatar src="/team/bob.jpg" alt="Bob Jones" initials="BJ" />
<Avatar alt="Charlie Brown" initials="CB" />
```

## Keyboard Interactions

- None -- this is a decorative/informational component, not interactive

## ARIA

- `role="img"` -- on the outer container, conveying that the entire avatar is an image representation
- `aria-label` -- set from the `alt` prop, providing the accessible name for the avatar
- `aria-hidden="true"` -- on the inner initials `<span>`, preventing duplicate announcements since the outer element already has `aria-label`

## Claude Rules

- Always use `Avatar` (not `Avatar`)
- Always include the required `alt` prop
- Provide `initials` as a fallback when `src` may fail
- Pair with AvatarImage and AvatarCircleText as children
- Use Svelte 5 patterns (`$state` for error tracking, `$derived` for show logic)
- Component is headless/unstyled -- consumer provides all styling (e.g. `border-radius: 50%`)

## References

- WAI-ARIA Img Role: https://www.w3.org/TR/wai-aria-1.2/#img
