<script setup lang="ts">

    // VitalSignBodyFatAsPercentageView component
    //
    // A read-only display of a body fat percentage value.
    // Used to present vital sign data in patient dashboards, health records,
    // fitness tracking interfaces, and wellness monitoring applications.
    // Screen readers receive the full description via aria-label.
    //
    // Props:
    //   value — number, required. Body fat percentage value.
    //   label — string, required. Accessible description via aria-label (e.g., "22.5 percent body fat").
    //   ...restProps — additional HTML attributes spread onto the outer span.
    //
    // Syntax:
    //   <VitalSignBodyFatAsPercentageView :value="22.5" label="22.5 percent body fat" />
    //
    // Examples:
    //   <!-- Display a typical body fat percentage -->
    //   <VitalSignBodyFatAsPercentageView :value="22.5" label="22.5 percent body fat" />
    //
    //   <!-- Display a low body fat percentage -->
    //   <VitalSignBodyFatAsPercentageView :value="10.0" label="10.0 percent body fat" />
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
        /** Body fat percentage value. */
        value: number;
        /** Accessible description. */
        label: string;
    }>();

</script>

<template>
    <!-- VitalSignBodyFatAsPercentageView.vue -->
    <span
        class="vital-sign-body-fat-as-percentage-view"
        role="img"
        :aria-label="label"
        :data-value="value"
    >{{ value }}</span>
</template>
