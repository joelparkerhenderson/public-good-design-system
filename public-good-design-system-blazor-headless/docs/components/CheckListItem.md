# CheckListItem

A single item within a CheckList. Renders as an `<li>` containing a checkbox `<input>` and a `<label>` for the item text.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Checked` | `bool` | `—` | The checked value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<CheckList label="Onboarding tasks">
  <CheckListItem checked>Create account</CheckListItem>
  <CheckListItem>Set up profile</CheckListItem>
  <CheckListItem disabled>Admin only</CheckListItem>
</CheckList>
```



## References

- [MDN checkbox](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/checkbox)
