# Public Good Design System - Vue Headless

A headless Vue 3 component library with 236 components. All components are headless (no built-in styles), fully accessible (WCAG 2.2 AAA), and use Vue 3 Composition API with `<script setup lang="ts">`.

## Features

- 236 headless Vue components
- TypeScript with full type definitions
- WCAG 2.2 AAA accessibility compliance
- Full keyboard navigation support
- ARIA attributes and roles
- Internationalization-ready (no hardcoded strings)
- Zero dependencies beyond Vue
- Works with any CSS framework or custom styles

## Quick Start

### Install

```bash
npm install public-good-design-system-vue-headless
```

### Peer Dependencies

```json
{
  "vue": "^3.0.0"
}
```

### Basic Usage

```vue
<script setup lang="ts">
import { ref } from "vue";
import Button from "public-good-design-system-vue-headless/components/Button.vue";
import TextInput from "public-good-design-system-vue-headless/components/TextInput.vue";
import Alert from "public-good-design-system-vue-headless/components/Alert.vue";

const name = ref("");
</script>

<template>
  <TextInput label="Your name" v-model="name" placeholder="Enter your name" />
  <Button @click="alert(`Hello, ${name}!`)">Greet</Button>
  <Alert v-if="name" type="success" heading="Greeting">
    Welcome, {{ name }}!
  </Alert>
</template>
```

## Architecture

### Headless Design

Components provide:
- Semantic HTML structure
- ARIA attributes for accessibility
- Props and events for behavior
- Keyboard interaction patterns

Components do NOT provide:
- CSS styles or stylesheets
- Visual styling or themes
- Tailwind classes
- Any built-in appearance

### Component File Structure

Each component consists of three files:

```
components/
  Button.vue         # Component implementation
  Button.test.ts     # Tests (Vue Testing Library + Vitest)
  Button.md          # Documentation
```

### Vue Component Conventions

- `<script setup lang="ts">` syntax for all components
- `defineProps<{}>()` with `withDefaults()` for prop definitions
- `defineModel()` for two-way bindable props (v-model)
- `computed()` for derived values
- Headless: no CSS embedded, uses CSS class names matching kebab-case component name
- `v-bind="$attrs"` for pass-through attributes

### CSS Class Convention

Every component's root element includes a semantic CSS class matching its kebab-case name:

```vue
<Button class="my-custom">Click</Button>
<!-- Renders: <button class="button my-custom">Click</button> -->
```

### Naming Conventions

Component names follow a suffix-based pattern that indicates the root HTML element:

| Suffix | HTML Element | Example |
|--------|-------------|---------|
| Button | `<button>` | `Button`, `ToggleButton` |
| Input | `<input>` | `TextInput`, `DateInput` |
| Select | `<select>` | `Select`, `ThemeSelect` |
| Dialog | `<dialog>` | `Dialog`, `AlertDialog` |
| Nav | `<nav>` | `BreadcrumbNav`, `TreeNav` |
| List | `<ol>` | `CheckList`, `TaskList` |
| ListItem | `<li>` | `CheckListItem`, `TaskListItem` |
| Table | `<table>` | `DataTable`, `CalendarTable` |
| TableHead | `<thead>` | `DataTableHead` |
| TableBody | `<tbody>` | `DataTableBody` |
| TableRow | `<tr>` | `DataTableRow` |
| TableData | `<td>` | `DataTableData` |
| Div | `<div>` | `PinInputDiv`, `PasswordInputDiv` |
| Meter | `<meter>` | `Meter` |
| Progress | `<progress>` | `Progress` |
| Fieldset | `<fieldset>` | `Fieldset` |

## Components

- **accordion**:
  - **accordion-nav**: a navigation container for collapsible accordion information
  - **accordion-nav-list**: an ordered list of accordion nav list item components
  - **accordion-nav-list-item**: one accordion nav list item component
