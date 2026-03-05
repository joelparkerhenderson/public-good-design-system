<script setup lang="ts">

    // VitalSignBloodPressureDiastolicView component
    //
    // A read-only display of a diastolic blood pressure value in millimeters of
    // mercury (mmHg). Used to present vital sign data in patient dashboards,
    // health records, and medical monitoring interfaces. Screen readers receive
    // the full description via aria-label.
    //
    // Props:
    //   value — number, required. Diastolic blood pressure in mmHg.
    //   label — string, required. Accessible description via aria-label (e.g., "80 mmHg diastolic").
    //   ...restProps — additional HTML attributes spread onto the outer span.
    //
    // Syntax:
    //   <VitalSignBloodPressureDiastolicView :value="80" label="80 mmHg diastolic" />
    //
    // Examples:
    //   <!-- Display a normal diastolic blood pressure -->
    //   <VitalSignBloodPressureDiastolicView :value="80" label="80 mmHg diastolic" />
    //
    //   <!-- Display an elevated diastolic blood pressure -->
    //   <VitalSignBloodPressureDiastolicView :value="95" label="95 mmHg diastolic" />
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
        /** Diastolic blood pressure in mmHg. */
        value: number;
        /** Accessible description. */
        label: string;
    }>();

</script>

<template>
    <!-- VitalSignBloodPressureDiastolicView.vue -->
    <span
        class="vital-sign-blood-pressure-diastolic-view"
        role="img"
        :aria-label="label"
        :data-value="value"
    >{{ value }}</span>
</template>
