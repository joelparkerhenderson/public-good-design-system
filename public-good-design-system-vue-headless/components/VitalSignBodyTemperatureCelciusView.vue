<script setup lang="ts">

    // VitalSignBodyTemperatureCelciusView component
    //
    // A read-only display of a body temperature value in degrees Celsius.
    // Used to present vital sign data in patient dashboards, health records,
    // and medical monitoring interfaces. Screen readers receive the full
    // description via aria-label.
    //
    // Props:
    //   value — number, required. Body temperature in degrees Celsius.
    //   label — string, required. Accessible description via aria-label (e.g., "37.0 degrees Celsius").
    //   ...restProps — additional HTML attributes spread onto the outer span.
    //
    // Syntax:
    //   <VitalSignBodyTemperatureCelciusView :value="37.0" label="37.0 degrees Celsius" />
    //
    // Examples:
    //   <!-- Display a normal body temperature -->
    //   <VitalSignBodyTemperatureCelciusView :value="37.0" label="37.0 degrees Celsius" />
    //
    //   <!-- Display an elevated body temperature -->
    //   <VitalSignBodyTemperatureCelciusView :value="39.5" label="39.5 degrees Celsius" />
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
        /** Body temperature in degrees Celsius. */
        value: number;
        /** Accessible description. */
        label: string;
    }>();

</script>

<template>
    <!-- VitalSignBodyTemperatureCelciusView.vue -->
    <span
        class="vital-sign-body-temperature-celcius-view"
        role="img"
        :aria-label="label"
        :data-value="value"
    >{{ value }}</span>
</template>
