# Vital Sign Weight As Kg Input — Implementation Plan

## Goal

Implement the Vital Sign Weight As Kg Input component: number input of one vital sign weight in kilograms with integers.

## HTML Tag and CSS Class

- HTML tag: <input>
- CSS class: .vital-sign-weight-as-kg-input

## Companion Component

- vital-sign-weight-as-kg-view (Input/View or Input/Link pair)

## Approach

1. Use semantic <input> element with class="vital-sign-weight-as-kg-input"
2. Add ARIA attributes for accessibility
3. Implement keyboard navigation
4. Add vanilla JavaScript for interactive behavior
5. Implement in HTML headless (plain HTML + vanilla JS)
6. Implement in Svelte headless (Svelte 5 + runes)
7. Implement in React, Vue, Blazor headless
8. Create tests for each implementation

## Acceptance Criteria

- [ ] Renders <input> with class="vital-sign-weight-as-kg-input"
- [ ] `aria-label={label}` -- provides an accessible name describing the purpose of the weight input
- [ ] Keyboard: Up Arrow: increment value by 1 (native browser behavior)
- [ ] Keyboard: Down Arrow: decrement value by 1 (native browser behavior)
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless
- [ ] Tests pass in all implementations
