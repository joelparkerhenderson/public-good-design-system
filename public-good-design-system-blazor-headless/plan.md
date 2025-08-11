# Public Good Design System — Blazor Headless — Implementation Plan

## Goal

Implement all headless components using Blazor .NET 9 + C#. Every component must be headless (zero CSS), fully accessible (WCAG 2.2 AAA), and have comprehensive tests.

## Technology

- Framework: Blazor .NET 9 + C#
- Test framework: bUnit
- Test command: `dotnet test`
- Component file extension: .razor
- Component directory: Components/

## Approach

1. Set up project infrastructure (package.json, config, test setup)
2. Implement components in priority order:
   a. Static wrappers (badge, banner, card, panel, alert, etc.)
   b. Form inputs (text-input, email-input, checkbox-input, etc.)
   c. Links and views (action-link, postal-code-view, etc.)
   d. Vital sign views and inputs (15 pairs)
   e. Table families (table, data-table, calendar-table, etc.)
   f. Navigation patterns (accordion-nav, breadcrumb-nav, etc.)
   g. List patterns (check-list, summary-list, task-list, etc.)
   h. Bar patterns (tab-bar, menu-bar, tool-bar, etc.)
   i. Picker patterns (color-picker, five-star-rating-picker, etc.)
   j. Form composition (form, field, fieldset, error-summary)
   k. Overlays and menus (dialog, popover, tooltip, dropdown-menu)
   l. Layout (grail-layout, sidebar, floating-panel, scroll-area)
   m. Interactive specialty (combobox, carousel, slider, signature-pad)
3. Create tests for each component
4. Cross-check all components against canonical list in AGENTS.md

## Acceptance Criteria

- [ ] All components from the canonical list are implemented
- [ ] Each component file follows the architecture in AGENTS.md
- [ ] Every component has a corresponding test file
- [ ] All tests pass: `dotnet test`
- [ ] Zero CSS in any component — fully headless
- [ ] WCAG 2.2 AAA compliant (ARIA attributes, keyboard navigation)
- [ ] No hardcoded user-facing strings (internationalization-ready)
- [ ] CSS class names match css-style-sheet-template.css
