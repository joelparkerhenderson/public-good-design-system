# Card

A card groups related content and actions into a self-contained semantic container, making it easy to browse and compare items. Cards are commonly used for product listings, user profiles, article previews, media galleries, and dashboard widgets. They present a digestible summary of information that can include headings, text, and interactive elements.

The component renders as an `<article>` element for standalone content grouping. It supports a configurable heading level (h2-h6) for proper document outline, and the heading can optionally be wrapped in a link when an `href` is provided. An optional `aria-label` enables the article to be identified as a named landmark.

## Implementation Notes

- Uses `<article>` for semantic standalone content grouping
- Heading level is configurable (2-6) for proper document outline structure
- When `href` is provided, the heading text wraps in an `<a>` element for navigation
- Optional `aria-label` for named landmark identification
- Content is provided through the Blazor 5 `ChildContent` RenderFragment
- Passes through all additional HTML attributes via `AdditionalAttributes`

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Heading` | `string?` | `—` | The heading value |
| `HeadingLevel` | `int` | `3` | The heading level value |
| `Href` | `string?` | `—` | The href value |
| `Label` | `string?` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<Card><h3>Title</h3><p>Content</p></Card>
<Card heading="Product" href="/products/1"><p>Description</p></Card>
```


## Keyboard Interactions

- Tab: Focus the heading link when `href` is provided
- Enter: Activate the heading link (browser default)

## ARIA Attributes

- Implicit `article` role from the `<article>` element
- Optional `aria-label` -- identifies the card as a named landmark for screen readers
