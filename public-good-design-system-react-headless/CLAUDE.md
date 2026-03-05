# Public Good Design System - React Headless

## Project Overview

A headless React component library with 236 accessible, unstyled components. Converted from the Svelte 5 sibling project (`public-good-design-system-plus-svelte`).

## Quick Reference

- **Package**: public-good-design-system-react-headless
- **Version**: 0.1.0
- **Created**: 2026-03-03
- **License**: MIT or Apache-2.0 or GPL-2.0 or GPL-3.0 or contact us for more
- **Contact**: Joel Parker Henderson (joel@joelparkerhenderson.com)

## IMPORTANT Architecture

- React 19 with TypeScript
- Functional components (no class components)
- Headless design: zero CSS, zero styles
- WCAG 2.2 AAA accessibility
- Each component: `.tsx` + `.test.tsx` + `.md`
- All files in `components/` directory (flat structure)
- Standalone examples in `examples/` directory

## STRICT Prohibitions

- **No Next.js** — pure React only
- **No @testing-library/jest-dom** — use vitest matchers only
- **No CSS/styles** — no Tailwind, no styled-components, no DaisyUI, no inline styles
- **No images, icons, or fonts** — consumers provide these
- **No hardcoded user-facing strings** — all text through props

## Component Patterns

### File Naming

Each component has exactly three files:
```
{ComponentPascalCase}.tsx       # Implementation
{ComponentPascalCase}.test.tsx  # Tests
{ComponentPascalCase}.md        # Documentation
```

### Root Element CSS Class

Every component's first HTML element sets a class combining the kebab-case name with consumer className:
```tsx
<button className={`button ${className}`} ...>
<div className={`banner ${className}`} ...>
<nav className={`breadcrumb-nav ${className}`} ...>
```

### Suffix → HTML Element Mapping

| Suffix | Element | Example |
|--------|---------|---------|
| Button | `<button>` | Button, ToggleButton, SwitchButton |
| Dialog | `<dialog>` | Dialog, AlertDialog, FileDialog |
| Div | `<div>` | PinInputDiv, PasswordInputOrTextInputDiv |
| Fieldset | `<fieldset>` | Fieldset |
| Figure | `<figure>` | Figure |
| Footer | `<footer>` | Footer |
| Header | `<header>` | Header |
| Input | `<input>` | TextInput, DateInput, EmailInput |
| List | `<ol>` | CheckList, TaskList (DoList/DontList use `<ul>`) |
| ListItem | `<li>` | CheckListItem, TaskListItem |
| Meter | `<meter>` | Meter |
| Nav | `<nav>` | BreadcrumbNav, TreeNav |
| Option | `<option>` | Option, ThemeSelectOption |
| Picker | `<div>` | ColorPicker, FiveStarRatingPicker |
| Progress | `<progress>` | Progress |
| Select | `<select>` | Select, ThemeSelect |
| Span | `<span>` | Flair, Character |
| Table | `<table>` | DataTable, CalendarTable |
| TableHead | `<thead>` | DataTableHead |
| TableBody | `<tbody>` | DataTableBody |
| TableFoot | `<tfoot>` | DataTableFoot |
| TableRow | `<tr>` | DataTableRow |
| TableData | `<td>` | DataTableData |

### Props Interface Pattern

```tsx
export interface ButtonProps {
    className?: string;
    // Component-specific props...
    children: React.ReactNode;
    [key: string]: unknown;  // Allow rest props
}

export default function Button({
    className = "",
    // Destructured with defaults...
    children,
    ...restProps
}: ButtonProps) {
    return (
        <button className={`button ${className}`} {...restProps}>
            {children}
        </button>
    );
}
```

### State Management

- Use `useState` for local state (e.g., `visible`, `open`, `copied`)
- Use `useRef` for DOM references
- Use `useEffect` for side effects and cleanup
- Controlled components: `value` + `onChange` callback pattern
- When a component has multiple bindable states, use distinct callbacks: `onChange` for the primary value, `onOpenChange` for open/close, `onEditingChange` for editing mode, etc.
- Auto-generate IDs with `Math.random().toString(36).slice(2, 9)` when not provided (prefer `useId()` for new components)

