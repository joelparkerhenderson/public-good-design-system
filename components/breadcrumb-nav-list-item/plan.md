# Breadcrumb Nav List Item — Implementation Plan

## Goal

Implement the Breadcrumb Nav List Item component: one breadcrumb navigation link in the trail.

## HTML Tag and CSS Class

- HTML tag: <li>
- CSS class: .breadcrumb-nav-list-item

## Dependencies

- Requires parent: breadcrumb-nav-list

## Approach

1. Use semantic <li> element with class="breadcrumb-nav-list-item"
2. Add ARIA attributes for accessibility
3. Implement in HTML headless (plain HTML + vanilla JS)
4. Implement in Svelte headless (Svelte 5 + runes)
5. Implement in React, Vue, Blazor headless
6. Create tests for each implementation

## Acceptance Criteria

- [ ] Renders <li> with class="breadcrumb-nav-list-item"
- [ ] `aria-current="page"` -- set when `current` is true, indicating the user's current location in the breadcrumb trail
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless
- [ ] Tests pass in all implementations
