# AccordionNavListItem

A single expandable section within an AccordionNavList, using the native HTML `<details>` element for built-in disclosure behavior. The consumer provides a `<summary>` element and content as children.

The `open` prop is two-way bindable, allowing parent components to programmatically control and observe the expanded state.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Open` | `bool` | `—` | The open value |
| `OpenChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Open |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<AccordionNavListItem>
  <summary>Question</summary>
  <p>Answer</p>
</AccordionNavListItem>
```


```razor
<AccordionNavListItem @bind-Open="isOpen">
  <summary>Details</summary>
  <p>Expanded content here.</p>
</AccordionNavListItem>
```



## References

- [HTML details element](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/details)