### Callback Naming Convention

All custom callback props use camelCase:
- `onChange`, `onSubmit`, `onReset`, `onClick` — standard React events
- `onClose`, `onCancel`, `onSuccess`, `onError` — custom callbacks
- `onOpenChange`, `onEditingChange`, `onValueChange` — secondary state callbacks
- `onAdd`, `onInputChange` — domain-specific callbacks
- Never lowercase: no `onclick`, `onsubmit`, `onadd`, etc.

### HTML Attribute Casing in JSX

React requires camelCase for DOM properties:
- `autoComplete` (not `autocomplete`)
- `inputMode` (not `inputmode`)
- `tabIndex` (not `tabindex`)
- `className` (not `class`)
- `htmlFor` (not `for`)
- `dateTime` (not `datetime`)
- `readOnly` (not `readonly`)

### Input/View Pattern

Paired components for data entry vs. read-only display:
- `FiveStarRatingPicker` (interactive) / `FiveStarRatingView` (read-only)
- `NetPromoterScorePicker` / `NetPromoterScoreView`
- `MeasurementInstanceInput` / `MeasurementInstanceView`
- `PostalCodeInput` / `PostalCodeView`

## Testing

### Stack

- **vitest** (not Jest) — `npm test` runs `vitest run`
- **@testing-library/react** — render and query
- **@testing-library/user-event** — user interaction simulation
- **jsdom** — DOM environment

### Matcher Rules (CRITICAL)

Vitest built-in matchers ONLY. Never use jest-dom matchers:

```tsx
// CORRECT — vitest matchers
expect(el).toBeTruthy();                           // element exists
expect(el).toBeNull();                             // element doesn't exist
expect(el.getAttribute("role")).toBe("button");     // check attribute
expect(el.textContent).toContain("hello");          // check text
expect(button.disabled).toBe(true);                 // check property
expect(handleClick).toHaveBeenCalledOnce();         // check callback

// WRONG — jest-dom matchers (NEVER use)
expect(el).toBeInTheDocument();
expect(el).toHaveAttribute("role", "button");
expect(el).toHaveTextContent("hello");
expect(button).toBeDisabled();
```

### Test File Pattern

```tsx
import { render, screen } from "@testing-library/react";
import userEvent, { type UserEvent } from "@testing-library/user-event";
import { describe, expect, test, vi } from "vitest";

import Subject from "./ComponentName";

describe("ComponentName", () => {
    test("renders with correct role", () => {
        render(<Subject label="Test">Content</Subject>);
        expect(screen.getByRole("button")).toBeTruthy();
    });

    test("handles click events", async () => {
        const user: UserEvent = userEvent.setup();
        const handleClick = vi.fn();
        render(<Subject onClick={handleClick}>Click</Subject>);
        await user.click(screen.getByRole("button"));
        expect(handleClick).toHaveBeenCalledOnce();
    });
});
```

### Test Cleanup

Automatic cleanup is configured in `vitest-setup.ts`:
```tsx
import { cleanup } from "@testing-library/react";
import { afterEach } from "vitest";
afterEach(() => { cleanup(); });
```

## Accessibility

### Standards

- WCAG 2.2 AAA compliance
- WAI-ARIA Authoring Practices patterns
- Semantic HTML elements over generic divs

### Common Patterns

- `<label htmlFor={id}>` — link labels to inputs
- `aria-labelledby` / `aria-describedby` — link related elements
- `aria-invalid` + `aria-errormessage` — error state
- `role="alert"` — announce dynamic content
- `role="group"` with `aria-label` — group related controls
- Roving tabindex (`tabIndex={selected ? 0 : -1}`) — grid navigation
- `aria-pressed` — toggle button state
- `aria-expanded` — expandable sections
- `aria-current` — current item in navigation

