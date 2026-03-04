# Public Good Design System - Blazor Headless

## Project Overview

This is a Blazor Razor Class Library containing many headless UI components.

All components are unstyled (no CSS) and focus on semantic HTML, ARIA accessibility, and keyboard interaction.

Based on https://github.com/joelparkerhenderson/public-good-design-system

## Tech Stack

- .NET 10, Razor Class Library (RCL)
- bUnit 1.36.x + xUnit for testing
- No JavaScript frameworks, no CSS frameworks

## Project Layout

```
src/PublicGoodDesignSystemBlazorHeadless/
  Components/          # many components, flat directory
    {Name}.razor       # Markup only
    {Name}.razor.cs    # Code-behind (partial class)
tests/PublicGoodDesignSystemBlazorHeadless.Tests/
  Components/          # 236 test files
    {Name}Tests.cs     # bUnit tests
```

## Code Conventions

### Component pattern (code-behind)

Every component follows this structure in its `.razor.cs`:

```csharp
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;  // only if event handlers are used

namespace PublicGoodDesignSystemBlazorHeadless.Components;

public partial class ComponentName : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    // ... other parameters ...
    [Parameter] public RenderFragment ChildContent { get; set; }         // or RenderFragment? if optional
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "base-class" : $"base-class {CssClass}";
}
```

### Naming conventions

- Parameters: PascalCase (`Label`, `Disabled`, `OnClick`)
- CSS base class: kebab-case matching component name (`tab-bar`, `data-table`)
- Event handlers: `Handle{Event}` (`HandleClick`, `HandleKeyDown`)
- Element refs: `_elementRef` (private `ElementReference`)
- Bindable props: `{Name}` + `{Name}Changed` EventCallback pair

### Bindable (two-way binding) pattern

```csharp
[Parameter] public bool Open { get; set; }
[Parameter] public EventCallback<bool> OpenChanged { get; set; }
// Consumer uses: @bind-Open="myVar"
```

### Keyboard navigation pattern

Components needing DOM queries for focus management (TabBar, MenuBar, TreeNav, etc.) use:

```csharp
[Inject] private IJSRuntime JSRuntime { get; set; } = default!;
private ElementReference _elementRef;
```

### Headless rules

- No CSS classes beyond the base class name + consumer CssClass
- No inline styles
- No colors, sizes, spacing, or visual treatment
- Semantic HTML elements preferred over divs
- ARIA attributes for accessibility
- All user-facing text comes through parameters (i18n-ready)

## Build & Test Commands

```sh
dotnet build              # Build everything
dotnet test               # Run all 625 tests
dotnet build src/PublicGoodDesignSystemBlazorHeadless/  # Build library only
```

## Test pattern

```csharp
public class ButtonTests : TestContext
{
    [Fact]
    public void RendersAsButton()
    {
        var cut = RenderComponent<Button>(p => p
            .AddChildContent("Click me"));
        var element = cut.Find("button");
        Assert.NotNull(element);
    }
}
```

Every component has at minimum:

1. `RendersAs{Element}` — verifies the root HTML element
2. `HasBaseClass` — verifies the CSS base class
3. `RendersChildContent` — verifies child content rendering (when applicable)

## Svelte Source Reference

The original Svelte components are at:
`/Users/jph/git/joelparkerhenderson/public-good-design-system-plus-svelte/components/`

When modifying a component, cross-reference the `.svelte` source for the intended semantics, ARIA attributes, and keyboard behavior.

## Common Tasks

### Adding a new component

1. Create `Components/{Name}.razor` and `Components/{Name}.razor.cs`
2. Follow the code-behind pattern above
3. Create `tests/.../Components/{Name}Tests.cs`
4. Run `dotnet build && dotnet test`

### Modifying a component

1. Read the corresponding `.svelte` source for context
2. Edit the `.razor` and/or `.razor.cs` file
3. Update the test file if behavior changes
4. Run `dotnet test` to verify
