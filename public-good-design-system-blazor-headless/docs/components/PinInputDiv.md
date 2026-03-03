# PinInputDiv

A PIN input is a specialized form component that presents a series of
single-character input fields for entering Personal Identification Numbers
(PINs), verification codes, one-time passwords (OTPs), or similar short numeric
codes. Each digit occupies its own input field, creating a segmented entry
experience that clearly communicates the expected code length to the user.

The component automatically advances focus to the next field when a digit is
entered, supports Backspace to move back to the previous field, and allows Arrow
key navigation between fields. The combined value of all digit fields is
available as a single bindable string. This pattern is commonly used in
two-factor authentication flows, SMS verification, and secure PIN entry
interfaces. Each individual input field has an accessible label indicating its
position (e.g., "Digit 1 of 4") to support screen reader users.

## Implementation Notes

- Renders as `<div role="group">` containing individual single-digit `<input>` elements
- Uses `private field` for internal digits array and `@bind-` for combined value
- Auto-focuses next input on digit entry
- Backspace in empty input moves focus to previous input
- ArrowLeft/ArrowRight navigate between inputs
- Only accepts numeric characters (0-9)
- `inputmode="numeric"` ensures numeric keyboard on mobile devices
- `maxlength="1"` restricts each input to a single character

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Length` | `int` | `4` | The length value |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage

Basic 4-digit PIN input:

```razor
@code {

  private string pin = "";;
}

<PinInputDiv label="Enter PIN" @bind-Value="pin" />
<p>Entered PIN: @pin</p>
```

6-digit verification code:

```razor
@code {

  private string code = "";;
}

<PinInputDiv label="Verification Code" length=@6 @bind-Value="code" />
```

Disabled state:

```razor
<PinInputDiv label="Locked PIN" disabled />
```

With additional HTML attributes:

```razor
<PinInputDiv label="OTP" @bind-Value="otp" data-form="login" />
```


## Keyboard Interactions

- Digit entry: enters value and auto-focuses next input
- Backspace: clears current or moves to previous input
- ArrowLeft: focuses previous input
- ArrowRight: focuses next input
- Tab: standard tab navigation in/out of the group

## ARIA Attributes

- `role="group"` with `aria-label` on the container
- Each input has `aria-label="Digit X of Y"` for positional context
- `inputmode="numeric"` for numeric keyboard on mobile

## References

- WAI-ARIA Group Role: https://www.w3.org/TR/wai-aria-1.2/#group