### Auto-Generated IDs

Components auto-generate unique IDs for ARIA linking:
```tsx
const generatedId = `component-${Math.random().toString(36).slice(2, 9)}`;
const inputId = id ?? generatedId;
const descriptionId = `${inputId}-desc`;
const errorId = `${inputId}-error`;
```

## Internationalization

- All text content through props — no hardcoded strings
- Labels, descriptions, error messages all configurable
- Consumer provides localized text via props

## Component Composition Patterns

### Form pattern: Form → Field → Input
```tsx
<Form label="Contact" onSubmit={handleSubmit}>
  <Field label="Name" required error={errors.name}>
    <TextInput label="Name" value={name} onChange={setName} />
  </Field>
  <ErrorSummary title="Errors"><ul>...</ul></ErrorSummary>
  <Button type="submit">Submit</Button>
</Form>
```

### Navigation pattern: Nav → List → ListItem
```tsx
<BreadcrumbNav label="Breadcrumb">
  <BreadcrumbNavList>
    <BreadcrumbNavListItem><a href="/">Home</a></BreadcrumbNavListItem>
    <BreadcrumbNavListItem current>Page</BreadcrumbNavListItem>
  </BreadcrumbNavList>
</BreadcrumbNav>
```

### Table pattern: Table → Head/Body → Row → Data
```tsx
<DataTable label="Users">
  <DataTableHead><DataTableRow><th>Name</th></DataTableRow></DataTableHead>
  <DataTableBody>
    {items.map(item => (
      <DataTableRow key={item.id}><DataTableData>{item.name}</DataTableData></DataTableRow>
    ))}
  </DataTableBody>
</DataTable>
```

## Known Gotchas

- `BreadcrumbNavListItem` has NO `href` prop — wrap links in child `<a>` elements
- `Alert` uses `heading` prop (not `label` or `title`)
- `Dialog` uses `label` prop (not `title`)
- `ErrorSummary` has `title` prop + `children` (no `errors` prop — render errors as children)
- `TabBarButton` requires `controls` prop (id of the associated panel)
- `RadioInput.onChange` receives a React ChangeEvent (not a value), unlike other inputs
- `Combobox` has separate `onChange` (value) and `onOpenChange` (open state) callbacks
- `FileUpload` uses `onInputChange` (not `onChange`) for file selection
- jsdom does not support `aspectRatio` CSS — test via data attributes instead

## Components

- accordion:
  - accordion-nav = AccordionNav = a navigation container for collapsible accordion information
  - accordion-nav-list = AccordionNavList = an ordered list of accordion nav list item components
  - accordion-nav-list-item = AccordionNavListItem = one accordion nav list item component
- action-link = ActionLink = a hyperlink styled as an action trigger
- alert-dialog = AlertDialog = a modal dialog for urgent messages requiring user acknowledgment
- alert = Alert = a status message for important information or feedback
- angle-slider-range-input = AngleSliderRangeInput = a range input for selecting an angle in degrees
- aspect-ratio-container = AspectRatioContainer = a container that maintains a fixed aspect ratio
- avatar:
  - avatar = Avatar = an avatar indicator that shows an avatar image or avatar text
  - avatar-image = AvatarImage = an avatar indicator inside image such as a user photo
  - avatar-text = AvatarText = an avatar indicator inner text such as a user name
- back-link = BackLink = a navigation link to return to a previous page
- badge = Badge = a small label for counts, statuses, or categories
- banner = Banner = a prominent message bar across the top of a page
- beach-ball = BeachBall = a decorative animated beach ball element
- breadcrumb:
  - breadcrumb-nav = BreadcrumbNav = a navigation container for breadcrumb trail links
  - breadcrumb-nav-list = BreadcrumbNavList = an ordered list of breadcrumb navigation items
  - breadcrumb-nav-list-item = BreadcrumbNavListItem = one breadcrumb navigation link in the trail
