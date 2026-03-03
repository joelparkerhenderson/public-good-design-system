# EmailInput

An email input wraps a native `<input type="email">` with accessible labeling. Provides a streamlined API for basic email collection with required and disabled state support.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `Required` | `bool` | `—` | The required value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<EmailInput label="Your email" @bind-Value />
```


```razor
<EmailInput label="Contact email" @bind-Value required />
```



## References

- [MDN input type="email"](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/email)
