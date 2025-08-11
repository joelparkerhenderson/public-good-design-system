# NHS UK to Public Good Design System Conversion Plan

## Project Overview

This project involves converting the NHS UK Design System from Nunjucks templates with SCSS to a modern TypeScript-based "Public Good Design System" using vanilla HTML, CSS, and TypeScript.

## Key Findings from Analysis

### Source Repository Structure
- **Main Repository**: `nhsuk-frontend` (verified to exist)
- **Components Location**: `/packages/nhsuk-frontend/src/nhsuk/components/`
- **Technology Stack**: Nunjucks (18.1%), SCSS (20.6%), JavaScript (61.1%)
- **Build System**: Gulp, Node.js, workspaces architecture
- **Testing**: Jest (unit), Puppeteer (e2e), Playwright (visual)

### Component Inventory (35 Total Components)
Based on directory analysis, the following components exist in alphabetical order:

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

### Component Structure Pattern
Each NHS UK component follows a consistent structure:
- `README.md` - Component documentation
- `_[component-name].scss` - Main styles
- `_index.scss` - Style imports
- `macro.njk` - Nunjucks macro definition
- `template.njk` - Nunjucks template
- `macro-options.mjs` - Configuration options
- `accessibility.puppeteer.test.mjs` - Accessibility tests
- `[component-name].jsdom.test.mjs` - Unit tests (where applicable)
- `[component-name].mjs` - JavaScript functionality (where applicable)
- `[component-name].puppeteer.test.mjs` - E2E tests (where applicable)

### Design System Categories (from NHS documentation)
1. **Form Elements**: Buttons, Character count, Checkboxes, Date input, Error message, Error summary, Fieldset, Hint text, Radios, Select, Text input, Textarea
2. **Content Presentation**: Care cards, Details, Do and Don't lists, Expander, Images, Inset text, Panel, Review date, Summary list, Table, Tabs, Tag, Task list, Warning callout
3. **Navigation**: Action link, Back link, Breadcrumbs, Card, Contents list, Footer, Header, Pagination, Skip link

## Conversion Strategy

### Technology Migration Plan

#### From NHS UK Stack:
- **Templating**: Nunjucks → Vanilla HTML
- **Styling**: SCSS → Vanilla CSS
- **JavaScript**: ES modules → TypeScript
- **Build**: Gulp → Vite
- **Package Manager**: NPM → PNPM
- **Testing**: Jest + Puppeteer → Vitest + Playwright

#### Target Stack:
- **HTML**: Semantic, accessible vanilla HTML5
- **CSS**: Modern CSS with custom properties, no preprocessors
- **TypeScript**: Functional programming patterns, proper type definitions
- **Build**: Vite for fast development and building
- **Testing**: Vitest (unit) + Playwright (e2e)
- **Package Manager**: PNPM for faster, more efficient dependency management

### Project Structure Design

```
public-good-design-system-with-html-css-typescript/
├── package.json
├── pnpm-lock.yaml
├── vite.config.ts
├── tsconfig.json
├── vitest.config.ts
├── playwright.config.ts
├── src/
│   ├── components/
│   │   ├── action-link/
│   │   │   ├── README.md
│   │   │   ├── action-link.html
│   │   │   ├── action-link.css
│   │   │   ├── action-link.ts
│   │   │   ├── action-link.test.ts
│   │   │   ├── action-link.e2e.ts
│   │   │   └── examples/
│   │   │       └── basic.html
│   │   └── [... all other components]
│   ├── core/
│   │   ├── tokens/
│   │   │   ├── colors.css
│   │   │   ├── typography.css
│   │   │   ├── spacing.css
│   │   │   └── breakpoints.css
│   │   ├── utilities/
│   │   │   ├── reset.css
│   │   │   ├── layout.css
│   │   │   └── accessibility.css
│   │   └── functions/
│   │       ├── dom-utils.ts
│   │       ├── validation.ts
│   │       └── i18n.ts
│   ├── assets/
│   │   ├── icons/
│   │   └── images/
│   └── locales/
│       ├── en.json
│       └── [other languages]
├── dist/
├── examples/
├── docs/
└── tests/
    ├── fixtures/
    └── helpers/
```

### Branding Migration Strategy

