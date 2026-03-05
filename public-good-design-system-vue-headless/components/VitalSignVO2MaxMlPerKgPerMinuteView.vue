<script setup lang="ts">

    // VitalSignVO2MaxMlPerKgPerMinuteView component
    //
    // A read-only display of a VO2 max value in ml/kg/min.
    // Used to present vital sign data in patient dashboards, health records,
    // fitness tracking interfaces, and cardiorespiratory assessments. Screen
    // readers receive the full description via aria-label.
    //
    // Props:
    //   value — number, required. VO2 max in ml/kg/min.
    //   label — string, required. Accessible description via aria-label (e.g., "42 ml/kg/min VO2 max").
    //   ...restProps — additional HTML attributes spread onto the outer span.
    //
    // Syntax:
    //   <VitalSignVO2MaxMlPerKgPerMinuteView :value="42" label="42 ml/kg/min VO2 max" />
    //
    // Examples:
    //   <!-- Display a normal VO2 max -->
    //   <VitalSignVO2MaxMlPerKgPerMinuteView :value="42" label="42 ml/kg/min VO2 max" />
    //
    //   <!-- Display a high VO2 max -->
    //   <VitalSignVO2MaxMlPerKgPerMinuteView :value="60" label="60 ml/kg/min VO2 max" />
    //
    // Keyboard:
    //   - None — this is a passive, read-only display element
    //
    // Accessibility:
    //   - role="img" on the outer span indicates it represents a visual/graphic element
    //   - aria-label provides the full value description for screen readers
    //   - data-value attribute enables consumer CSS styling
    //
    // Internationalization:
    //   - The label prop allows localized value descriptions
    //   - Consumer provides all text via props; no hardcoded strings
    //
    // Claude rules:
    //   - Headless: no CSS, no styles — consumer provides all styling
    //   - Renders a bare <span> element
    //
    // References:
    //   - WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/

    defineProps<{
        /** VO2 max in ml/kg/min. */
        value: number;
        /** Accessible description. */
        label: string;
    }>();

</script>

<template>
    <!-- VitalSignVO2MaxMlPerKgPerMinuteView.vue -->
    <span
        class="vital-sign-vo2-max-ml-per-kg-per-minute-view"
        role="img"
        :aria-label="label"
        :data-value="value"
    >{{ value }}</span>
</template>
