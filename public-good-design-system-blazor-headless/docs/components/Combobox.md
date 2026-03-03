# Combobox

A combobox combines a text input with a dropdown listbox of suggestions, providing an autocomplete or type-ahead search experience. Users type into the input to filter suggestions, then select from matching options in the dropdown. This pattern is commonly used for search fields, address inputs, tag selectors, and any scenario where users choose from a large set of options.

The component manages the input value and dropdown open state as bindable props, so consumers can reactively filter options and control visibility. It supports full ARIA combobox semantics including `aria-expanded`, `aria-controls`, and `aria-autocomplete` for screen reader accessibility.

## Implementation Notes

- Renders a wrapper `<div>` containing an `<input>` with `role="combobox"` and a conditionally rendered `<div>` with `role="listbox"`.
- Generates a unique `listboxId` using random string for the `aria-controls` relationship between input and listbox.
- The `value` prop uses `$bindable("")` for two-way binding of the input text.
- The `open` prop uses `$bindable(false)` for two-way binding of dropdown visibility.
- The listbox is conditionally rendered with `{#if open}` to hide it from the DOM when closed.
- Escape key closes the dropdown via an `onkeydown` handler on the input.
- Spreads `AdditionalAttributes` onto the outer wrapper `<div>`.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `Open` | `bool` | `—` | The open value |
| `OpenChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Open |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<Combobox label="Search" @bind-Value @bind-Open>
    <div role="option" tabindex="-1">Option 1</div>
</Combobox>
```


```razor
@code {
    private string value = "";;
    private bool open = false;;
    let options = ["Apple", "Banana", "Cherry"];
    let filtered = $derived(options.filter(o => o.toLowerCase().includes(value.toLowerCase())));
}

<Combobox label="Select a fruit" @bind-Value @bind-Open>
    {#each filtered as option}
        <div role="option" tabindex="-1" @onclick="HandleClick"}>
            @option
        </div>
    {/each}
</Combobox>
```


## Keyboard Interactions

- Escape: Closes the dropdown listbox.

## ARIA Attributes

- `role="combobox"` -- on the `<input>`, identifies it as a combobox widget.
- `aria-label` -- provides an accessible name for both the input and the listbox.
- `aria-expanded` -- reflects the `open` state, telling screen readers whether the dropdown is visible.
- `aria-controls` -- links the input to its associated listbox by ID.
- `aria-autocomplete="list"` -- indicates the input provides autocomplete suggestions via a list.
- `role="listbox"` -- on the dropdown container, identifies it as a list of selectable options.

## References

- WAI-ARIA Combobox Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/combobox/
