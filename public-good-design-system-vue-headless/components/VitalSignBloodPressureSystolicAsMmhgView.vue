<script setup lang="ts">

    // VitalSignBloodPressureSystolicAsMmhgView component
    //
    // A read-only display of a systolic blood pressure value in millimeters of
    // mercury (mmHg). Used to present vital sign data in patient dashboards,
    // health records, and medical monitoring interfaces. Screen readers receive
    // the full description via aria-label.
    //
    // Props:
    //   value — number, required. Systolic blood pressure in mmHg.
    //   label — string, required. Accessible description via aria-label (e.g., "120 mmHg systolic").
    //   ...restProps — additional HTML attributes spread onto the outer span.
    //
    // Syntax:
    //   <VitalSignBloodPressureSystolicAsMmhgView :value="120" label="120 mmHg systolic" />
    //
    // Examples:
    //   <!-- Display a normal systolic blood pressure -->
    //   <VitalSignBloodPressureSystolicAsMmhgView :value="120" label="120 mmHg systolic" />
    //
    //   <!-- Display an elevated systolic blood pressure -->
    //   <VitalSignBloodPressureSystolicAsMmhgView :value="140" label="140 mmHg systolic" />
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
        /** Systolic blood pressure in mmHg. */
        value: number;
        /** Accessible description. */
        label: string;
    }>();

</script>

<template>
    <!-- VitalSignBloodPressureSystolicAsMmhgView.vue -->
    <span
        class="vital-sign-blood-pressure-systolic-as-mmhg-view"
        role="img"
        :aria-label="label"
        :data-value="value"
    >{{ value }}</span>
</template>
