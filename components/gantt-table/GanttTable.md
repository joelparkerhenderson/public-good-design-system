# GanttChart

A Gantt chart is a component that displays project tasks and their timelines as horizontal bars along a time axis, providing a visual overview of project schedules, dependencies, and progress. Commonly used in project management tools, resource planning applications, and team collaboration platforms, the Gantt chart helps users understand task durations, overlaps, milestones, and sequencing at a glance.

This headless component renders a `<table>` element with `role="grid"` and an accessible label. The consumer provides the table structure with rows for tasks and columns for time periods, along with any visual bar representations.

## Implementation Notes

- Renders a `<table>` element with `role="grid"` for structured task/timeline grid semantics
- Consumer provides `<tr>` rows for tasks and `<td>`/`<th>` cells for time periods
- The grid structure allows screen readers to navigate tasks and time periods systematically
- Accepts `...restProps` for forwarding additional attributes to the table element
- No internal state -- purely a structural wrapper

## Props

- `label`: string (required) -- accessible name describing the Gantt chart content, applied via `aria-label`
- `children`: Snippet (required) -- table rows and cells representing tasks and timelines

## Usage

```svelte
<GanttChart label="Project Alpha timeline">
    <thead>
        <tr><th>Task</th><th>Week 1</th><th>Week 2</th><th>Week 3</th></tr>
    </thead>
    <tbody>
        <tr><th>Design</th><td>---</td><td></td><td></td></tr>
        <tr><th>Development</th><td></td><td>---</td><td>---</td></tr>
    </tbody>
</GanttChart>
```

## Keyboard Interactions

None built-in -- the consumer should implement grid keyboard navigation on cells as needed (arrow keys for cell-to-cell movement).

## ARIA

- `role="grid"` -- identifies the table as an interactive grid widget
- `aria-label={label}` -- provides an accessible name describing the Gantt chart

## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
