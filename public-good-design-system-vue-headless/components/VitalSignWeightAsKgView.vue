<script setup lang="ts">

    // VitalSignWeightAsKgView component
    //
    // A read-only display of a weight value in kilograms (kg).
    // Used to present vital sign data in patient dashboards, health records,
    // and medical monitoring interfaces. Screen readers receive the full
    // description via aria-label.
    //
    // Props:
    //   value — number, required. Weight in kilograms.
    //   label — string, required. Accessible description via aria-label (e.g., "75 kg weight").
    //   ...restProps — additional HTML attributes spread onto the outer span.
    //
    // Syntax:
    //   <VitalSignWeightAsKgView :value="75" label="75 kg weight" />
    //
    // Examples:
    //   <!-- Display a typical adult weight -->
    //   <VitalSignWeightAsKgView :value="75" label="75 kg weight" />
    //
    //   <!-- Display a child's weight -->
    //   <VitalSignWeightAsKgView :value="30" label="30 kg weight" />
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
        /** Weight in kilograms. */
        value: number;
        /** Accessible description. */
        label: string;
    }>();

</script>

<template>
    <!-- VitalSignWeightAsKgView.vue -->
    <span
        class="vital-sign-weight-as-kg-view"
        role="img"
        :aria-label="label"
        :data-value="value"
    >{{ value }}</span>
</template>
