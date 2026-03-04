# Kanban

A Kanban board is a component that organizes work items into columns representing different stages of a workflow, such as "To Do," "In Progress," and "Done." Commonly used in project management tools, agile development platforms, and task tracking applications, the Kanban board provides a visual overview of work status and flow, helping teams identify bottlenecks and prioritize tasks.

This headless component renders a `<div>` with `role="region"` and an accessible label, defining a semantic boundary for the board. The consumer provides the column structure, card content, and any drag-and-drop or keyboard-based item movement as children.

## Implementation Notes

- Renders a `<div>` with `role="region"` to define a named landmark for the Kanban board
- Consumer provides column containers and item cards as children
- The region role with a label allows screen reader users to navigate directly to the board
- Accepts `...restProps` for forwarding additional attributes to the container
- No internal state -- purely a structural wrapper

## Props

- `label`: string (required) -- accessible name describing the board, applied via `aria-label`
- `children`: slot (required) -- the board content including columns and cards

## Usage

```html
<Kanban label="Sprint 5 board">
    <div>
        <h3>To Do</h3>
        <ul>
            <li>Task A</li>
            <li>Task B</li>
        </ul>
    </div>
    <div>
        <h3>In Progress</h3>
        <ul>
            <li>Task C</li>
        </ul>
    </div>
    <div>
        <h3>Done</h3>
        <ul>
            <li>Task D</li>
        </ul>
    </div>
</Kanban>
```

## Keyboard Interactions

None built-in -- the consumer should implement keyboard interactions for moving items between columns and navigating within the board as appropriate.

## ARIA

- `role="region"` -- defines the Kanban board as a named landmark section
- `aria-label={label}` -- provides an accessible name for the board region

## When to Use

- Use to organize work items into columns representing workflow stages (e.g., "To Do", "In Progress", "Done") in project management or task tracking tools.
- Use when teams need a visual overview of work status, flow, and bottlenecks.
- Avoid for simple task lists without workflow stages; use TaskList or CheckList instead.

## Headless

This headless component provides a `<div>` with `role="region"` and `aria-label` for defining a named landmark for the Kanban board. The consumer provides all visual styling including column layout, card design, drag-and-drop interactions, and status color coding.

## Advice

- **Designers**: Use distinct column backgrounds or headers to clearly separate workflow stages. Design cards with consistent layout showing title, assignee, and priority.
- **Developers**: Implement keyboard-based item movement between columns for accessibility. The consumer is responsible for drag-and-drop and column management.

## Composition

KanbanTable uses the Table composition pattern: KanbanTable contains KanbanTableHead, KanbanTableBody, and optionally KanbanTableFoot. Each section contains KanbanTableRow elements, which contain KanbanTableData cells representing items in each workflow column. Use KanbanTableCol for column-level styling.

## References

- WAI-ARIA region role: https://www.w3.org/TR/wai-aria-1.2/#region
