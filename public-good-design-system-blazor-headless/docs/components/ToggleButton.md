# ToggleButton

A toggle is a UI/UX component that provides a binary on/off control using a button with `role="switch"`. It communicates its state through `aria-checked` and supports both click and keyboard (Space key) interaction. The pressed state is bindable for two-way data flow.

Toggles are commonly used for settings like dark mode, notifications, or feature flags where a user needs to switch between two states. While similar to SwitchInput, the ToggleButton component uses a `pressed` prop name rather than `checked`, providing a semantic distinction for use cases where "pressed/unpressed" better describes the interaction than "checked/unchecked".

## Implementation Notes

- Renders a `<button type="button">` element with `role="switch"` for toggle semantics
- Uses `@bind-` for the `pressed` prop enabling two-way data binding with `bind:pressed`
- Click handler toggles `pressed` when not disabled
- Custom `onkeydown` handler processes the Space key to toggle state, with `preventDefault()` to avoid scrolling
- The `type="button"` prevents accidental form submission
- Supports additional attributes via `AdditionalAttributes` for extensibility (e.g., `id`, `class`)
- Functionally similar to SwitchInput but uses `pressed` instead of `checked` for the state prop

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Pressed` | `bool` | `—` | The pressed value |
| `PressedChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Pressed |
| `Disabled` | `bool` | `—` | Whether the component is disabled |
| `ChildContent` | `RenderFragment?` | `—` | Child content to render inside the component |

## Usage


```razor
<ToggleButton label="Dark mode" @bind-Pressed />
```


```razor
<ToggleButton label="Mute audio" @bind-Pressed="muted" disabled=@locked />
```


## Keyboard Interactions

- Space: toggles between on and off states (custom handler with `preventDefault`)
- Enter: activates the button (native button behavior)

## ARIA Attributes

- `role="switch"` -- identifies the element as a two-state toggle switch
- `aria-checked={pressed}` -- communicates whether the toggle is currently on (`true`) or off (`false`)
- `aria-label={label}` -- provides the accessible name for the toggle control

## References

- WAI-ARIA Switch Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/switch/
- WAI-ARIA Switch Role: https://www.w3.org/TR/wai-aria-1.2/#switch
