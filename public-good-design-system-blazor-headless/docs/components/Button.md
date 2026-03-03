# Button

A button is a fundamental UI/UX component that allows users to trigger an action
or event within an interface, such as submitting a form, navigating to another
page, or opening a menu. Buttons are essential for guiding users through tasks,
providing clear feedback on actions, and enhancing the overall user experience
by offering intuitive, actionable controls.

This headless component uses the native HTML `<button>` element for inherent
accessibility and keyboard support. It supports toggle button semantics via the
`pressed` prop, accessible label overrides, and all standard button types.

## Implementation Notes

- Uses native `<button>` element for inherent keyboard and accessibility support
- Defaults to `type="button"` (not "submit") to prevent accidental form submissions
- `aria-pressed` only rendered when `pressed` prop is provided (toggle button pattern)
- `aria-label` provides screen reader override when button text alone is insufficient
- Native disabled attribute prevents click events automatically

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Type` | `string?` | `button` | HTML element type attribute |
| `Disabled` | `bool` | `—` | Whether the component is disabled |
| `Pressed` | `bool` | `—` | The pressed value |
| `Label` | `string?` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage

Basic action button:

```razor
@code {

  private void handleClick() {
    console.log("clicked");
  }
}

<Button @onclick="handleClick">Click me</Button>
```

Submit button in a form:

```razor
@code {

  private bool isSubmitting = false;;
}

<form>
  <Button type="submit" disabled=@isSubmitting>Submit</Button>
</form>
```

Toggle button with pressed state:

```razor
@code {

  private bool isBold = false;;
}

<Button pressed=@isBold @onclick="HandleClick">Bold</Button>
```

With accessible label override:

```razor
<Button label="Close dialog" @onclick="handleClose">X</Button>
```


## Keyboard Interactions

- Tab: Focus the button
- Enter: Activate the button
- Space: Activate the button
- (All handled natively by `<button>` element)

## ARIA Attributes

- Implicit `button` role from `<button>` element
- `aria-pressed` for toggle button state (when provided)
- `aria-label` for screen reader text override
- `aria-disabled` from native disabled attribute

## References

- WAI-ARIA Button Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/button/