**Systematic renaming approach:**
- `NHS UK` → `Public Good`
- `nhsuk` → `public-good`
- `nhsuk-` prefix → `public-good-` prefix
- Color schemes and branding elements updated to generic public good theme

### Component Conversion Methodology

#### Phase 1: Analysis (Pre-conversion)
For each component:
1. Read and understand NHS UK component documentation
2. Analyze Nunjucks template structure and data requirements
3. Extract SCSS styles and understand styling patterns
4. Identify JavaScript functionality and interactions
5. Review accessibility requirements and ARIA patterns
6. Document component API and configuration options

#### Phase 2: Implementation
For each component:
1. Create semantic HTML structure based on Nunjucks template
2. Convert SCSS to modern CSS with custom properties
3. Implement TypeScript functionality following functional patterns
4. Create comprehensive README with usage examples
5. Develop Vitest unit tests
6. Create Playwright e2e tests
7. Build interactive examples

#### Phase 3: Integration
1. Ensure consistent design token usage across components
2. Implement proper TypeScript type exports
3. Create comprehensive build pipeline
4. Validate accessibility compliance
5. Performance optimization
6. Cross-browser testing

### Key Technical Considerations

#### CSS Architecture
- Use CSS Custom Properties for design tokens
- Implement BEM-like naming convention: `.public-good-[component]__[element]--[modifier]`
- Mobile-first responsive design
- CSS Grid and Flexbox for layouts
- CSS Logical Properties for international support

#### TypeScript Patterns
- Functional programming approach (no classes)
- Comprehensive type definitions for component props
- JSDoc documentation for all public APIs
- Proper error handling and validation
- Service Worker support for offline functionality

#### Accessibility Standards
- WCAG 2.1 AA compliance
- Proper ARIA labeling and roles
- Keyboard navigation support
- Screen reader compatibility
- High contrast support
- Focus management

#### Internationalization
- RTL language support
- Locale-specific formatting
- Translation-ready string externalization
- Cultural adaptation considerations

#### Testing Strategy
- Unit tests for all component logic
- Integration tests for component interactions
- Accessibility testing with axe-core
- Visual regression testing
- Cross-browser compatibility testing
- Performance benchmarking

### Build and Development Pipeline

#### Development Environment
- Vite dev server with HMR
- TypeScript type checking
- ESLint + Prettier for code quality
- CSS validation and autoprefixing
- Asset optimization

#### Build Process
- Tree-shaking for optimal bundle sizes
- CSS minification and optimization
- TypeScript compilation with proper declarations
- Asset pipeline for icons and images
- Source map generation

#### Quality Assurance
- Automated testing pipeline
- Code coverage reporting
- Performance monitoring
- Accessibility auditing
- Security scanning

### Risk Mitigation Strategies

#### Technical Risks
1. **CSS Conversion Complexity**: Some SCSS mixins may require manual CSS equivalents
2. **JavaScript Functionality**: Complex interactions need careful TypeScript reimplementation
3. **Accessibility Compliance**: Must maintain all existing accessibility features
4. **Browser Compatibility**: Ensure modern CSS features have appropriate fallbacks

#### Mitigation Approaches
1. Create CSS utility functions for complex calculations
2. Implement comprehensive test coverage for all functionality
3. Use automated accessibility testing tools
4. Define clear browser support matrix and use appropriate polyfills

### Success Metrics

#### Functional Requirements
- [ ] All 35 components successfully converted
- [ ] 100% accessibility compliance maintained
- [ ] All interactive functionality preserved
- [ ] Cross-browser compatibility achieved

#### Quality Metrics
- [ ] 95%+ test coverage for all components
- [ ] <100ms initial load time for core styles
- [ ] <50kb gzipped bundle size for complete library
- [ ] Zero accessibility violations in automated testing

#### Developer Experience
- [ ] Comprehensive documentation for all components
- [ ] Interactive examples for each component
- [ ] Clear TypeScript types for all APIs
- [ ] Easy installation and integration process

## Next Steps

1. Set up project infrastructure with Vite, PNPM, TypeScript
2. Create core design system foundation (tokens, utilities)
3. Begin component conversion in strict alphabetical order
4. Implement comprehensive testing for each component
5. Create documentation and examples
6. Performance optimization and final validation

This plan provides a comprehensive roadmap for converting the NHS UK Design System to a modern, TypeScript-based Public Good Design System while maintaining all functionality, accessibility, and usability requirements.