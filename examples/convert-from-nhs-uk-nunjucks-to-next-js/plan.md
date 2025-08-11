# NHS UK to Public Good Design System Conversion Plan

## Project Overview

This document outlines the comprehensive plan for converting the NHS UK Design System from Nunjucks-based templates to a modern Next.js-based Public Good Design System using TypeScript, styled-components, and React best practices.

## Key Findings from Analysis

### NHS UK Frontend Structure
- **Monorepo Structure**: Uses npm workspaces with packages for frontend and review apps
- **Component Architecture**: 35 components identified in alphabetical order:
  - action-link, back-link, breadcrumb, button, card, character-count, checkboxes, contents-list, date-input, details, do-dont-list, error-message, error-summary, fieldset, footer, header, hero, hint, images, input, inset-text, label, notification-banner, pagination, panel, radios, select, skip-link, summary-list, tables, tabs, tag, task-list, textarea, warning-callout

### Component Structure Pattern (per NHS UK component)
- **README.md**: Documentation and usage guidance
- **template.njk**: Nunjucks template with conditional logic
- **macro.njk**: Macro wrapper for template
- **macro-options.mjs**: TypeScript definitions for props and examples
- **_component.scss**: Sass styles following BEM methodology
- **_index.scss**: Style imports
- **component.mjs**: JavaScript functionality (when needed)
- **Tests**: Accessibility (Puppeteer), unit (Jest), and integration tests

