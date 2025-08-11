# Vital Sign Weight As Kg View — Implementation Plan

## Goal

Implement the Vital Sign Weight As Kg View component: number display of one vital sign weight in kilograms with integers.

## HTML Tag and CSS Class

- HTML tag: <div>
- CSS class: .vital-sign-weight-as-kg-view

## Companion Component

- vital-sign-weight-as-kg-input (Input/View or Input/Link pair)

## Approach

1. Use semantic <div> element with class="vital-sign-weight-as-kg-view"
2. Add ARIA attributes for accessibility
3. Implement in HTML headless (plain HTML + vanilla JS)
4. Implement in Svelte headless (Svelte 5 + runes)
5. Implement in React, Vue, Blazor headless
6. Create tests for each implementation

## Acceptance Criteria

- [ ] Renders <div> with class="vital-sign-weight-as-kg-view"
- [ ] `role="img"` -- identifies the span as a visual/graphic display element
- [ ] `aria-label={label}` -- provides the full value description for screen readers
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless
- [ ] Tests pass in all implementations
