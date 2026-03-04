# Plan: Vue Nuxt.js Examples for All Components

## Overview

Create a Vue 3 / Nuxt.js project containing example pages that demonstrate all components from the Public Good Design System. This mirrors the React Next.js examples project but uses Vue composition API and Nuxt conventions. The examples import headless components from the `public-good-design-system-vue-headless` sibling library and use NHS UK design system styles.

## Project Structure

```
public-good-design-system-vue-nuxt-examples/
├── CLAUDE.md                  (exists)
├── plan.md                    (this file)
├── package.json
├── nuxt.config.ts
├── tsconfig.json
├── vitest.config.ts
├── app.vue                    (root layout with NHS UK theming)
├── assets/
│   └── css/
│       └── nhs.css            (NHS UK design system CSS variables & base styles)
├── components/                (headless Vue components — one .vue per component)
│   ├── AccordionNav.vue
│   ├── AccordionNavList.vue
│   ├── AccordionNavListItem.vue
│   ├── ActionLink.vue
│   ├── Alert.vue
│   ├── AlertDialog.vue
│   ├── ... (all ~230 components)
│   └── WeekInput.vue
├── pages/                     (Nuxt pages — example compositions)
│   ├── index.vue              (home page with links to all examples)
│   ├── contact-form.vue
│   ├── dashboard.vue
│   ├── dialog-flow.vue
│   ├── file-upload-form.vue
│   ├── navigation-and-menus.vue
│   ├── page-layout.vue
│   ├── rating-and-feedback.vue
│   ├── search-and-filter.vue
│   ├── settings-page.vue
│   ├── tabbed-interface.vue
│   ├── task-management.vue
│   └── timeline-and-cards.vue
└── tests/                     (vitest component tests)
    └── components/
        ├── AccordionNav.test.ts
        ├── Alert.test.ts
        ├── Button.test.ts
        ├── ... (one test per component)
        └── WeekInput.test.ts
```

## Step-by-Step Implementation

### Step 1: Project scaffolding
Create `package.json`, `nuxt.config.ts`, `tsconfig.json`, `vitest.config.ts`, `.gitignore`, and `app.vue`.

- **package.json**: Nuxt 3, Vue 3, vitest, @testing-library/vue, @testing-library/user-event, jsdom
- **nuxt.config.ts**: Basic Nuxt config with CSS imports
- **vitest.config.ts**: Vue plugin, jsdom environment
- **app.vue**: Root `<NuxtLayout>` / `<NuxtPage>` with NHS CSS

