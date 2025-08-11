# Vital Sign Cholesterol As LDL Mmol Per Litre View — Implementation Plan

## Goal

Implement the Vital Sign Cholesterol As LDL Mmol Per Litre View component: number display of one vital sign cholesterol LDL (bad cholesterol) millimole per litre with one decimal point.

## HTML Tag and CSS Class

- HTML tag: <div>
- CSS class: .vital-sign-cholesterol-as-ldl-mmol-per-litre-view

## Companion Component

- vital-sign-cholesterol-as-ldl-mmol-per-litre-input (Input/View or Input/Link pair)

## Approach

1. Use semantic <div> element with class="vital-sign-cholesterol-as-ldl-mmol-per-litre-view"
2. Add ARIA attributes for accessibility
3. Implement in HTML headless (plain HTML + vanilla JS)
4. Implement in Svelte headless (Svelte 5 + runes)
5. Implement in React, Vue, Blazor headless
6. Create tests for each implementation

## Acceptance Criteria

- [ ] Renders <div> with class="vital-sign-cholesterol-as-ldl-mmol-per-litre-view"
- [ ] `role="img"` -- identifies the span as a visual/graphic display element
- [ ] `aria-label={label}` -- provides the full value description for screen readers
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless
- [ ] Tests pass in all implementations
