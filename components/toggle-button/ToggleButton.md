# ToggleButton

A ToggleButton is a UI/UX component that provides a binary on/off control using a button with `role="switch"`. It communicates its state through `aria-checked` and supports both click and keyboard (Space key) interaction. The pressed state is bindable for two-way data flow.

ToggleButtons are commonly used for settings like dark mode, notifications, or feature flags where a user needs to switch between two states. While similar to SwitchInput, the ToggleButton component uses a `pressed` prop name rather than `checked`, providing a semantic distinction for use cases where "pressed/unpressed" better describes the interaction than "checked/unchecked".

## Help

Use ToggleButton when you need a binary on/off control with button semantics. Common scenarios include dark mode toggles, mute controls, notification switches, and feature flags. For checkbox-style toggles, consider SwitchInput instead.

## Syntax

```svelte
<script>
  import ToggleButton from "./ToggleButton.svelte";
</script>

<ToggleButton label="..." bind:pressed />
```

## Usage

```svelte
<ToggleButton label="Dark mode" bind:pressed />
```

```svelte
<ToggleButton label="Mute audio" bind:pressed={muted} disabled={locked} />
```

## Props

| Prop | Type | Default | Description |
|------|------|---------|-------------|
| `label` | `string` | (required) | Accessible name applied via `aria-label` |
| `pressed` | `boolean` | `false` | Whether the toggle is on; bindable with `bind:pressed` |
| `disabled` | `boolean` | `false` | Whether the toggle is disabled |
| `...restProps` | HTML attributes | | Additional attributes spread onto the `<button>` element |

## Examples

Feature flag control:

```svelte
<script>
  import ToggleButton from "./ToggleButton.svelte";
  let betaFeatures = $state(false);
</script>

<ToggleButton label="Enable beta features" bind:pressed={betaFeatures} />
```

## Keyboard Interactions

- Space: Toggles between on and off states (custom handler with `preventDefault`)
- Enter: Activates the button (native button behavior)

## ARIA

- `role="switch"` -- identifies the element as a two-state toggle switch
- `aria-checked={pressed}` -- communicates whether the toggle is currently on (`true`) or off (`false`)
- `aria-label={label}` -- provides the accessible name for the toggle control

## Claude Rules

- Always use `ToggleButton` (not `Toggle`)
- Always include the required `label` prop
- Use `pressed` (not `checked`) for the state prop
- Use Svelte 5 patterns (`$bindable` for pressed)
- Component is headless/unstyled -- consumer provides all styling

## References

- WAI-ARIA Switch Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/switch/
- WAI-ARIA Switch Role: https://www.w3.org/TR/wai-aria-1.2/#switch
