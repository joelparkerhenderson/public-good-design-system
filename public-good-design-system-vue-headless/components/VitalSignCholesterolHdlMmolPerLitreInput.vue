<script setup lang="ts">

    // VitalSignCholesterolHdlMmolPerLitreInput component
    //
    // A headless numeric input for entering an HDL cholesterol value in millimoles
    // per litre. Wraps a native <input type="number"> element with accessible
    // labelling and sensible default constraints (0-10 mmol/L). Commonly used in
    // medical forms, patient intake screens, and health monitoring applications.
    //
    // Props:
    //   label — string, required. Accessible name for the input via aria-label.
    //   value — number | undefined, default undefined. Current HDL cholesterol value; bindable.
    //   min — number, default 0. Minimum allowed value.
    //   max — number, default 10. Maximum allowed value.
    //   step — number, default 0.1. Increment/decrement step size.
    //   required — boolean, default false. Whether the input is required.
    //   disabled — boolean, default false. Whether the input is disabled.
    //   ...restProps — additional HTML attributes spread onto the <input>.
    //
    // Syntax:
    //   <VitalSignCholesterolHdlMmolPerLitreInput label="HDL cholesterol" v-model />
    //
    // Examples:
    //   <!-- HDL cholesterol input with defaults -->
    //   <VitalSignCholesterolHdlMmolPerLitreInput label="HDL cholesterol (mmol/L)" v-model />
    //
    //   <!-- Required HDL cholesterol input -->
    //   <VitalSignCholesterolHdlMmolPerLitreInput label="HDL cholesterol" v-model required />
    //
    // Keyboard:
    //   - Up Arrow: increment value by step (native browser behavior)
    //   - Down Arrow: decrement value by step (native browser behavior)
    //
    // Accessibility:
    //   - aria-label provides an accessible name describing the input purpose
    //   - Implicit spinbutton role from <input type="number">
    //   - Native validation via min, max, and step attributes
    //
    // Internationalization:
    //   - The label prop is the only user-facing text; no hardcoded strings
    //   - Consumer can pass placeholder via restProps for localized hint text
    //
    // Claude rules:
    //   - Headless: no CSS, no styles — consumer provides all styling
    //   - Uses defineModel() for value
    //   - Do not wrap in a <div> — renders a bare <input> element
    //
    // References:
    //   - HTML number input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number
    //   - WAI-ARIA spinbutton role: https://www.w3.org/TR/wai-aria-1.2/#spinbutton

    withDefaults(defineProps<{
        label: string;
        min?: number;
        max?: number;
        step?: number;
        required?: boolean;
        disabled?: boolean;
    }>(), {
        min: 0,
        max: 10,
        step: 0.1,
        required: false,
        disabled: false,
    });

    const modelValue = defineModel<number | undefined>({ default: undefined });

</script>

<template>
    <!-- VitalSignCholesterolHdlMmolPerLitreInput.vue -->
    <input
        class="vital-sign-cholesterol-hdl-mmol-per-litre-input"
        type="number"
        :aria-label="label"
        v-model="modelValue"
        :min="min"
        :max="max"
        :step="step"
        :required="required"
        :disabled="disabled"
    />
</template>