- button = Button = a generic clickable button element
- button-input = ButtonInput = an input element of type button for form actions
- calendar-table:
  - calendar-table = CalendarTable = a calendar table interactive grid for managing dates, days, etc.
  - calendar-table-head = CalendarTableHead = a calendar table interactive grid thead
  - calendar-table-body = CalendarTableBody = a calendar table interactive grid tbody
  - calendar-table-foot = CalendarTableFoot = a calendar table interactive grid tfoot
  - calendar-table-col = CalendarTableCol = a calendar table interactive grid column
  - calendar-table-row = CalendarTableRow = a calendar table interactive grid row
  - calendar-table-data = CalendarTableData = a calendar table interactive grid data cell
- calendar-range-picker = CalendarRangePicker = a picker for selecting a date range on a calendar
- call-to-action = CallToAction = a prominent prompt encouraging user action
- caption = Caption = a caption for a table or figure element
- card = Card = a grouped content container with header, body, and footer areas
- care-card = CareCard = a medical care instruction card with urgency levels
- carousel = Carousel = a slideshow for cycling through content items
- character-counter = CharacterCounter = a counter showing remaining or used characters in a text field
- character = Character = a single character display element
- checkbox-input = CheckboxInput = a checkbox input for toggling a boolean value
- check-list = CheckList = an ordered list of check list item components
- check-list-item = CheckListItem = one check list item component with a checkbox
- clipboard-copy-button = ClipboardCopyButton = a button that copies text to the clipboard
- collapsible = Collapsible = a container that can be expanded or collapsed
- color-input = ColorInput = an input for selecting a color value
- color-picker = ColorPicker = a two-dimensional board for picking colors by hue and saturation
- color-picker-button = ColorPickerButton = a button showing a color swatch in a color picker
- combobox = Combobox = a text input combined with a dropdown list for filtering options
- command = Command = a command palette for searching and executing actions
- contents-nav = ContentsNav = a navigation landmark for a table of contents
- contents-list = ContentsList = an ordered list of contents list item components
- contents-list-item = ContentsListItem = one contents list item component linking to a page section
- context-menu = ContextMenu = a menu that appears on right-click or long-press
- context-menu-item = ContextMenuItem = one item in a context menu
- data-filter-form = DataFilterForm = a form for filtering data by criteria
- data-table:
  - data-table = DataTable = a data table interactive grid for displaying and sorting tabular data
  - data-table-head = DataTableHead = a data table interactive grid thead
  - data-table-body = DataTableBody = a data table interactive grid tbody
  - data-table-foot = DataTableFoot = a data table interactive grid tfoot
  - data-table-col = DataTableCol = a data table interactive grid column
  - data-table-row = DataTableRow = a data table interactive grid row
  - data-table-data = DataTableData = a data table interactive grid data cell
- date-field = DateField = a structured field for entering date components
- date-input = DateInput = an input for entering a date value
- date-range = DateRange = a display of a start and end date range
- datetime-local-input = DatetimeLocalInput = an input for entering a date and time without time zone
- details = Details = a disclosure widget that shows and hides content
- dial = Dial = a rotary dial control for selecting a value
- dialog = Dialog = a modal or non-modal dialog window
- do-list = DoList = a guideline list of encouraged do-list-item components
- do-list-item = DoListItem = an encouraged-practice item in a do-list guideline list
- dont-list = DontList = a guideline list of discouraged dont-list-item components
- dont-list-item = DontListItem = a discouraged-practice item in a dont-list guideline list
- drawer = Drawer = a panel that slides in from the edge of the screen
- dropdown-menu = DropdownMenu = a menu that opens below a trigger button
- editable-form = EditableForm = a form wrapper for inline editing of content
- editable = Editable = an inline-editable text element that toggles between view and edit modes
- email-link = EmailLink = a mailto hyperlink for an email address
- email-input = EmailInput = an input for entering an email address
- emoji-character-picker = EmojiCharacterPicker = a picker for browsing and selecting emoji characters
- emoji = Emoji = a single emoji character with accessible name
- error-message = ErrorMessage = an error message associated with a form field
- error-summary = ErrorSummary = a summary of all validation errors on a form
- expander = Expander = a control that expands to reveal more content
- field = Field = a form field wrapper with label, input, and error message
- fieldset = Fieldset = a group of related form fields with a legend
- figure = Figure = a self-contained figure with optional caption
- file-dialog = FileDialog = a dialog for browsing and selecting files
- file-input = FileInput = an input for selecting files from the file system
- file-manager = FileManager = a file browser for navigating and managing files
- file-upload = FileUpload = a drag-and-drop area for uploading files
- five-face-rating:
  - five-face-rating-view = FiveFaceRatingView = a read-only display of a five-face satisfaction rating
  - five-face-rating-picker = FiveFaceRatingPicker = a picker for selecting a 1-5 satisfaction rating using face labels
  - five-face-rating-picker-button = FiveFaceRatingPickerButton = a picker button for selecting a 1-5 satisfaction rating using face labels
