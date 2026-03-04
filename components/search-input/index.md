# Search Input

A search input is a UI/UX component that provides a text field specifically for search queries. It uses the native HTML `<input type="search">` element, which provides semantic meaning and may trigger search-specific browser behaviors such as a clear button or search icon. The component includes aria-label for accessibility and supports bindable value for two-way data binding, making it easy to integrate with search functionality in any application.

Search inputs are commonly used for site-wide search bars, filtering lists, and any scenario where users need to enter a search query. Mobile browsers may display a search-optimized keyboard layout when this input type is focused.

## Implementation Notes

- Renders a single `<input type="search">` element for semantic search behavior
- Supports two-way binding for the `value` prop enabling two-way data binding with two-way `value` binding
- The `aria-label` prop provides an accessible name since there is no visible `<label>` element
- Supports rest props via `...restProps` for extensibility (e.g., `id`, `name`, `placeholder`, `class`)
- The search type may trigger browser-native clear buttons and search-specific behaviors

## Props

- `label`: string (required) -- accessible name applied via `aria-label`
- `value`: string (default: "") -- current search text, bindable with two-way `value` binding
- `required`: boolean (default: false) -- whether the field must be filled before form submission
- `disabled`: boolean (default: false) -- whether the input is disabled
- `...restProps`: spread onto the `<input>` element

## Usage

```html
<SearchInput label="Search" value={value} />
```

```html
<SearchInput label="Filter products" value={query} required />
```

## Keyboard Interactions

- Escape: clears the search field (browser-native behavior for search inputs)
- Enter: submits the containing form (standard input behavior)

Note: keyboard interactions are provided natively by the `<input type="search">` element.

## ARIA

- `aria-label={label}` -- provides the accessible name for the search field since no visible label element is associated

## When to Use

- Use SearchInput for site-wide search bars, list filtering, and any interface where users need to enter a search query.
- Use SearchInput to benefit from browser-native search behaviors such as the Escape-to-clear shortcut and search-optimized mobile keyboards.
- Avoid using SearchInput for general text entry; use TextInput instead.
- Consider Combobox when search results should appear as a filterable dropdown list.

## Headless

The SearchInput headless component provides a native `<input type="search">` with `aria-label` for accessible naming and two-way value binding. The browser provides semantic search behavior and may show a native clear button. The consumer provides all visual styling, search icons, and result handling.

## Advice

- **Designers**: Include a visible search icon or placeholder text to clearly indicate the field's purpose, and ensure the clear button (native or custom) is easily discoverable.
- **Developers**: Debounce the search input value to avoid excessive search requests, and wrap the input in a `<form>` with `role="search"` for full semantic search landmark support.

## References

- WAI-ARIA Search Role: https://www.w3.org/WAI/ARIA/apd/patterns/search/
- MDN input type="search": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/search
