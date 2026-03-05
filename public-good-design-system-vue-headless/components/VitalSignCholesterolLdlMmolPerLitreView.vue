<script setup lang="ts">

    // VitalSignCholesterolLdlMmolPerLitreView component
    //
    // A read-only display of an LDL cholesterol value in millimoles per litre.
    // Used to present vital sign data in patient dashboards, health records,
    // and medical monitoring interfaces. Screen readers receive the full
    // description via aria-label.
    //
    // Props:
    //   value — number, required. LDL cholesterol in mmol/L.
    //   label — string, required. Accessible description via aria-label (e.g., "2.5 mmol/L LDL cholesterol").
    //   ...restProps — additional HTML attributes spread onto the outer span.
    //
    // Syntax:
    //   <VitalSignCholesterolLdlMmolPerLitreView :value="2.5" label="2.5 mmol/L LDL cholesterol" />
    //
    // Examples:
    //   <!-- Display a normal LDL cholesterol level -->
    //   <VitalSignCholesterolLdlMmolPerLitreView :value="2.5" label="2.5 mmol/L LDL cholesterol" />
    //
    //   <!-- Display an elevated LDL cholesterol level -->
    //   <VitalSignCholesterolLdlMmolPerLitreView :value="4.5" label="4.5 mmol/L LDL cholesterol" />
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
        /** LDL cholesterol in mmol/L. */
        value: number;
        /** Accessible description. */
        label: string;
    }>();

</script>

<template>
    <!-- VitalSignCholesterolLdlMmolPerLitreView.vue -->
    <span
        class="vital-sign-cholesterol-ldl-mmol-per-litre-view"
        role="img"
        :aria-label="label"
        :data-value="value"
    >{{ value }}</span>
</template>
