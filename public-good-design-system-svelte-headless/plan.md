# Plan: Public Good Design System Plus Svelte

---

## 3. Component Architecture

### 3b. Svelte 5 Runes Pattern

All components use Svelte 5 runes syntax:

```svelte
<script lang="ts">
    // Props via $props() rune
    let {
        class: className = '',
        propName = defaultValue,
        ...restProps
    }: {
        propName?: type;
        [key: string]: unknown;
    } = $props();

    // Reactive state via $state() rune
    let internalState = $state(initialValue);

    // Derived values via $derived() rune
    let computedValue = $derived(expression);
</script>
```

### 3c. TypeScript Conventions

- All components use `<script lang="ts">`
- Props are typed inline with `$props()` destructuring
- Export types when components define complex prop shapes
- Use explicit return types on functions

### 3d. Prop Conventions

- **restProps**: All components accept `{...restProps}` for HTML attribute passthrough
- **Common props**: `disabled`, `required`, `value`, `label`, `name`, `id`
- **Bindable state**: Use `$bindable()` for two-way binding props (e.g., `value`, `open`, `checked`)
- **Event callbacks**: Use callback props (e.g., `onchange`, `onclick`) rather than Svelte event directives
- **String externalization**: Never hardcode user-facing strings; use prop attributes

---

## 4. Component Implementation Template

### 4a. .svelte File Template

```svelte
<script lang="ts">
    // Component: {ComponentName}
    //
    // A headless {component description} component.
    //
    // Usage:
    //   <{ComponentName} prop={value} />
    //
    // Props:
    //   className — string, optional. CSS class name.
    //   - propName: description (default: value)
    //
    // Accessibility:
    //   - Role: {role}
    //   - Keyboard: {keyboard interactions}
    //   - ARIA: {aria attributes used}

    /** Props interface */
    let {
        class: className = '',
        // Required props
        // Optional props with defaults
        ...restProps
    }: {
        // Type definitions
        [key: string]: unknown;
    } = $props();
</script>

<!-- Semantic HTML with ARIA attributes -->
```

### 4b. .svelte.test.ts File Template

```typescript
import { render, screen } from "@testing-library/svelte";
import { userEvent, type UserEvent } from "@testing-library/user-event";
import { expect, test, describe } from "vitest";

import Subject from "./{ComponentName}.svelte";

describe("{ComponentName}", () => {
  test("renders with default props", () => {
    render(Subject);
    // Assert semantic HTML structure
  });

  test("accepts and applies props", () => {
    render(Subject, { propName: "value" });
    // Assert props are applied
  });

  test("keyboard navigation", async () => {
    const user: UserEvent = userEvent.setup();
    render(Subject);
    // Test Tab, Enter, Space, Arrow keys, Escape
  });

  test("ARIA attributes", () => {
    render(Subject);
    // Assert all required ARIA attributes
  });

  test("screen reader accessibility", () => {
    render(Subject);
    // Assert aria-label, aria-describedby, etc.
  });
});
```

### 4c. index.md Template (for components missing documentation)

```markdown
# {Component Name}

{1-2 paragraph description of the component, its purpose, and common use cases.}

## Usage

{Brief description of how to use the component.}

## Props

| Prop | Type | Default | Description |
| ---- | ---- | ------- | ----------- |
| ...  | ...  | ...     | ...         |

## Accessibility

- **Role**: {WAI-ARIA role}
- **Keyboard**: {keyboard interactions}
- **Screen reader**: {screen reader behavior}

## Examples

{Code examples showing common usage patterns.}
```

### 4d. CLAUDE.md Template (per-component notes)

```markdown
# {ComponentName}

## Implementation Notes

- {Key implementation decisions}
- {ARIA pattern reference}
- {Keyboard interaction model}

## Sub-components

- {List any sub-components if compound}

## References

- {WAI-ARIA Authoring Practices link if applicable}
```

---

## 5. Component Categories & Implementation Notes

Components are grouped by category for context. Implementation is alphabetical.

### 5a. Form Inputs (Native HTML Wrappers)

