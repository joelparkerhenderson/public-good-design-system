# Public Good Design System - Blazor Headless

This is a UI/UX headless component library for Blazor, providing many
accessible, unstyled UI components as a Razor Class Library.

Each component delivers semantic HTML, ARIA attributes, and keyboard
interactions — with zero CSS — so consumers have full control over visual
presentation.

Based on [Public Good Design System](https://github.com/joelparkerhenderson/public-good-design-system).

## Quick Start

### Add the package reference

```xml
<PackageReference Include="PublicGoodDesignSystemBlazorHeadless" />
```

### Use a component

```razor
@using PublicGoodDesignSystemBlazorHeadless.Components

<Button Type="submit" OnClick="HandleSubmit" CssClass="btn-primary">
    Save
</Button>

<Dialog Label="Confirm" @bind-Open="showDialog">
    <p>Are you sure?</p>
    <Button OnClick="() => showDialog = false">Cancel</Button>
</Dialog>
```

## Design Principles

- **Headless**: No CSS, no styles, no opinions on visual design. Consumer provides all styling.
- **Accessible**: Semantic HTML elements, ARIA roles/attributes, and keyboard navigation built in.
- **Composable**: Compound components (e.g., Avatar + AvatarImage + AvatarText) snap together.
- **Standard Blazor patterns**: `[Parameter]`, `EventCallback<T>`, `RenderFragment`, `@bind-*`, `AdditionalAttributes`.

## Project Structure

```
PublicGoodDesignSystemBlazorHeadless.sln
├── src/PublicGoodDesignSystemBlazorHeadless/
│   ├── PublicGoodDesignSystemBlazorHeadless.csproj   # Razor Class Library (.NET 10)
│   ├── _Imports.razor
│   └── Components/                                    # Many components (flat)
│       ├── Button.razor          # Markup
│       ├── Button.razor.cs       # Code-behind
│       ├── Dialog.razor
│       ├── Dialog.razor.cs
│       └── ...
├── tests/PublicGoodDesignSystemBlazorHeadless.Tests/
│   ├── PublicGoodDesignSystemBlazorHeadless.Tests.csproj  # bUnit + xUnit
│   └── Components/
│       ├── ButtonTests.cs
│       ├── DialogTests.cs
│       └── ...
```

## Component Patterns

### Simple component

```csharp
// Button.razor.cs
public partial class Button : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Type { get; set; } = "button";
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public EventCallback<MouseEventArgs> OnClick { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }
}
```

### Bindable component

```csharp
// Dialog.razor.cs — consumers use @bind-Open="showDialog"
[Parameter] public bool Open { get; set; }
[Parameter] public EventCallback<bool> OpenChanged { get; set; }
```

### Keyboard navigation component

Components like TabBar, MenuBar, and TreeNav use `IJSRuntime` to manage focus across child elements with arrow keys, Home, and End.

## All Components (236)

### Navigation

AccordionNav, AccordionNavList, AccordionNavListItem, ActionLink, BackLink, BreadcrumbNav, BreadcrumbNavList, BreadcrumbNavListItem, ContentsNav, ContentsList, ContentsListItem, NavigationMenu, PaginationNav, PaginationList, PaginationListItem, SkipLink, TabBar, TabBarButton, TabGroup, TaskBar, TaskBarButton, TreeNav, TreeNavList

### Layout

AspectRatioContainer, Card, FloatingPanel, HolyGrailLayout, Panel, Resizable, ScrollArea, ScrollBar, Separator, Sidebar, Splitter

### Forms & Inputs

ButtonInput, CheckboxInput, ColorInput, Combobox, DateField, DateInput, DateRange, DatetimeLocalInput, EmailInput, Field, Fieldset, FileInput, Form, HiddenInput, ImageFileInput, Input, Listbox, MeasurementInstanceInput, MeasurementSystemInput, MeasurementUnitInput, MonthInput, NumberInput, Option, PasswordInputDiv, PinInputDiv, PostalCodeInput, RadioGroup, RadioInput, RangeInput, ResetInput, SearchInput, Select, SelectWithExtras, SubmitInput, TagInput, TelInput, Textarea, TextInput, TimeInput, TimePickerInput, UrlInput, WeekInput

### Buttons & Toggles

Button, ClipboardCopyButton, ToggleButton, ToggleGroup, SwitchButton

### Feedback & Status

Alert, AlertDialog, Badge, Banner, ErrorMessage, ErrorSummary, Hint, InformationCallout, Notification, Progress, ProgressCircle, ProgressSpinner, Skeleton, Toast, WarningCallout

### Overlays & Popups

ContextMenu, ContextMenuItem, Dialog, Drawer, DropdownMenu, FileDialog, HoverCard, Popover, Popup, Sheet, SlideOutDrawer, Tooltip

### Data Display

CalendarRangePicker, CalendarTable, CalendarTableBody, CalendarTableCol, CalendarTableData, CalendarTableFoot, CalendarTableHead, CalendarTableRow, DataFilterForm, DataTable, DataTableBody, DataTableCol, DataTableData, DataTableFoot, DataTableHead, DataTableRow, GanttTable, GanttTableBody, GanttTableCol, GanttTableData, GanttTableFoot, GanttTableHead, GanttTableRow, KanbanTable, KanbanTableBody, KanbanTableCol, KanbanTableData, KanbanTableFoot, KanbanTableHead, KanbanTableRow, SummaryList, SummaryListItem, Table

### Ratings & Pickers

AngleSliderRangeInput, ColorPicker, ColorPickerButton, Dial, EmojiCharacterPicker, FiveFaceRatingPicker, FiveFaceRatingPickerButton, FiveFaceRatingView, FiveStarRatingPicker, FiveStarRatingPickerButton, FiveStarRatingView, NetPromoterScorePicker, NetPromoterScorePickerButton, NetPromoterScoreView, RedAmberGreenPicker, RedAmberGreenPickerButton, RedAmberGreenView, RedOrangeYellowGreenBluePicker, RedOrangeYellowGreenBluePickerButton, RedOrangeYellowGreenBlueView, Slider, ThemePicker, ThemeSelect, ThemeSelectOption, ThemeView

### Content & Typography

CallToAction, Caption, CareCard, Carousel, Character, CharacterCounter, CheckList, CheckListItem, Collapsible, Command, Details, DoList, DoListItem, DontList, DontListItem, Editable, EditableForm, EmailLink, Emoji, Expander, Figure, Flair, Footnote, Image, InsetText, Label, MedicalRecordRedBox, Meter, PostalCodeView, QrCode, ReviewDate, Sonner, Sparkline, Tag, TagGroup, TelLink, TimelineList, TimelineListItem, Timer, Tour, TourList, TourListItem, UnitedKingdomNationalHealthServiceNumberInput, UnitedKingdomNationalHealthServiceNumberView, UnitedStatesSocialSecurityNumberInput, UnitedStatesSocialSecurityNumberView, MeasurementInstanceView, MeasurementSystemView, MeasurementUnitView

### Structure

Avatar, AvatarImage, AvatarText, BeachBall, Footer, HamburgerMenu, Header, Icon, Menu, MenuBar, MenuBarButton, MenuItem, SegmentGroup, SegmentGroupItem, SignaturePad, ToolBar, ToolBarButton, FileManager, FileUpload

## Building

```sh
dotnet build
```

## Testing

```sh
dotnet test
```

Test files with tests covering element rendering, CSS base classes, and child content.

## License

See LICENSE file.
