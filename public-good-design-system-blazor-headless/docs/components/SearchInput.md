# SearchInput

A search input is a UI/UX component that provides a text field specifically for search queries. It uses the native HTML `<input type="search">` element, which provides semantic meaning and may trigger search-specific browser behaviors such as a clear button or search icon. The component includes aria-label for accessibility and supports bindable value for two-way data binding, making it easy to integrate with search functionality in any application.

Search inputs are commonly used for site-wide search bars, filtering lists, and any scenario where users need to enter a search query. Mobile browsers may display a search-optimized keyboard layout when this input type is focused.

## Implementation Notes

- Renders a single `<input type="search">` element for semantic search behavior
- Uses `@bind-` for the `value` prop enabling two-way data binding with `@bind-Value`
- The `aria-label` prop provides an accessible name since there is no visible `<label>` element
- Supports additional attributes via `AdditionalAttributes` for extensibility (e.g., `id`, `name`, `placeholder`, `class`)
- The search type may trigger browser-native clear buttons and search-specific behaviors

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `Required` | `bool` | `—` | The required value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<SearchInput label="Search" @bind-Value />
```


```razor
<SearchInput label="Filter products" @bind-Value="query" required />
```


## Keyboard Interactions

- Escape: clears the search field (browser-native behavior for search inputs)
- Enter: submits the containing form (standard input behavior)

Note: keyboard interactions are provided natively by the `<input type="search">` element.

## ARIA Attributes

- `aria-label={label}` -- provides the accessible name for the search field since no visible label element is associated

## References

- WAI-ARIA Search Role: https://www.w3.org/WAI/ARIA/apd/patterns/search/
- MDN input type="search": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/search
