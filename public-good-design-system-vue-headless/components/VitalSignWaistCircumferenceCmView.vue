<script setup lang="ts">

    // VitalSignWaistCircumferenceCmView component
    //
    // A read-only display of a waist circumference value in centimeters (cm).
    // Used to present vital sign data in patient dashboards, health records,
    // and medical monitoring interfaces. Screen readers receive the full
    // description via aria-label.
    //
    // Props:
    //   value — number, required. Waist circumference in centimeters.
    //   label — string, required. Accessible description via aria-label (e.g., "94 cm waist circumference").
    //   ...restProps — additional HTML attributes spread onto the outer span.
    //
    // Syntax:
    //   <VitalSignWaistCircumferenceCmView :value="94" label="94 cm waist circumference" />
    //
    // Examples:
    //   <!-- Display a normal waist circumference -->
    //   <VitalSignWaistCircumferenceCmView :value="80" label="80 cm waist circumference" />
    //
    //   <!-- Display an elevated waist circumference -->
    //   <VitalSignWaistCircumferenceCmView :value="110" label="110 cm waist circumference" />
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
        /** Waist circumference in centimeters. */
        value: number;
        /** Accessible description. */
        label: string;
    }>();

</script>

<template>
    <!-- VitalSignWaistCircumferenceCmView.vue -->
    <span
        class="vital-sign-waist-circumference-cm-view"
        role="img"
        :aria-label="label"
        :data-value="value"
    >{{ value }}</span>
</template>
