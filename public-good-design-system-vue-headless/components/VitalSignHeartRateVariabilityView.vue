<script setup lang="ts">

    // VitalSignHeartRateVariabilityView component
    //
    // A read-only display of a heart rate variability (HRV) value in milliseconds.
    // Used to present vital sign data in patient dashboards, health records,
    // and medical monitoring interfaces. Screen readers receive the full
    // description via aria-label.
    //
    // Props:
    //   value — number, required. Heart rate variability in milliseconds.
    //   label — string, required. Accessible description via aria-label (e.g., "45 milliseconds HRV").
    //   ...restProps — additional HTML attributes spread onto the outer span.
    //
    // Syntax:
    //   <VitalSignHeartRateVariabilityView :value="45" label="45 milliseconds HRV" />
    //
    // Examples:
    //   <!-- Display a normal HRV -->
    //   <VitalSignHeartRateVariabilityView :value="45" label="45 milliseconds HRV" />
    //
    //   <!-- Display a high HRV -->
    //   <VitalSignHeartRateVariabilityView :value="100" label="100 milliseconds HRV" />
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
        /** Heart rate variability in milliseconds. */
        value: number;
        /** Accessible description. */
        label: string;
    }>();

</script>

<template>
    <!-- VitalSignHeartRateVariabilityView.vue -->
    <span
        class="vital-sign-heart-rate-variability-view"
        role="img"
        :aria-label="label"
        :data-value="value"
    >{{ value }}</span>
</template>