These wrap native HTML `<input>` elements with proper labeling, ARIA, and accessibility:

- button-input, checkbox-input, color-input, date-input, datetime-local-input, email-input, file-input, hidden-input, month-input, number-input, password-input, radio-input, range-input, reset-input, search-input, submit-input, tel-input, text-input, time-input, url-input, week-input

**Pattern**: Wrap `<input type="{type}">` with `<label>`, `<div>` container, aria-describedby for hints/errors.

### 5b. Form Components (Custom/Enhanced)

Richer form components beyond native inputs:

- checkbox, combobox, date-field, date-picker, date-range, date-range-picker, field, fieldset, form, input, listbox, option, pin-input, radio-button, radio-group, rating-group, select, select-with-extras, slider, switch-input, tag-input, textarea, textfield, toggle, toggle-group

### 5c. Display/Content Components

- alert, badge, banner, caption, card, character, character-counter, details, emoji, error-message, error-summary, flair, footnote, hint, hint-text, icon, image, inset-text, label, notification, separator, skeleton, sparkline, tag, tag-group, toast, tooltip

### 5d. Navigation Components

- action-link, back-link, breadcrumb, breadcrumbs, contents-list, hamburger-menu, menu, menubar, navigation-menu, pagination, sidebar, skip-link, steps, tab, tab-bar, table-of-contents-list, tree-nav, tree-view

### 5e. Layout Components

- aspect-ratio-container, collapsible, drawer, floating-panel, holy-grail-layout, panel, resizable, scroll-area, scrollbar, sheet, slide-out-drawer, splitter

### 5f. Overlay/Dialog Components

- alert-dialog, command, context-menu, dialog, dropdown-menu, file-dialog, hover-card, popover, popup, tour

### 5g. Data Display Components

- chart, data-filter-form, data-table, gannt-chart, gauge, meter, progress-bar, progress-circle, progress-spinner, qr-code, summary-list, table, task-list, timeline, timer

### 5h. Interactive/Specialized Components

- accordion, angle-slider, avatar-circle, beach-ball, calendar-board, calendar-input, calendar-range-picker, call-to-action, carousel, clipboard-copy-button, color-picker, color-picker, color-picker-swatch-button, dial, do-dont-list, do-list, dont-list, editable, editable-form, emoji-character-picker, expander, file-manager, file-upload, kanban-board, range-calendar, review-date, segment-group, signature-pad, sonner, spinner, theme-select, theme-picker, theme-view

### 5i. Rating Components

- five-face-rating-picker, five-face-rating-view, five-star-rating-picker, five-star-rating-view, net-promoter-score-picker, net-promoter-score-view

### 5j. Status/Indicator Components

- red-amber-green-picker, red-amber-green-view, red-amber-green-status, red-orange-yellow-green-blue-indicator-status, red-orange-yellow-green-blue-status-select, red-orange-yellow-green-blue-view

### 5k. Structured Data Components

- email-address-input, email-link, measurement-instance-input, measurement-instance-view, measurement-system-input, measurement-system-view, measurement-unit-input, measurement-unit-view, phone-number-input, phone-number-view, postal-code-input, postal-code-view, united-kingdom-national-health-service-number-input, united-kingdom-national-health-service-number-view, united-states-social-security-number-input, united-states-social-security-number-view

### 5l. Medical/Domain-Specific Components

- care-card, do-dont-list, information-callout, medical-highlight-box, medical-patient-banner-danger-box, warning-callout

### 5m. Page Structure Components

- footer, header

---

## 6. Compound Component Strategy

Some components are compound (have multiple sub-parts). Strategy:

### Same-Directory Sub-components

Compound components keep sub-components in the same directory:

