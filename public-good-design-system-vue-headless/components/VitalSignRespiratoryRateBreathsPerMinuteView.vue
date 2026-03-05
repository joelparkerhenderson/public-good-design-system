<script setup lang="ts">

    // VitalSignRespiratoryRateBreathsPerMinuteView component
    //
    // A read-only display of a respiratory rate value in breaths per minute.
    // Used to present vital sign data in patient dashboards, health records,
    // and medical monitoring interfaces. Screen readers receive the full
    // description via aria-label.
    //
    // Props:
    //   value — number, required. Respiratory rate in breaths per minute.
    //   label — string, required. Accessible description via aria-label (e.g., "16 breaths per minute").
    //   ...restProps — additional HTML attributes spread onto the outer span.
    //
    // Syntax:
    //   <VitalSignRespiratoryRateBreathsPerMinuteView :value="16" label="16 breaths per minute" />
    //
    // Examples:
    //   <!-- Display a normal respiratory rate -->
    //   <VitalSignRespiratoryRateBreathsPerMinuteView :value="16" label="16 breaths per minute" />
    //
    //   <!-- Display an elevated respiratory rate -->
    //   <VitalSignRespiratoryRateBreathsPerMinuteView :value="24" label="24 breaths per minute" />
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
        /** Respiratory rate in breaths per minute. */
        value: number;
        /** Accessible description. */
        label: string;
    }>();

</script>

<template>
    <!-- VitalSignRespiratoryRateBreathsPerMinuteView.vue -->
    <span
        class="vital-sign-respiratory-rate-breaths-per-minute-view"
        role="img"
        :aria-label="label"
        :data-value="value"
    >{{ value }}</span>
</template>
