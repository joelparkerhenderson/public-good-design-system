<script setup lang="ts">

    // VitalSignCholesterolAsHdlMmolPerLitreView component
    //
    // A read-only display of an HDL cholesterol value in millimoles per litre.
    // Used to present vital sign data in patient dashboards, health records,
    // and medical monitoring interfaces. Screen readers receive the full
    // description via aria-label.
    //
    // Props:
    //   value — number, required. HDL cholesterol in mmol/L.
    //   label — string, required. Accessible description via aria-label (e.g., "1.5 mmol/L HDL cholesterol").
    //   ...restProps — additional HTML attributes spread onto the outer span.
    //
    // Syntax:
    //   <VitalSignCholesterolAsHdlMmolPerLitreView :value="1.5" label="1.5 mmol/L HDL cholesterol" />
    //
    // Examples:
    //   <!-- Display a normal HDL cholesterol level -->
    //   <VitalSignCholesterolAsHdlMmolPerLitreView :value="1.5" label="1.5 mmol/L HDL cholesterol" />
    //
    //   <!-- Display a low HDL cholesterol level -->
    //   <VitalSignCholesterolAsHdlMmolPerLitreView :value="0.8" label="0.8 mmol/L HDL cholesterol" />
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
        /** HDL cholesterol in mmol/L. */
        value: number;
        /** Accessible description. */
        label: string;
    }>();

</script>

<template>
    <!-- VitalSignCholesterolAsHdlMmolPerLitreView.vue -->
    <span
        class="vital-sign-cholesterol-as-hdl-mmol-per-litre-view"
        role="img"
        :aria-label="label"
        :data-value="value"
    >{{ value }}</span>
</template>
