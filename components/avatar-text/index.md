# Avatar Text

Avatar text is a `<span>` element rendered inside an Avatar as a fallback when no image is available or the image fails to load. It displays the user's initials or short text within the circular avatar frame.

## Help

Use AvatarText inside an Avatar to show initials when a photo is unavailable. The parent Avatar typically manages rendering this component automatically when the `src` is missing or fails. Common scenarios include placeholder avatars, anonymous users, and image load failures.

## Syntax

```html
<AvatarText>JD</AvatarText>
```

## Usage

```html
<Avatar alt="Jane Doe">
  <AvatarText>JD</AvatarText>
</Avatar>
```

Standalone:

```html
<AvatarText aria-hidden="true">JD</AvatarText>
```

## Props

| Prop           | Type            | Default    | Description                                            |
| -------------- | --------------- | ---------- | ------------------------------------------------------ |
| `children`     | `slot`       | (required) | Initials or short text to display                      |
| `...restProps` | HTML attributes |            | Additional attributes spread onto the `<span>` element |

## Examples

Various initials:

```html
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
## When to Use

- Use inside an Avatar component as a fallback when no profile photo is available or the image fails to load.
- Use when you need to display user initials or short identifying text within an avatar frame.
- Avoid using standalone without an Avatar parent unless you provide your own accessible label and container styling.

## Headless

This component provides a `<span>` element for displaying initials text with zero visual styling. The consumer is responsible for all CSS including font size, font weight, text color, text alignment, and positioning within the avatar container.

## Advice

- **Designers**: Limit initials to 1-2 characters to ensure legibility at small avatar sizes. Choose a contrasting text-on-background color combination.
- **Developers**: When inside an Avatar, mark this element with `aria-hidden="true"` to prevent duplicate announcements since the parent provides the accessible label.

## Composition

AvatarText is a child component within the Avatar composition pattern:

- **Avatar** -- outer container with `role="img"` and `aria-label`.
- **AvatarImage** -- `<img>` element for the user's photo (when available).
- **AvatarText** -- `<span>` fallback displaying initials or short text.

```html
<Avatar alt="Jane Doe">
  <AvatarText>JD</AvatarText>
</Avatar>
```

## References

- WAI-ARIA Img Role: https://www.w3.org/TR/wai-aria-1.2/#img
