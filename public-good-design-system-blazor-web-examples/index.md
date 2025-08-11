# Public Good Design System - Blazor Web Examples

Blazor Web App (.NET 10) example application demonstrating headless components from the [Public Good Design System](https://github.com/joelparkerhenderson/public-good-design-system) Blazor headless component library, styled with [NHS UK design system](https://service-manual.nhs.uk/design-system) colors, typography, spacing, and focus states.

## Features

- Headless components imported from the Blazor headless library via ProjectReference
- 12 interactive example pages demonstrating realistic usage patterns
- NHS UK design system styling via CSS custom properties
- WCAG 2.2 AAA accessibility compliance
- Full keyboard navigation and screen reader support
- Internationalization-ready (no hardcoded strings)
- Interactive Server rendering with SignalR

## Quick Start

```bash
dotnet run --project src/PublicGoodDesignSystemBlazorWebExamples
```

Open [https://localhost:5001](https://localhost:5001).

## Commands

| Command | Description |
|---------|-------------|
| `dotnet build` | Build the project |
| `dotnet run --project src/PublicGoodDesignSystemBlazorWebExamples` | Start development server |
| `dotnet publish -c Release` | Publish for production |

## Project Structure

```
public-good-design-system-blazor-web-examples/
├── PublicGoodDesignSystemBlazorWebExamples.slnx
├── src/PublicGoodDesignSystemBlazorWebExamples/
│   ├── PublicGoodDesignSystemBlazorWebExamples.csproj
│   ├── Program.cs
│   ├── _Imports.razor
│   ├── Components/
│   │   ├── App.razor              # Root HTML document
│   │   ├── Routes.razor           # Router configuration
│   │   ├── Layout/
│   │   │   └── MainLayout.razor   # Shared layout with SkipLink
│   │   └── Pages/
│   │       ├── Home.razor                # Links to all examples
│   │       ├── ContactForm.razor         # Form validation
│   │       ├── Dashboard.razor           # Cards, progress, data table
│   │       ├── DialogFlow.razor          # Dialogs, drawers, tooltips
│   │       ├── FileUploadForm.razor      # File upload with progress
│   │       ├── NavigationAndMenus.razor  # Menus, toolbars, hamburger
│   │       ├── PageLayout.razor          # Header, footer, breadcrumbs
│   │       ├── RatingAndFeedback.razor   # Star/face/NPS ratings
│   │       ├── SearchAndFilter.razor     # Search, tags, data table
│   │       ├── SettingsPage.razor        # Switches, radios, selects
│   │       ├── TabbedInterface.razor     # Tabs, accordion, badges
│   │       ├── TaskManagement.razor      # Task list, progress
│   │       └── TimelineAndCards.razor    # Timeline, cards, summaries
│   └── wwwroot/
│       ├── css/nhs.css            # NHS UK design tokens & styles
│       └── js/headless-interop.js # Keyboard navigation helpers
```

## Example Pages

| Page | Route | Components Demonstrated |
|------|-------|------------------------|
| Contact Form | `/contact-form` | Form, Field, TextInput, EmailInput, Textarea, Select, Option, Button, ErrorSummary |
| Dashboard | `/dashboard` | Card, Progress, ProgressCircle, Badge, Banner, DataTable |
| Dialog Flow | `/dialog-flow` | Dialog, AlertDialog, Drawer, Tooltip, Button |
| File Upload | `/file-upload-form` | FileUpload, Progress, Button, Alert, Badge, Form, Field |
| Navigation | `/navigation-and-menus` | NavigationMenu, MenuBar, ToolBar, HamburgerMenu, DropdownMenu, Separator |
| Page Layout | `/page-layout` | Header, Footer, BreadcrumbNav, Sidebar, NavigationMenu |
| Rating | `/rating-and-feedback` | FiveStarRatingPicker, FiveStarRatingView, FiveFaceRatingPicker, NetPromoterScorePicker, Textarea |
| Search | `/search-and-filter` | Combobox, SearchInput, TextInput, TagGroup, Tag, DataTable, Badge |
| Settings | `/settings-page` | SwitchButton, RadioGroup, RadioInput, Select, Fieldset, Separator, Button, Banner |
| Tabs | `/tabbed-interface` | TabBar, TabBarButton, AccordionNav, AccordionNavList, AccordionNavListItem, Badge |
| Tasks | `/task-management` | TaskList, TaskListItem, TextInput, CheckboxInput, Button, Badge, Progress |
| Timeline | `/timeline-and-cards` | TimelineList, TimelineListItem, Card, DateRange, ReviewDate, SummaryList, SummaryListItem, Badge |

## Architecture

### Component Integration

Components are imported from the sibling headless library via ProjectReference:

```xml
<ProjectReference Include="../../../public-good-design-system-blazor-headless/..." />
```

Usage in Razor pages:

```razor
@using PublicGoodDesignSystemBlazorHeadless.Components

<Form Label="Contact" OnSubmit="HandleSubmit">
    <Field Label="Name" Required="true" Error="@GetError("name")">
        <TextInput Label="Name" Value="@name" ValueChanged="v => name = v" Required="true" />
    </Field>
    <Button Type="submit">Submit</Button>
</Form>
```

### NHS UK Styling

All visual styling comes from `wwwroot/css/nhs.css`, which provides:

- **Color tokens**: NHS Blues, Neutrals, Support Greens, Highlights as CSS custom properties
- **Typography**: Frutiger W01 font family with 8-point size scale
- **Spacing**: 10-point spacing scale (0-9)
- **Focus states**: Yellow outline (#ffeb3b) with black text for WCAG contrast
- **Component styles**: Component CSS classes with NHS-appropriate styling

Components are headless (unstyled) by default. Each component renders a semantic CSS class (e.g., `button`, `alert`, `badge`) that the NHS stylesheet targets.

### Blazor Patterns

| Pattern | Example |
|---------|---------|
| Two-way binding | `@bind-Value`, `@bind-Checked`, `@bind-Open` or manual `Value`/`ValueChanged` |
| Events | `OnSubmit` (Form), `@onclick` (Button) |
| Conditional rendering | `@if (condition) { <Component /> }` |
| Lists | `@foreach (var item in items) { <Component /> }` |
| Async state update | `await Task.Delay(ms); StateHasChanged();` |

## Tech Stack

- **.NET 10.0** with C#
- **Blazor Web App** with Interactive Server rendering
- **SignalR** for real-time UI updates

## Related Projects

- [Public Good Design System](https://github.com/joelparkerhenderson/public-good-design-system) - Parent project
- [Blazor Headless](../public-good-design-system-blazor-headless/) - Blazor headless components
- [React Next.js Examples](../public-good-design-system-react-next-examples/) - React equivalent
- [Svelte SvelteKit Examples](../public-good-design-system-svelte-sveltekit-examples/) - Svelte equivalent
- [Vue Nuxt Examples](../public-good-design-system-vue-nuxt-examples/) - Vue equivalent

## NHS UK Design System References

- [NHS UK Design System](https://service-manual.nhs.uk/design-system)
- [NHS Identity Colours](https://www.england.nhs.uk/nhsidentity/identity-guidelines/colours/)
- [NHS Accessibility](https://service-manual.nhs.uk/accessibility/design)

## License

MIT or Apache-2.0 or GPL-2.0 or GPL-3.0, or contact us for more options.

## Contact

Joel Parker Henderson (joel@joelparkerhenderson.com)
