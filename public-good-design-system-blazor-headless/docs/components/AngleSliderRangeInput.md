# AngleSliderRangeInput

An angle slider range input is a specialized range input component for selecting
an angle value, typically between 0 and 360 degrees. Built on the native HTML
range input, it provides semantic ARIA slider attributes including value text
that conveys
the angle with a degree symbol to screen readers.

Common uses include rotation controls, compass direction selectors, gradient
angle pickers, and any interface where a circular or angular value needs to be
selected by the user. The step property allows snapping to common increments
like 15 or 45 degrees.

## Implementation Notes

- Built on native `<input type="range">` for inherent slider behavior
- Uses `@bind-` for two-way value binding
- `aria-valuetext` provides human-readable angle text (e.g., "90") for screen readers
- Customizable suffix via `valueTextSuffix` prop (default "°", can be " degrees" etc.)
- `$derived()` computes valueText reactively from value and suffix

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Value` | `int` | `0` | The value value |
| `ValueChanged` | `EventCallback<int>` | `—` | Event callback for two-way binding of Value |
| `Min` | `int` | `—` | The min value |
| `Max` | `int` | `360` | The max value |
| `Step` | `int` | `1` | The step value |
| `Label` | `string` | `—` | Accessible label for the component |
| `Disabled` | `bool` | `—` | Whether the component is disabled |
| `Name` | `string?` | `—` | The name value |
| `Id` | `string?` | `—` | The id value |
| `ValueTextSuffix` | `string?` | `°` | The value text suffix value |

## Usage

Basic angle slider range input:

```razor
@code {

  private int angle = 0;;
}

<AngleSliderRangeInput label="Rotation" @bind-Value="angle" />
<p>Angle: @angle degrees</p>
```

With step snapping (every 15 degrees):

```razor
@code {

  private int direction = 90;;
}

<AngleSliderRangeInput label="Direction" @bind-Value="direction" step=@15 />
```

Custom range and suffix:

```razor
<AngleSliderRangeInput
  label="Tilt"
  @bind-Value="tilt"
  min={-90}
  max=@90
  valueTextSuffix=" degrees"
/>
```

Disabled slider:

```razor
<AngleSliderRangeInput label="Locked rotation" value=@45 disabled />
```

Within a form:

```razor
<form>
  <AngleSliderRangeInput label="Gradient angle" @bind-Value="angle" name="gradient-angle" id="gradient" />
</form>
```


## Keyboard Interactions

- Arrow Right/Up: Increase value by step
- Arrow Left/Down: Decrease value by step
- Home: Set to minimum
- End: Set to maximum
- (All handled natively by input[type="range"])

## ARIA Attributes

- `role="slider"` (implicit from input[type="range"])
- `aria-label` from label prop
- `aria-valuemin`, `aria-valuemax`, `aria-valuenow`
- `aria-valuetext` for human-readable angle (e.g., "90°")

## References

- WAI-ARIA Slider Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/slider/
