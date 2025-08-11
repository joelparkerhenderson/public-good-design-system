# SwitchButton

A switch input is a UI/UX component that provides a binary toggle control, similar to a physical on/off switch. It uses `role="switch"` with `aria-checked` to communicate the current state to assistive technologies. The component supports both click and keyboard (Space key) activation for accessibility compliance.

Switch inputs are commonly used for settings, preferences, and feature toggles where users need to enable or disable a single option without submitting a form. Unlike checkboxes, switches provide immediate effect and convey an on/off semantic rather than checked/unchecked.

## Implementation Notes

- Renders a `<button type="button">` element with `role="switch"` for switch semantics
- Uses `@bind-` for the `checked` prop enabling two-way data binding with `@bind-Checked`
- Click handler toggles `checked` when not disabled
- Custom `onkeydown` handler processes the Space key to toggle state, with `preventDefault()` to avoid scrolling
- The `type="button"` prevents accidental form submission
- Supports additional attributes via `AdditionalAttributes` for extensibility (e.g., `id`, `class`)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Checked` | `bool` | `—` | The checked value |
| `CheckedChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Checked |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<SwitchButton label="Enable notifications" @bind-Checked />
```


```razor
<SwitchButton label="Dark mode" @bind-Checked="darkMode" disabled=@locked />
```


## Keyboard Interactions

- Space: toggles the switch between on and off states (custom handler with `preventDefault`)
- Enter: activates the button (native button behavior)

## ARIA Attributes

- `role="switch"` -- identifies the element as a two-state toggle switch
- `aria-checked={checked}` -- communicates whether the switch is currently on (`true`) or off (`false`)
- `aria-label={label}` -- provides the accessible name for the switch control

## References

- WAI-ARIA Switch Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/switch/
- WAI-ARIA Switch Role: https://www.w3.org/TR/wai-aria-1.2/#switch