- five-star-rating:
  - five-star-rating-view = FiveStarRatingView = a read-only display of a five-star rating
  - five-star-rating-picker = FiveStarRatingPicker = a picker for selecting a 1-5 star rating using radio buttons
  - five-star-rating-picker-button = FiveStarRatingPickerButton = a picker button for selecting a 1-5 star rating using radio buttons
- flair = Flair = a decorative highlight or emphasis element
- floating-panel = FloatingPanel = a panel that floats above page content
- footer = Footer = a page or section footer area
- footnote = Footnote = a footnote reference and content element
- form = Form = a form element for collecting and submitting user data
- gantt-table:
  - gantt-table = GanttTable = a Gantt chart table interactive grid for planning schedule visualization
  - gantt-table-head = GanttTableHead = a Gantt chart table interactive grid thead
  - gantt-table-body = GanttTableBody = a Gantt chart table interactive grid tbody
  - gantt-table-foot = GanttTableFoot = a Gantt chart table interactive grid tfoot
  - gantt-table-col = GanttTableCol = a Gantt chart table interactive grid column
  - gantt-table-row = GanttTableRow = a Gantt chart table interactive grid row
  - gantt-table-data = GanttTableData = a Gantt chart table interactive grid data cell
- hamburger-menu = HamburgerMenu = a toggle button that opens a mobile navigation menu
- header = Header = a page or section header area
- hidden-input = HiddenInput = a hidden input for including data in form submission
- hint = Hint = hint text providing guidance for a form field
- holy-grail-layout = HolyGrailLayout = a classic layout with header, footer, main content, and two sidebars
- hover-card = HoverCard = a card that appears on hover over a trigger element
- icon = Icon = a container for displaying an icon
- image-file-input = ImageFileInput = an input for selecting image files with preview
- image = Image = an image element with alt text
- information-callout = InformationCallout = a callout box highlighting informational content
- input = Input = a generic HTML input element
- inset-text = InsetText = indented text to distinguish it from surrounding content
- kanban-table:
  - kanban-table = KanbanTable = a kanban board table interactive grid for organizing items by status
  - kanban-table-head = KanbanTableHead = a kanban board table interactive grid thead
  - kanban-table-body = KanbanTableBody = a kanban board table interactive grid tbody
  - kanban-table-foot = KanbanTableFoot = a kanban board table interactive grid tfoot
  - kanban-table-col = KanbanTableCol = a kanban board table interactive grid column
  - kanban-table-row = KanbanTableRow = a kanban board table interactive grid row
  - kanban-table-data = KanbanTableData = kanban board table interactive grid data cell
