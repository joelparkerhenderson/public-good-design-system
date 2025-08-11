<script setup lang="ts">

    // VitalSignHeightAsCmView component
    //
    // A read-only display of a height value in centimeters (cm).
    // Used to present vital sign data in patient dashboards, health records,
    // and medical monitoring interfaces. Screen readers receive the full
    // description via aria-label.
    //
    // Props:
    //   value — number, required. Height in centimeters.
    //   label — string, required. Accessible description via aria-label (e.g., "175 cm height").
    //   ...restProps — additional HTML attributes spread onto the outer span.
    //
    // Syntax:
    //   <VitalSignHeightAsCmView :value="175" label="175 cm height" />
    //
    // Examples:
    //   <!-- Display a typical adult height -->
    //   <VitalSignHeightAsCmView :value="175" label="175 cm height" />
    //
    //   <!-- Display a child's height -->
    //   <VitalSignHeightAsCmView :value="120" label="120 cm height" />
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
        /** Height in centimeters. */
        value: number;
        /** Accessible description. */
        label: string;
    }>();

</script>

<template>
    <!-- VitalSignHeightAsCmView.vue -->
    <span
        class="vital-sign-height-as-cm-view"
        role="img"
        :aria-label="label"
        :data-value="value"
    >{{ value }}</span>
</template>
