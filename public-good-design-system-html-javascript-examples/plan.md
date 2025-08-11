# Public Good Design System — HTML JavaScript Examples — Implementation Plan

## Goal

Create styled example pages demonstrating component usage with Plain HTML + vanilla JavaScript with NHS UK styling. Examples use NHS UK design system CSS for visual styling on top of headless components.

## Technology

- Framework: Plain HTML + vanilla JavaScript with NHS UK styling
- Test framework: WebDriverIO
- Test command: `npx wdio run wdio.conf.js`
- Component directory: pages/

## Approach

1. Set up project infrastructure and NHS UK CSS integration
2. Create example pages demonstrating component families:
   a. Form page (text-input, email-input, select, checkbox, radio, etc.)
   b. Navigation page (breadcrumb, pagination, accordion, tree)
   c. Table page (data-table, calendar-table)
   d. Dialog and overlay page (dialog, popover, tooltip, toast)
   e. Layout page (grail-layout, sidebar, card)
   f. Medical/vital signs page
   g. Rating and picker page
   h. Additional showcase pages as needed
3. Import headless components from the corresponding headless library
4. Apply NHS UK CSS classes for styling
5. Create tests for each example page

## Acceptance Criteria

- [ ] Example pages demonstrate all major component families
- [ ] NHS UK CSS styling applied correctly
- [ ] Headless components imported from the headless library
- [ ] All pages are accessible (WCAG 2.2 AAA)
- [ ] All tests pass: `npx wdio run wdio.conf.js`
- [ ] Responsive layout works on mobile and desktop
