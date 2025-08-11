# Medical Record Red Box — Implementation Plan

## Goal

Implement the Medical Record Red Box component: a red highlighted box for critical medical record information.

## HTML Tag and CSS Class

- HTML tag: <div>
- CSS class: .medical-record-red-box

## Approach

1. Use semantic <div> element with class="medical-record-red-box"
2. Add ARIA attributes for accessibility
3. Implement in HTML headless (plain HTML + vanilla JS)
4. Implement in Svelte headless (Svelte 5 + runes)
5. Implement in React, Vue, Blazor headless
6. Create tests for each implementation

## Acceptance Criteria

- [ ] Renders <div> with class="medical-record-red-box"
- [ ] `role="alert"` -- creates an assertive live region that immediately announces content to screen readers
- [ ] `aria-label={label}` -- provides the accessible name for the alert region, set from the `label` prop
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless
- [ ] Tests pass in all implementations