- **accordion/**: Accordion.svelte + AccordionItem.svelte
- **breadcrumbs/**: Breadcrumbs.svelte + BreadcrumbItem.svelte
- **tabs/tab-bar/**: TabBar.svelte + TabPanel.svelte + TabTrigger.svelte
- **data-table/**: DataTable.svelte + DataTableRow.svelte + DataTableCell.svelte + DataTableHeader.svelte
- **dropdown-menu/**: DropdownMenu.svelte + DropdownMenuItem.svelte + DropdownMenuSeparator.svelte
- **navigation-menu/**: NavigationMenu.svelte + NavigationMenuItem.svelte
- **radio-group/**: RadioGroup.svelte + RadioGroupItem.svelte
- **toggle-group/**: ToggleGroup.svelte + ToggleGroupItem.svelte
- **tree-view/**: TreeNavList.svelte + TreeNavListItem.svelte

### Naming Convention for Sub-components

Sub-components are named as `{ParentName}{SubPart}.svelte`:

- AccordionItem.svelte
- TabPanel.svelte
- DataTableRow.svelte

Tests cover the compound component as a whole, not individual sub-components.

---

## 7. ARIA Pattern References

Key WAI-ARIA Authoring Practices patterns used:

| Component      | ARIA Pattern                   |
| -------------- | ------------------------------ |
| accordion      | Accordion Pattern              |
| alert          | Alert Pattern                  |
| alert-dialog   | Alert Dialog Pattern           |
| breadcrumbs    | Breadcrumb Pattern             |
| button         | Button Pattern                 |
| carousel       | Carousel Pattern               |
| checkbox       | Checkbox Pattern               |
| combobox       | Combobox Pattern               |
| dialog         | Dialog (Modal) Pattern         |
| disclosure     | Disclosure (Show/Hide) Pattern |
| listbox        | Listbox Pattern                |
| menu / menubar | Menu / Menu Bar Pattern        |
| meter          | Meter Pattern                  |
| radio-group    | Radio Group Pattern            |
| slider         | Slider Pattern                 |
| switch         | Switch Pattern                 |
| tab-bar        | Tabs Pattern                   |
| tooltip        | Tooltip Pattern                |
| tree-view      | Tree View Pattern              |

---

## 8. Testing Strategy

### Test Categories per Component

1. **Rendering**: Component renders correct semantic HTML
2. **Props**: Props are applied correctly, defaults work
3. **ARIA**: All required ARIA attributes are present and correct
4. **Keyboard**: Tab, Enter, Space, Arrow keys, Escape work as expected
5. **Screen reader**: aria-label, aria-live, role announcements
6. **State**: Interactive state changes work correctly
7. **Edge cases**: Empty states, disabled states, error states

### Test Utilities

- `@testing-library/svelte`: render, screen, cleanup
- `@testing-library/user-event`: userEvent.setup() for realistic interactions
- `vitest`: test, describe, expect, vi (mocks)

### Running Tests

```bash
npm test              # Run all tests once
npm run test:watch    # Watch mode
npm run test:ui       # Vitest UI
```

---

## 9. Implementation Order

Implementation proceeds in **strict alphabetical order** by component directory name. Each component is a self-contained task that produces all 4 required files:

1. CLAUDE.md (updated with implementation notes)
2. index.md (created if missing, kept if exists)
3. {ComponentName}.svelte
4. {ComponentName}.svelte.test.ts

Infrastructure tasks come first, then components A-Z.

---

## 10. Input/View Component Pattern

Many components come in paired `-input` / `-view` variants:

- **-input**: Editable form component for data entry
- **-view**: Read-only display component for showing data

Examples:

- `email-address-input` (editable email field) / `email-link` (displays formatted email)
- `phone-number-input` (editable phone field) / `phone-number-view` (displays formatted phone)
- `red-amber-green-picker` (select RAG status) / `red-amber-green-view` (display RAG status)

### Input Pattern

```svelte
<script lang="ts">
    let {
        class: className = '', value = $bindable(""), label, name, ...restProps } = $props();
</script>

<label>
    {label}
    <input bind:value {name} {...restProps} />
</label>
```

### View Pattern

```svelte
<script lang="ts">
    let {
        class: className = '', value, label, ...restProps } = $props();
</script>

<dl {...restProps}>
    <dt>{label}</dt>
    <dd>{value}</dd>
</dl>
```
