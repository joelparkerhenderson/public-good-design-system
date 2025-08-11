# Vital Sign Heart Rate As Beats Per Minute View — Implementation Plan

## Goal

Implement the Vital Sign Heart Rate As Beats Per Minute View component: number display of one vital sign heart rate in beats per minute (BPM) with integers.

## HTML Tag and CSS Class

- HTML tag: <div>
- CSS class: .vital-sign-heart-rate-as-beats-per-minute-view

## Companion Component

- vital-sign-heart-rate-as-beats-per-minute-input (Input/View or Input/Link pair)

## Approach

1. Use semantic <div> element with class="vital-sign-heart-rate-as-beats-per-minute-view"
2. Add ARIA attributes for accessibility
3. Implement in HTML headless (plain HTML + vanilla JS)
4. Implement in Svelte headless (Svelte 5 + runes)
5. Implement in React, Vue, Blazor headless
6. Create tests for each implementation

## Acceptance Criteria

- [ ] Renders <div> with class="vital-sign-heart-rate-as-beats-per-minute-view"
- [ ] `role="img"` -- identifies the span as a visual/graphic display element
- [ ] `aria-label={label}` -- provides the full value description for screen readers
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless
- [ ] Tests pass in all implementations
