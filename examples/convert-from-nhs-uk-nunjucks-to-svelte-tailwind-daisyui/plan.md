# NHS UK to Public Good Design System Conversion Plan

## Project Overview

This project involves converting the NHS UK Design System from Nunjucks templates to a Public Good Design System using Svelte 5, SvelteKit, Tailwind CSS, and DaisyUI.

## Key Findings from Analysis

### NHS UK Design System Structure
- **Source Location**: `./nhsuk-frontend/packages/nhsuk-frontend/src/nhsuk/components/`
- **Component Count**: 33 components identified
- **Template Engine**: Nunjucks (.njk files)
- **Styling**: SCSS with global stylesheets
- **Architecture**: Monolithic component structure with separate SCSS, Nunjucks templates, and JavaScript files

### Component Analysis
The NHS UK Design System contains the following components (alphabetical order):
1. action-link
2. back-link
3. breadcrumb
4. button
5. card
6. character-count
7. checkboxes
8. contents-list
9. date-input
10. details
11. do-dont-list
12. error-message
13. error-summary
14. fieldset
15. footer
16. header
17. hero
18. hint
19. images
20. input
21. inset-text
22. label
23. notification-banner
24. pagination
25. panel
26. radios
27. select
28. skip-link
29. summary-list
30. tables
31. tabs
32. tag
33. task-list
34. textarea
35. warning-callout

### Technical Architecture Differences

#### NHS UK (Current):
- **Templates**: Nunjucks macros with conditional logic
- **Styling**: Global SCSS files with BEM methodology
- **JavaScript**: Vanilla JavaScript modules with feature detection
- **Theming**: CSS custom properties with NHS branding
- **Testing**: Jest + Puppeteer for accessibility and visual regression

#### Public Good (Target):
- **Templates**: Svelte 5 components with reactivity
- **Styling**: Tailwind CSS + DaisyUI utility-first approach
- **JavaScript**: TypeScript with Svelte's reactive system
- **Theming**: DaisyUI themes with Public Good branding
- **Testing**: Playwright for e2e and component testing

## Implementation Strategy

### Phase 1: Foundation Setup
1. **SvelteKit Project Creation**
   - Use minimal template with TypeScript
   - Configure build system and development environment

2. **Styling Integration**
   - Install and configure Tailwind CSS
   - Install and configure DaisyUI
   - Create custom theme for Public Good branding

3. **Testing Framework**
   - Set up Playwright for component and integration testing
   - Configure test runners and CI/CD compatibility

### Phase 2: Component Architecture Design

#### File Structure per Component:
```
src/lib/components/[component-name]/
├── README.md           # Component documentation
├── [ComponentName].svelte  # Main component file
├── +example.svelte     # Example usage
├── types.ts            # TypeScript interfaces
├── config.ts           # Component configuration
└── [ComponentName].test.ts # Playwright tests
```

#### Component Conversion Methodology:
1. **Template Analysis**: Extract HTML structure from Nunjucks
2. **Props Mapping**: Convert Nunjucks parameters to Svelte props
3. **Style Migration**: Convert SCSS to Tailwind CSS classes with DaisyUI components
4. **Interaction Logic**: Port vanilla JavaScript to Svelte reactive statements
5. **Accessibility**: Maintain ARIA attributes and keyboard navigation
6. **Testing**: Convert Puppeteer tests to Playwright

### Phase 3: Branding Transformation

#### NHS UK → Public Good Mapping:
- **Prefix**: `nhsuk-` → `public-good-`
- **Brand Name**: "NHS UK" → "Public Good"
- **Colors**: NHS blue/white → Public Good color scheme
- **Typography**: NHS fonts → Public Good typography
- **Logo**: NHS logo → Public Good logo

### Phase 4: Component Conversion Order
Components will be converted alphabetically to ensure systematic coverage:

1. **action-link** - Simple link component with icon
2. **back-link** - Navigation component 
3. **breadcrumb** - Navigation breadcrumb trail
4. **button** - Primary interaction component (multiple variants)
5. **card** - Content container component
6. **character-count** - Form input enhancement
7. **checkboxes** - Form input component
8. **contents-list** - Table of contents navigation
9. **date-input** - Specialized form input
10. **details** - Collapsible content component
11. **do-dont-list** - Content guidance component
12. **error-message** - Form validation component
13. **error-summary** - Page-level error display
14. **fieldset** - Form grouping component
15. **footer** - Page footer layout
16. **header** - Page header with navigation
17. **hero** - Landing page banner
18. **hint** - Form field guidance
19. **images** - Image display component
20. **input** - Text input form field
21. **inset-text** - Highlighted text content
22. **label** - Form field labels
23. **notification-banner** - Alert/notification display
24. **pagination** - Content navigation
25. **panel** - Content container variant
26. **radios** - Radio button form input
27. **select** - Dropdown form input
28. **skip-link** - Accessibility navigation
29. **summary-list** - Key-value pair display
30. **tables** - Data table component
31. **tabs** - Tabbed content interface
32. **tag** - Label/category indicator
33. **task-list** - Step-by-step guidance
34. **textarea** - Multi-line text input
35. **warning-callout** - Important alert component

## Technical Considerations

### Svelte 5 Migration Strategy
- Use `$state` runes for reactive variables
- Use `$derived` runes for computed values  
- Use `$effect` runes for side effects
- Leverage Svelte's built-in accessibility features

### Tailwind CSS + DaisyUI Integration
- Map NHS UK color palette to DaisyUI theme system
- Use DaisyUI components as base layer, customize with Tailwind utilities
- Implement responsive design patterns
- Ensure accessibility compliance (contrast ratios, focus states)

### TypeScript Integration
- Define comprehensive prop interfaces for each component
- Create shared types for common patterns (colors, sizes, variants)
- Implement strict type checking for API consistency

### Testing Strategy
- **Unit Tests**: Component prop validation, rendering logic
- **Integration Tests**: Component interaction, form submission
- **Accessibility Tests**: Screen reader compatibility, keyboard navigation
- **Visual Regression**: Screenshot comparison for UI consistency

### Deployment Configuration
- Use `@sveltejs/adapter-static` for static site generation
- Configure build process for component documentation site
- Set up automated deployment pipeline

## File Dependencies Verified

### Required Files Present:
- ✅ `./nhsuk-frontend/` - NHS UK source components
- ✅ `./svelte-documentation-llms-small.txt` - Svelte 5 reference
- ✅ `./daisyui-documentation-llms.txt` - DaisyUI component reference  
- ✅ `./claude_desktop_config.json` - MCP server configuration

### Target Directory:
- ✅ `./public-good-design-system-with-svelte/` - Output directory confirmed

## Success Criteria

### Technical Requirements:
1. All 35 NHS UK components successfully converted to Svelte 5
2. Full TypeScript type safety implementation
3. 100% Tailwind CSS + DaisyUI styling (no custom SCSS)
4. Comprehensive Playwright test coverage
5. Static documentation site with all component examples
6. Accessibility compliance maintained from original design system

### Quality Standards:
- Component API consistency across all converted components  
- Responsive design support for all screen sizes
- Cross-browser compatibility (modern browsers)
- Performance optimization (tree-shaking, code splitting)
- Documentation completeness for each component

This plan provides a comprehensive roadmap for converting the NHS UK Design System to a modern Svelte-based Public Good Design System while maintaining functionality, accessibility, and design quality.