- label = Label = a label associated with a form input
- listbox = Listbox = a list of selectable options with keyboard navigation
- measurement:
  - measurement-instance-input = MeasurementInstanceInput = an input for entering a measurement value and unit
  - measurement-instance-view = MeasurementInstanceView = a read-only display of a measurement value and unit
  - measurement-system-input = MeasurementSystemInput = an input for selecting a measurement system
  - measurement-system-view = MeasurementSystemView = a read-only display of a measurement system
  - measurement-unit-input = MeasurementUnitInput = an input for selecting a measurement unit
  - measurement-unit-view = MeasurementUnitView = a read-only display of a measurement unit
- medical-record-red-box = MedicalRecordRedBox = a red highlighted box for critical medical record information
- menu = Menu = a list of actions or options triggered by a button
- menu-item = MenuItem = one item in a menu
- menu-bar = MenuBar = a horizontal bar of menu triggers
- menu-bar-button = MenuBarButton = one item in a menu bar
- meter = Meter = a gauge displaying a scalar value within a known range
- month-input = MonthInput = an input for selecting a month and year
- navigation-menu = NavigationMenu = a site-wide navigation menu with links
- net-promoter-score:
  - net-promoter-score-view = NetPromoterScoreView = a read-only display of a Net Promoter Score
  - net-promoter-score-picker = NetPromoterScorePicker = a picker for selecting a 0-10 Net Promoter Score
  - net-promoter-score-picker-button = NetPromoterScorePickerButton = a picker button for selecting a 0-10 Net Promoter Score
- notification = Notification = a brief message about an event or update
- number-input = NumberInput = an input for entering a numeric value with validation
- option = Option = an option element within a select dropdown
- pagination:
  - pagination-nav = PaginationNav = an ordered list of page navigation links
  - pagination-list = PaginationList = an ordered list of page navigation links
  - pagination-list-item = PaginationListItem = one page link in a pagination list
- panel = Panel = a generic content panel with optional heading
- password-input-or-text-input-div = PasswordInputOrTextInputDiv = an input for entering a password with obscured text
- pin-input-div = PinInputDiv = a series of single-digit inputs for entering a PIN or OTP code
- popover = Popover = a floating content box anchored to a trigger element
- popup = Popup = a temporary overlay that appears above page content
- postal-code:
  - postal-code-input = PostalCodeInput = an input for entering a postal or ZIP code
  - postal-code-view = PostalCodeView = a read-only display of a postal or ZIP code
- progress-circle = ProgressCircle = a circular progress indicator
- progress-spinner = ProgressSpinner = an indeterminate spinning progress indicator
- progress = Progress = a horizontal progress bar showing completion
- qr-code = QrCode = a QR code image generated from text or URL data
- radio-group = RadioGroup = a group of radio buttons for selecting one option
- radio-input = RadioInput = a single radio button input
- range-input = RangeInput = a slider input for selecting a value within a range
- red-amber-green:
  - red-amber-green-view = RedAmberGreenView = a read-only display of a red/amber/green status
  - red-amber-green-picker = RedAmberGreenPicker = a picker for selecting a red/amber/green status
  - red-amber-green-picker-button = RedAmberGreenPickerButton = a picker button for selecting a red/amber/green status
- red-orange-yellow-green-blue:
  - red-orange-yellow-green-blue-view = RedOrangeYellowGreenBlueView = a read-only display of a five-level color status
  - red-orange-yellow-green-blue-picker = RedOrangeYellowGreenBluePicker = a picker for selecting a five-level color status
  - red-orange-yellow-green-blue-picker-button = RedOrangeYellowGreenBluePickerButton = a picker button for selecting a five-level color status