### Design System Foundation
- **Color Palette**: NHS blue (#005eb8), white, black, green, purple, red, yellow, plus secondary colors and 5-level greyscale
- **Typography**: Custom NHS font stack with responsive scaling
- **Spacing**: Consistent spacing scale using mixins
- **Breakpoints**: Mobile-first responsive design
- **Accessibility**: WCAG AA compliance built-in

## Technical Implementation Strategy

### 1. Project Structure
```
public-good-design-system-with-next-js/
├── src/
│   ├── components/           # React components (alphabetical)
│   ├── styles/              # Global styles and design tokens
│   ├── utils/               # Utility functions
│   ├── hooks/               # Custom React hooks
│   ├── types/               # TypeScript type definitions
│   └── locales/             # Internationalization files
├── tests/
│   ├── components/          # Component tests
│   ├── e2e/                # Playwright tests
│   └── utils/              # Test utilities
├── docs/                   # Documentation
├── examples/               # Usage examples
└── dist/                   # Build output
```

### 2. Component Conversion Methodology

#### Template Migration (Nunjucks → React/TypeScript)
- Convert Nunjucks conditionals to React conditional rendering
- Transform macro parameters to TypeScript interfaces
- Replace Nunjucks loops with JavaScript map functions
- Convert HTML attributes handling to React props

#### Style Migration (SCSS → styled-components)
- Convert BEM class structure to styled-components
- Transform SCSS variables to design tokens
- Migrate mixins to JavaScript functions
- Preserve responsive design patterns

#### Example Conversion Pattern:
**NHS UK Button (Nunjucks)**:
```nunjucks
{% if element == 'a' %}
<a class="nhsuk-button{{ ' ' + params.classes if params.classes }}"
   href="{{ params.href }}">{{ params.text }}</a>
{% endif %}
```

**Public Good Button (React/TypeScript)**:
```typescript
interface ButtonProps {
  element?: 'button' | 'a' | 'input';
  href?: string;
  text: string;
  classes?: string;
}

const StyledButton = styled.button`
  /* styled-components CSS */
`;

export const Button: React.FC<ButtonProps> = ({ element = 'button', href, text, ...props }) => {
  if (element === 'a') {
    return <StyledButton as="a" href={href} {...props}>{text}</StyledButton>;
  }
  return <StyledButton {...props}>{text}</StyledButton>;
};
```

### 3. Design System Foundation

#### Color System Migration
```typescript
// From NHS UK SCSS variables
$color_nhsuk-blue: #005eb8;

// To Public Good design tokens
export const colors = {
  primary: '#005eb8',    // Renamed from nhsuk-blue
  white: '#ffffff',
  black: '#212b32',
  // ... rest of palette
} as const;
```

#### Typography System
- Convert NHS font stack to modern web fonts
- Implement responsive typography scale
- Create TypeScript interfaces for text styles

#### Spacing and Layout
- Convert SCSS spacing mixins to JavaScript functions
- Implement CSS Grid and Flexbox utilities
- Create responsive breakpoint system

### 4. Testing Strategy

#### Unit Testing (Vitest)
- Component rendering tests
- Props validation
- Accessibility compliance
- Interaction testing

#### Integration Testing (Playwright)
- Cross-browser compatibility
- Keyboard navigation
- Screen reader support
- Performance metrics

#### Visual Regression Testing
- Component appearance consistency
- Responsive design validation
- Cross-browser visual parity

### 5. Internationalization Implementation

#### Multi-language Support
- English (primary)
- Welsh
- Arabic (RTL support)
- Chinese
- Spanish

#### Technical Implementation
- Next.js i18n integration
- React-intl for component text
- RTL layout support
- Regional format handling

### 6. Accessibility Standards

#### WCAG AA Compliance
- Semantic HTML structure
- ARIA labels and descriptions
- Keyboard navigation support
- Screen reader compatibility
- Color contrast validation
- Focus management

### 7. Security Implementation

#### Content Security Policy (CSP)
- Strict CSP headers
- Nonce-based script execution
- Inline style prevention

#### Data Protection
- Secure prop handling
- XSS prevention
- Input sanitization
- CSRF protection

## Component Conversion Priority (Alphabetical Order)

1. **action-link** - Simple link component with chevron icon
2. **back-link** - Navigation component with back arrow
3. **breadcrumb** - Hierarchical navigation component
4. **button** - Primary interactive element (multiple variants)
5. **card** - Content container (clickable, feature, urgent variants)
6. **character-count** - Form input with character/word counting
7. **checkboxes** - Form selection component with conditional reveals
8. **contents-list** - Page navigation component
9. **date-input** - Three-field date input component
10. **details** - Expandable content component
11. **do-dont-list** - Instructional list component
12. **error-message** - Form validation message
13. **error-summary** - Page-level error collection
14. **fieldset** - Form grouping component
15. **footer** - Site footer with navigation
16. **header** - Site header with search and navigation
17. **hero** - Large promotional banner
18. **hint** - Form help text component
19. **images** - Responsive image component
20. **input** - Text input field
21. **inset-text** - Highlighted content block
22. **label** - Form label component
23. **notification-banner** - Alert/notification component
24. **pagination** - Multi-page navigation
25. **panel** - Confirmation/status panel
26. **radios** - Form selection component (single choice)
27. **select** - Dropdown selection component
28. **skip-link** - Accessibility navigation aid
29. **summary-list** - Key-value pair display
30. **tables** - Data table component
31. **tabs** - Content organization component
32. **tag** - Status/category indicator
33. **task-list** - Process step indicator
34. **textarea** - Multi-line text input
35. **warning-callout** - Important notice component

## Build and Development Tools

### Next.js Configuration
- TypeScript support
- Styled-components SSR
- Static generation for component library
- Development server with hot reload

### Testing Infrastructure
- Vitest for unit testing
- Playwright for E2E testing
- Jest-axe for accessibility testing
- Testing Library for component testing

### Build Pipeline
- TypeScript compilation
- Style extraction and optimization
- Bundle optimization
- Component documentation generation

### Development Workflow
- ESLint + Prettier for code standards
- Husky for git hooks
- Conventional commits
- Automated testing on CI/CD

## Package Structure

### Publishable NPM Package
```json
{
  "name": "@public-good/design-system",
  "main": "dist/index.js",
  "module": "dist/index.esm.js",
  "types": "dist/index.d.ts",
  "exports": {
    ".": {
      "import": "./dist/index.esm.js",
      "require": "./dist/index.js",
      "types": "./dist/index.d.ts"
    },
    "./styles": "./dist/styles.css"
  }
}
```

### Component Exports
- Individual component exports
- Grouped exports by category
- Style exports
- Utility function exports
- Type definition exports

## Implementation Phases

### Phase 1: Foundation (Project Setup)
- Next.js project initialization
- TypeScript configuration
- Styled-components setup
- Testing infrastructure
- Build pipeline configuration

### Phase 2: Design System Core
- Color palette migration
- Typography system
- Spacing and layout utilities
- Icon system
- Responsive breakpoints

### Phase 3: Component Migration (Alphabetical)
- Convert all 35 components
- Create comprehensive tests for each
- Generate documentation
- Implement examples

### Phase 4: Advanced Features
- Internationalization implementation
- Advanced accessibility features
- Performance optimization
- Security hardening

### Phase 5: Documentation and Deployment
- Comprehensive documentation site
- Storybook integration
- Vercel deployment configuration
- NPM package publishing

## Quality Assurance

### Code Quality
- TypeScript strict mode
- ESLint configuration
- Prettier formatting
- Conventional commits

### Testing Coverage
- 100% component test coverage
- Cross-browser compatibility
- Accessibility compliance
- Performance benchmarks

### Documentation Standards
- Comprehensive README for each component
- Usage examples
- Props documentation
- Accessibility notes
- Migration guides

## Risk Mitigation

### Technical Risks
- Component functionality parity verification
- Style consistency validation
- Performance impact assessment
- Browser compatibility testing

### Process Risks
- Incremental development approach
- Regular testing and validation
- Continuous integration
- Rollback strategies

## Success Metrics

### Functional Success
- All 35 components successfully converted
- 100% test coverage maintained
- WCAG AA compliance verified
- Cross-browser compatibility confirmed

### Performance Success
- Bundle size optimization
- Runtime performance parity
- Accessibility score maintenance
- SEO optimization

### Adoption Success
- Comprehensive documentation
- Clear migration path
- Developer experience optimization
- Community feedback integration

This plan provides the foundation for a systematic, thorough conversion of the NHS UK Design System to a modern, accessible, and maintainable Public Good Design System using Next.js and React best practices.