- **action-link**: a hyperlink styled as an action trigger
- **alert-dialog**: a modal dialog for urgent messages requiring user acknowledgment
- **alert**: a status message for important information or feedback
- **angle-slider-range-input**: a range input for selecting an angle in degrees
- **aspect-ratio-container**: a container that maintains a fixed aspect ratio
- **avatar**:
  - **avatar**: an avatar indicator that shows an avatar image or avatar text
  - **avatar-image**: an avatar indicator inside image such as a user photo
  - **avatar-text**: an avatar indicator inner text such as a user name
- **back-link**: a navigation link to return to a previous page
- **badge**: a small label for counts, statuses, or categories
- **banner**: a prominent message bar across the top of a page
- **beach-ball**: a decorative animated beach ball element
- **breadcrumb**:
  - **breadcrumb-nav**: a navigation container for breadcrumb trail links
  - **breadcrumb-nav-list**: an ordered list of breadcrumb navigation items
  - **breadcrumb-nav-list-item**: one breadcrumb navigation link in the trail
- **button**: a generic clickable button element
- **button-input**: an input element of type button for form actions
- **calendar-table**:
  - **calendar-table**: a calendar table interactive grid for managing dates, days, etc.
  - **calendar-table-head**: a calendar table interactive grid thead for managing dates, days, etc.
  - **calendar-table-body**: a calendar table interactive grid tbody for managing dates, days, etc.
  - **calendar-table-foot**: a calendar table interactive grid tfoot for managing dates, days, etc.
  - **calendar-table-col**: a calendar table interactive grid column for managing dates, days, etc.
  - **calendar-table-row**: a calendar table interactive grid row for managing dates, days, etc.
  - **calendar-table-data**: a calendar table interactive grid data cell for managing dates, days, etc.
- ...and 200+ more components

See the [parent project](https://github.com/joelparkerhenderson/public-good-design-system) for the full component list.

## Component Name Patterns

- \*Bar \*BarButton: MenuBar MenuBarButton, TabBar TabBarButton, TaskBar TaskBarButton, ToolBar ToolBarButton
- \*Nav \*NavList \*NavListItem: AccordionNav, BreadcrumbNav, ContentsNav, PaginationNav, TreeNav
- \*List \*ListItem: CheckList, ContentsList, DoList, DontList, PaginationList, SummaryList
- \*Picker \*PickerButton: ColorPicker, FiveStarRatingPicker, NetPromoterScorePicker, RedAmberGreenPicker
- \*Table \*TableHead \*TableBody \*TableFoot \*TableCol \*TableRow \*TableData: CalendarTable, DataTable, GanttTable, KanbanTable

## Testing

Vitest + Vue Testing Library for component testing. No @testing-library/jest-dom.

```sh
npm test          # run all tests
npm run test:ui   # open vitest UI
npm run test:watch # watch mode
```

## Accessibility

All components follow WCAG 2.2 AAA guidelines:

- **Semantic HTML**: Proper element usage (`<button>`, `<nav>`, `<dialog>`, etc.)
- **ARIA attributes**: Roles, labels, states, and properties
- **Keyboard navigation**: Full keyboard support for all interactive components
- **Screen readers**: Proper announcements via aria-live, role="alert", etc.
- **Focus management**: Logical focus order and visible focus indicators
- **Error handling**: Accessible error messages linked via aria-errormessage

## Internationalization

No strings are hardcoded in any component. All user-facing text comes through props.

## Related Projects

- [Public Good Design System](https://github.com/joelparkerhenderson/public-good-design-system) — Parent project
- [Vue Nuxt Examples](../public-good-design-system-vue-nuxt-examples/) — Example app with NHS UK styling
- [Svelte Headless](../public-good-design-system-svelte-headless/) — Svelte equivalent
- [React Headless](../public-good-design-system-react-headless/) — React equivalent
- [Blazor Headless](../public-good-design-system-blazor-headless/) — Blazor equivalent

## License

MIT or Apache-2.0 or GPL-2.0 or GPL-3.0, or contact us for more options.

## Contact

Joel Parker Henderson (joel@joelparkerhenderson.com)