- reset-input = ResetInput = a button input that resets a form to default values
- resizable = Resizable = a container that the user can resize by dragging
- review-date = ReviewDate = a display of a content review date
- scroll-area = ScrollArea = a scrollable container with custom scrollbar support
- scroll-bar = ScrollBar = a custom scrollbar element
- search-input = SearchInput = an input for entering a search query
- segment-group = SegmentGroup = a group of mutually exclusive segment options
- segment-group-item = SegmentGroupItem = one selectable segment in a segment group
- select-with-extras = SelectWithExtras = a select dropdown with additional features like search or groups
- select = Select = a dropdown select element for choosing one option
- separator = Separator = a horizontal or vertical divider between content sections
- sheet = Sheet = a panel that slides in from a screen edge as an overlay
- sidebar = Sidebar = a side panel for navigation or supplementary content
- signature-pad = SignaturePad = a drawing area for capturing a handwritten signature
- skeleton = Skeleton = a placeholder loading animation for content
- skip-link = SkipLink = a hidden link for keyboard users to skip to main content
- slide-out-drawer = SlideOutDrawer = a drawer that slides out from the side of the page
- slider = Slider = a draggable control for selecting a value along a track
- sonner = Sonner = a toast notification manager
- sparkline = Sparkline = a small inline chart showing a data trend
- splitter = Splitter = a draggable divider for resizing adjacent panels
- submit-input = SubmitInput = a button input that submits a form
- summary-list = SummaryList = an ordered list of key-value summary pairs
- summary-list-item = SummaryListItem = one key-value pair in a summary list
- switch-button = SwitchButton = a toggle switch for turning a setting on or off
- tab-bar = TabBar = a group of tabs for switching between content panels
- tab-bar-button = TabBarButton = one tab button in a tab group
- table = Table = a data table with rows and columns
- tag-group = TagGroup = a group of tag elements
- tag = Tag = a keyword label for categorizing content
- tag-input = TagInput = an input for adding and removing tags
- task-bar = TaskBar = a horizontal bar of task shortcuts or actions
- task-bar-button = TaskBarButton = one item in a task bar
- task-list = TaskList = an ordered list of task list items
- task-list-item = TaskListItem = one task item with a checkbox and label
- tel-input = TelInput = an input for entering a telephone number
- tel-link = TelLink = a tel: hyperlink for a telephone number
- text-input = TextInput = a single-line text input field
- textarea = Textarea = a multi-line text input area
- theme-picker = ThemePicker = a picker for selecting a visual theme
- theme-select = ThemeSelect = a select dropdown for choosing a theme
- theme-select-option = ThemeSelectOption = one option in a theme select dropdown
- theme-view = ThemeView = a read-only display of the current theme
- time-input = TimeInput = an input for entering a time value
- time-picker-input = TimePickerInput = an input with a dropdown for picking a time
- timeline-list = TimelineList = an ordered list of chronological events or milestones
- timeline-list-item = TimelineListItem = one event in a timeline list
- timer = Timer = a countdown or elapsed time display
- toast = Toast = a brief auto-dismissing notification message
- toggle-group = ToggleGroup = a group of toggle buttons for selecting options
- toggle-button = ToggleButton = a button that toggles between pressed and unpressed states
- tool-bar = ToolBar = a horizontal bar of tool actions
- tool-bar-button = ToolBarButton = one action button in a tool bar
- tooltip = Tooltip = a small popup showing descriptive text on hover or focus
- tour = Tour = a tour guide, such as for sightseeing, or pathways, or demonstrations, etc.
- tour-list = TourList = an ordered list of tour guide steps
- tour-list-item = TourListItem = one step in a tour guide list
- tree-nav = TreeNav = a hierarchical navigation with expandable branches
- tree-nav-list = TreeNavList = a hierarchical list with nested expandable items
- united-kingdom:
  - united-kingdom-national-health-service-number-input = UnitedKingdomNationalHealthServiceNumberInput = an input for entering a UK NHS number
  - united-kingdom-national-health-service-number-view = UnitedKingdomNationalHealthServiceNumberView = a read-only display of a UK NHS number
- united-states:
  - united-states-social-security-number-input = UnitedStatesSocialSecurityNumberInput = an input for entering a US Social Security number
  - united-states-social-security-number-view = UnitedStatesSocialSecurityNumberView = a read-only display of a US Social Security number
- url-input = UrlInput = an input for entering a URL
- warning-callout = WarningCallout = a callout box highlighting a warning message
- week-input = WeekInput = an input for selecting a week and year
