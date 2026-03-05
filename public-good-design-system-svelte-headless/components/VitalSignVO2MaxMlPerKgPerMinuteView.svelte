<script lang="ts">
    // VitalSignVO2MaxMlPerKgPerMinuteView component
    //
    // A read-only display of a VO2 max value in ml/kg/min. This is a passive view
    // element used for showing vital sign readings in patient monitors, health
    // dashboards, medical records, and fitness applications. Screen readers receive
    // the full description via aria-label.
    //
    // Props:
    //   className — string, optional. CSS class name.
    //   value — number, required. VO2 max value in ml/kg/min to display.
    //   label — string, required. Accessible description via aria-label (e.g., "42 ml/kg/min VO2 max").
    //   ...restProps — additional HTML attributes spread onto the outer span.
    //
    // Syntax:
    //   <VitalSignVO2MaxMlPerKgPerMinuteView value={42} label="42 ml/kg/min VO2 max" />
    //
    // Examples:
    //   <!-- Display a normal VO2 max reading -->
    //   <VitalSignVO2MaxMlPerKgPerMinuteView value={42} label="42 ml/kg/min VO2 max" />
    //
    //   <!-- Display a high VO2 max reading -->
    //   <VitalSignVO2MaxMlPerKgPerMinuteView value={70} label="70 ml/kg/min VO2 max" />
    //
    // Keyboard:
    //   - None — this is a passive, read-only display element
    //
    // Accessibility:
    //   - role="img" on the span indicates it represents a visual/graphic element
    //   - aria-label provides the full VO2 max description for screen readers
    //   - data-value attribute enables consumer CSS styling based on the numeric value
    //
    // Internationalization:
    //   - The label prop allows localized VO2 max descriptions
    //   - No hardcoded user-facing strings; all text comes through props
    //
    // Claude rules:
    //   - Headless: no CSS, no styles — consumer provides all styling
    //   - Companion to VitalSignVO2MaxMlPerKgPerMinuteInput for the Input/View pattern
    //
    // References:
    //   - WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/

    let {
        class: className = "",
        value,
        label,
        ...restProps
    }: {
        /** VO2 max value in ml/kg/min. */
        value: number;
        /** Accessible description. */
        label: string;
        [key: string]: unknown;
    } = $props();
</script>

<!-- VitalSignVO2MaxMlPerKgPerMinuteView.svelte -->
<span
    class={`vital-sign-vo2-max-ml-per-kg-per-minute-view ${className}`}
    role="img"
    aria-label={label}
    data-value={value}
    {...restProps}
>{value}</span>
