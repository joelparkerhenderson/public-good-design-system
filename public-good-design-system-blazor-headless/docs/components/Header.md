# Header

A header is a headless component that renders a semantic `<header>` element, providing a landmark region for introductory or navigational content. It is typically positioned at the top of a page or section and contains elements like headings, navigation links, branding, search controls, or call-to-action buttons.

The semantic `<header>` element helps assistive technologies identify the header region as a landmark, improving navigation for screen reader users. An optional `aria-label` allows consumers to distinguish between multiple headers on a page.

## Implementation Notes

- Renders a single `<header>` element as a semantic landmark
- Uses an optional `aria-label` to provide an accessible name, which is helpful when a page has multiple header regions
- Uses Blazor 5 RenderFragment for the `ChildContent` prop
- Spreads `AdditionalAttributes` onto the header element for consumer extensibility

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string?` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<Header label="Site header">
  <h1>My Site</h1>
</Header>
```


```razor
<Header>
  <h1>Page Title</h1>
  <nav>
    <a href="/">Home</a>
    <a href="/about">About</a>
  </nav>
</Header>
```


```razor
<Header label="Article header">
  <h2>Article Title</h2>
  <p>Published on 2024-01-15</p>
</Header>
```


## Keyboard Interactions

None -- this component is a passive container. Keyboard interactions are determined by the content placed inside it by the consumer.

## ARIA Attributes

- `aria-label={label}` -- optionally provides an accessible name for the header landmark, useful when multiple headers exist on a page to help screen reader users distinguish between them
- The `<header>` element implicitly has `role="banner"` when it is a direct child of `<body>`, providing a page-level landmark

## References

- MDN header element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/header
- WAI-ARIA Banner Landmark: https://www.w3.org/WAI/ARIA/apd/practices/landmark-regions/
