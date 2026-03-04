# Check List Item

A check list item represents a single entry within a CheckList, rendered as a semantic `<li>` element. Each item typically contains a checkbox input and associated label text, allowing users to mark items as completed or pending. The consumer provides the checkbox and content through the children slot, giving full control over the interactive behavior and visual presentation.

This component is commonly used in to-do lists, onboarding checklists, task trackers, and forms where users need to acknowledge or complete multiple items.

## Implementation Notes

- Renders as a semantic `<li>` element for use inside a CheckList `<ul>` structure
- Content is provided through the children slot, typically a checkbox input and label text
- The consumer is responsible for providing the checkbox input and managing its checked state
- Spreads `...restProps` onto the `<li>` element for consumer customization
- No internal state -- the consumer manages checkbox state

## Props

- `children`: slot (required) -- item content, typically a checkbox input and label text
- `...restProps`: any -- additional HTML attributes spread onto the `<li>` element

## Usage

```html
<CheckList label="Onboarding tasks">
    <CheckListItem>
        <input type="checkbox" id="task-1" />
        <label for="task-1">Create account</label>
    </CheckListItem>
    <CheckListItem>
        <input type="checkbox" id="task-2" />
        <label for="task-2">Set up profile</label>
    </CheckListItem>
    <CheckListItem>
        <input type="checkbox" id="task-3" checked />
        <label for="task-3">Invite team members</label>
    </CheckListItem>
</CheckList>
```

## Keyboard Interactions

None directly -- keyboard interaction is handled by the contained checkbox input (Space to toggle).

## ARIA

- Implicit `listitem` role from the semantic `<li>` element
- Checkbox semantics are provided by the consumer-supplied `<input type="checkbox">` element

## References

- WAI-ARIA Listbox Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/listbox/
