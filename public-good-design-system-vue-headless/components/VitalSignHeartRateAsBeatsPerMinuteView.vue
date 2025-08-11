<script setup lang="ts">

    // VitalSignHeartRateAsBeatsPerMinuteView component
    //
    // A read-only display of a heart rate value in beats per minute (BPM).
    // Used to present vital sign data in patient dashboards, health records,
    // and medical monitoring interfaces. Screen readers receive the full
    // description via aria-label.
    //
    // Props:
    //   value — number, required. Heart rate in beats per minute.
    //   label — string, required. Accessible description via aria-label (e.g., "72 beats per minute").
    //   ...restProps — additional HTML attributes spread onto the outer span.
    //
    // Syntax:
    //   <VitalSignHeartRateAsBeatsPerMinuteView :value="72" label="72 beats per minute" />
    //
    // Examples:
    //   <!-- Display a normal heart rate -->
    //   <VitalSignHeartRateAsBeatsPerMinuteView :value="72" label="72 beats per minute" />
    //
    //   <!-- Display an elevated heart rate -->
    //   <VitalSignHeartRateAsBeatsPerMinuteView :value="110" label="110 beats per minute" />
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
        /** Heart rate in beats per minute. */
        value: number;
        /** Accessible description. */
        label: string;
    }>();

</script>

<template>
    <!-- VitalSignHeartRateAsBeatsPerMinuteView.vue -->
    <span
        class="vital-sign-heart-rate-as-beats-per-minute-view"
        role="img"
        :aria-label="label"
        :data-value="value"
    >{{ value }}</span>
</template>