### Step 2: NHS UK CSS variables
Create `assets/css/nhs.css` with NHS design system color tokens, typography, spacing, and focus state styles per:
- NHS Blue (#005eb8), Dark Blue (#003087), White (#ffffff)
- NHS secondary colors (green, red, yellow, warm yellow, purple)
- NHS grey palette (1-5)
- Focus state: yellow (#ffeb3b) background with 4px black border
- Typography: Frutiger/system-ui stack, 16px base
- Spacing scale: 4/8/16/24/32/40/48/56/64px

### Step 3: Headless Vue components (all ~230)
Create one `.vue` SFC per component in `components/`. Each component:
- Uses Vue 3 `<script setup lang="ts">` syntax
- Accepts props matching the React headless counterpart
- Uses `defineProps`, `defineEmits`, `useSlots`
- Emits events instead of callback props (Vue convention)
- Renders the same semantic HTML elements
- Includes same ARIA attributes
- Is headless (no styles baked in, uses CSS class names)
- Supports `v-bind="$attrs"` for pass-through attributes

**Pattern example** (Button.vue):
```vue
<script setup lang="ts">
interface Props {
  type?: 'button' | 'submit' | 'reset'
  disabled?: boolean
  pressed?: boolean
  label?: string
}
withDefaults(defineProps<Props>(), {
  type: 'button',
  disabled: false,
  pressed: undefined,
  label: undefined,
})
</script>

<template>
  <button
    class="button"
    :type="type"
    :disabled="disabled"
    :aria-pressed="pressed"
    :aria-label="label"
  >
    <slot />
  </button>
</template>
```

### Step 4: Example pages (13 pages)
Create Nuxt pages in `pages/` directory, each demonstrating a composition of components. These mirror the React examples:

1. **index.vue** — Home page with links to all examples
2. **contact-form.vue** — Form, Field, TextInput, EmailInput, Textarea, Select, ErrorSummary
3. **dashboard.vue** — Card, Progress, ProgressCircle, Badge, Banner, DataTable
4. **dialog-flow.vue** — Dialog, AlertDialog, Drawer, Popover, Tooltip
5. **file-upload-form.vue** — FileUpload, Progress, Badge, Form, Field
6. **navigation-and-menus.vue** — NavigationMenu, MenuBar, ToolBar, HamburgerMenu, DropdownMenu
7. **page-layout.vue** — SkipLink, Header, Footer, NavigationMenu, BreadcrumbNav, Sidebar
8. **rating-and-feedback.vue** — FiveStarRatingPicker, FiveFaceRatingPicker, NetPromoterScorePicker
9. **search-and-filter.vue** — Combobox, SearchInput, TagInput, DataTable
10. **settings-page.vue** — SwitchButton, RadioGroup, Select, Fieldset, Banner
11. **tabbed-interface.vue** — TabBar, TabBarButton, AccordionNav, Badge
12. **task-management.vue** — TaskList, TaskListItem, TextInput, CheckboxInput, Button, Badge, Progress
13. **timeline-and-cards.vue** — TimelineList, TimelineListItem, Card, Badge, DateRange, ReviewDate

### Step 5: Component tests
Create vitest tests in `tests/components/` using `@testing-library/vue`. Each test:
- Uses `render` from `@testing-library/vue`
- Uses vitest built-in matchers only (NO jest-dom)
- Tests: renders correctly, props work, ARIA attributes present, events fire, keyboard interaction
- Follows the exact test pattern from the React headless tests, adapted for Vue

### Step 6: Install and verify
Run `npm install`, `npm test`, and verify the project builds with `npx nuxt build`.

## Component Groupings for Batch Creation

To manage the ~230 components efficiently, create them in batches:

1. **Accordion** (3): AccordionNav, AccordionNavList, AccordionNavListItem
2. **Navigation** (9): ActionLink, BackLink, BreadcrumbNav, BreadcrumbNavList, BreadcrumbNavListItem, ContentsNav, ContentsList, ContentsListItem, NavigationMenu
3. **Alerts & Messages** (6): Alert, AlertDialog, Banner, ErrorMessage, ErrorSummary, Notification
4. **Buttons** (8): Button, ButtonInput, ClipboardCopyButton, HamburgerMenu, ResetInput, SubmitInput, SwitchButton, ToggleButton
5. **Forms & Inputs** (25): CheckboxInput, ColorInput, DateInput, DatetimeLocalInput, EmailInput, FileInput, HiddenInput, ImageFileInput, Input, MonthInput, NumberInput, PasswordInputDiv, PinInputDiv, RadioInput, RangeInput, SearchInput, Select, SelectWithExtras, TelInput, TextInput, Textarea, TimeInput, TimePickerInput, UrlInput, WeekInput
6. **Form Structure** (7): DataFilterForm, EditableForm, Editable, Field, Fieldset, Form, Label
7. **Display** (14): AspectRatioContainer, Avatar, AvatarImage, AvatarText, Badge, Caption, Card, Character, CharacterCounter, Emoji, Figure, Flair, Icon, Image
8. **Layout** (8): Footer, Header, HolyGrailLayout, Panel, Separator, Sidebar, FloatingPanel, Collapsible
9. **Lists** (14): CheckList, CheckListItem, DoList, DoListItem, DontList, DontListItem, SummaryList, SummaryListItem, TaskList, TaskListItem, TimelineList, TimelineListItem, TourList, TourListItem
10. **Tables** (21): CalendarTable/Head/Body/Foot/Col/Row/Data, DataTable/Head/Body/Foot/Col/Row/Data, GanttTable/Head/Body/Foot/Col/Row/Data
11. **Kanban** (7): KanbanTable, KanbanTableHead, KanbanTableBody, KanbanTableFoot, KanbanTableCol, KanbanTableRow, KanbanTableData
12. **Overlays** (10): ContextMenu, ContextMenuItem, Dialog, Drawer, DropdownMenu, HoverCard, Popover, Popup, Sheet, SlideOutDrawer
13. **Ratings** (12): FiveFaceRatingView/Picker/PickerButton, FiveStarRatingView/Picker/PickerButton, NetPromoterScoreView/Picker/PickerButton, RedAmberGreenView/Picker/PickerButton
14. **Color Ratings** (3): RedOrangeYellowGreenBlueView, RedOrangeYellowGreenBluePicker, RedOrangeYellowGreenBluePickerButton
15. **Pagination** (3): PaginationNav, PaginationList, PaginationListItem
16. **Menus & Bars** (12): Menu, MenuItem, MenuBar, MenuBarButton, TabBar, TabBarButton, TaskBar, TaskBarButton, ToolBar, ToolBarButton, ToggleGroup, SegmentGroup
17. **Pickers & Special** (10): CalendarRangePicker, ColorPicker, ColorPickerButton, Combobox, Command, DateField, DateRange, Dial, EmojiCharacterPicker, Listbox
18. **Progress** (4): Meter, Progress, ProgressCircle, ProgressSpinner
19. **Misc** (16): BeachBall, CareCard, Details, Expander, FileDialog, FileManager, FileUpload, Footnote, Hint, InformationCallout, InsetText, MedicalRecordRedBox, Option, QrCode, ReviewDate, WarningCallout
20. **Tags & Groups** (4): Tag, TagGroup, TagInput, SegmentGroupItem
21. **Advanced** (12): Carousel, Resizable, ScrollArea, ScrollBar, SignaturePad, Skeleton, SkipLink, Slider, Sonner, Sparkline, Splitter, Timer
22. **Theme** (4): ThemePicker, ThemeSelect, ThemeSelectOption, ThemeView
23. **Specialty** (7): PostalCodeInput, PostalCodeView, RadioGroup, Toast, Tooltip, Tour, TreeNav/TreeNavList
24. **Links** (2): EmailLink, TelLink
25. **Measurement** (6): MeasurementInstanceInput/View, MeasurementSystemInput/View, MeasurementUnitInput/View
26. **UK/US** (4): UKNHSNumberInput/View, USSocialSecurityNumberInput/View

## Key Decisions

- **Vue 3 Composition API** with `<script setup>` — modern, concise, TypeScript-friendly
- **Nuxt 3** for routing, auto-imports, and SSR-ready pages
- **Headless components** — no styles embedded, NHS CSS applied at page/layout level
- **NHS UK design tokens** — all colors, spacing, typography from NHS identity guidelines
- **vitest + @testing-library/vue** — consistent with sibling repos' testing approach
- **No jest-dom matchers** — vitest built-in only per CLAUDE.md rules
