# Public Good Design System: Components

Reference: [../CLAUDE.md](../CLAUDE.md) for the full component list, naming patterns, and composition patterns.

Reference: [../css-style-sheet-template.css](../css-style-sheet-template.css) for CSS class names.

## Purpose

This directory contains framework-agnostic component documentation. Each subdirectory represents one component and contains an `index.md` file with a `README.md` symlink.

## Documentation Principles

- Framework-agnostic: documentation describes behavior and semantics, not framework-specific implementation
- Proper HTML examples using semantic elements
- ARIA references for accessibility
- Consistent structure across all components

## Component index.md Structure

Each component `index.md` follows this structure:

1. **Heading**: `# Component Name` matching the directory name in Title Case
2. **Description**: one-sentence summary of what the component is and does
3. **Use case**: one-sentence description of when to use the component
4. **Implementation Notes**: bullet list of key implementation details
5. **Props**: bullet list of all props with types, defaults, and descriptions
6. **Usage**: HTML code example showing basic usage
7. **Keyboard Interactions**: keyboard behaviors (or "None" for passive elements)
8. **ARIA**: accessibility attributes and roles used
9. **When to Use**: guidance on when this component is appropriate
10. **Headless**: explanation of headless usage, business logic, and consumer responsibilities
11. **Styles**: CSS class names and styling guidance for consumers
12. **Testing**: framework-agnostic test criteria for the component
13. **Advice**: helpful suggestions for designers and developers
14. **Domain Knowledge**: relevant domain context (for specialized components)
15. **References**: links to relevant standards, MDN docs, and design system references

## Composition Patterns

If the component uses a composition pattern, add a **Composition** section explaining the pattern and relationships among related components.

Examples of composition patterns:

- `*Nav` `*NavList` `*NavListItem` (e.g., AccordionNav, BreadcrumbNav)
- `*List` `*ListItem` (e.g., CheckList, ContentsList, SummaryList)
- `*Table` `*TableHead` `*TableBody` `*TableFoot` `*TableCol` `*TableRow` `*TableData`
- `*Bar` `*BarButton` (e.g., MenuBar, TabBar, TaskBar, ToolBar)
- `*Picker` `*PickerButton` (e.g., ColorPicker, FiveStarRatingPicker)
- `*Input` `*View` (e.g., VitalSign paired components)

## Vital Sign Components

Vital sign components follow the Input/View pattern:

- **View**: `<span>` with `role="img"`, `aria-label`, `data-value`, displays the value as text content
- **Input**: `<input type="number">` with `aria-label`, bindable value, domain-specific min/max/step defaults

Integer types use `step=1`. Decimal types use `step=0.1` (one decimal point) or `step=0.01` (two decimal places).

## File Structure

```
components/
  component-name/
    index.md     # Main documentation
    README.md    # Symlink → index.md
```
