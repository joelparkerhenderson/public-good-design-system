# ContentsList

An ordered list for a table of contents. Renders a semantic `<ol>` element containing ContentsListItem children. Designed to be placed inside a ContentsNav component.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<ContentsNav label="On this page">
  <ContentsList>
    <ContentsListItem><a href="#introduction">Introduction</a></ContentsListItem>
    <ContentsListItem><a href="#usage">Usage</a></ContentsListItem>
    <ContentsListItem><a href="#examples">Examples</a></ContentsListItem>
  </ContentsList>
</ContentsNav>
```



## References

- [MDN ol element](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/ol)
