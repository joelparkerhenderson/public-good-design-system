<script setup lang="ts">

    // PinInputDiv component
    //
    // A headless PIN input that renders a group of single-character numeric inputs
    // for entering PINs, verification codes, or one-time passwords (OTPs). Each
    // digit occupies its own input field, creating a segmented entry experience that
    // communicates the expected code length. Focus auto-advances on digit entry and
    // retreats on Backspace. Commonly used in two-factor authentication, SMS
    // verification, and secure PIN entry interfaces.
    //
    // Props:
    //   className — string, optional. CSS class name.
    //   label — string, required. Accessible label for the group of inputs via aria-label.
    //   length — number, default 4. Number of digit inputs to render.
    //   value — string, default "". Bindable combined string of all entered digits.
    //   disabled — boolean, default false. Whether all inputs are disabled.
    //   ...restProps — additional HTML attributes spread onto the group <div>.
    //
    // Syntax:
    //   <PinInputDiv label="Enter PIN" v-model />
    //
    // Examples:
    //   <!-- 4-digit PIN input -->
    //   <PinInputDiv label="Enter PIN" v-model={pin} />
    //
    //   <!-- 6-digit verification code -->
    //   <PinInputDiv label="Verification Code" length={6} v-model={code} />
    //
    //   <!-- Disabled PIN input -->
    //   <PinInputDiv label="Locked PIN" disabled />
    //
    // Keyboard:
    //   - Digit entry: enters value and auto-focuses next input
    //   - Backspace: clears current digit or moves to previous input if empty
    //   - ArrowLeft: focuses previous input
    //   - ArrowRight: focuses next input
    //   - Tab: standard tab navigation in/out of the group
    //
    // Accessibility:
    //   - role="group" with aria-label on the container identifies the PIN group
    //   - Each input has aria-label="Digit X of Y" for positional context
    //   - inputmode="numeric" ensures numeric keyboard on mobile devices
    //   - maxlength="1" restricts each input to a single character
    //
    // Internationalization:
    //   - The label prop is consumer-provided for the group name
    //   - Individual "Digit X of Y" labels are currently hardcoded in English
    //   - No other hardcoded user-facing strings
    //
    // Claude rules:
    //   - Headless: no CSS, no styles — consumer provides all styling
    //   - Only accepts numeric characters (0-9); non-numeric input is rejected
    //   - The length prop is captured at initialization; do not change dynamically
    //   - Uses internal ref for digits array and computed for combined value
    //
    // References:
    //   - WAI-ARIA Group Role: https://www.w3.org/TR/wai-aria-1.2/#group

    import { computed, ref, watchEffect } from "vue";

    const props = withDefaults(defineProps<{
        /** Accessible label for the group of inputs */
        label: string;
        /** Number of digit inputs to render */
        length?: number;
        /** Whether all inputs are disabled */
        disabled?: boolean;
    }>(), {
        length: 4,
        disabled: false,
    });

    const modelValue = defineModel<string>({ default: "" });

    const digits = ref<string[]>(Array.from({ length: props.length }, () => ""));

    const inputRefs = ref<HTMLInputElement[]>([]);

    const combinedValue = computed(() =>
        digits.value.join(""),
    );

    function handleInput(index: number, event: Event): void {
        const target = event.target as HTMLInputElement;
        const inputValue = target.value;

        // Only accept numeric characters
        if (inputValue && !/^[0-9]$/.test(inputValue)) {
            target.value = digits.value[index];
            return;
        }

        // Update the digit in our state array
        digits.value[index] = inputValue;

        // Auto-focus the next input if a digit was entered
        if (inputValue && index < props.length - 1) {
            inputRefs.value[index + 1]?.focus();
        }
    }

    function handleKeydown(index: number, event: KeyboardEvent): void {
        const target = event.target as HTMLInputElement;

        if (event.key === "Backspace") {
            if (!target.value && index > 0) {
                // If current input is empty, move focus to previous and clear it
                inputRefs.value[index - 1]?.focus();
                digits.value[index - 1] = "";
            } else {
                // Clear current input
                digits.value[index] = "";
            }
        } else if (event.key === "ArrowLeft" && index > 0) {
            // Navigate to previous input
            inputRefs.value[index - 1]?.focus();
        } else if (event.key === "ArrowRight" && index < props.length - 1) {
            // Navigate to next input
            inputRefs.value[index + 1]?.focus();
        }
    }

    watchEffect(() => {
        modelValue.value = combinedValue.value;
    });

</script>

<template>
    <!-- PinInputDiv.vue -->
    <div
        class="pin-input-div"
        role="group"
        :aria-label="label"
    >
            <input v-for="index in Array.from({ length: props.length }, (_, i) => i)" :key="index"
                :ref="(el: any) => { if (el) inputRefs[index] = el as HTMLInputElement }"
                type="text"
                inputmode="numeric"
                maxlength="1"
                :aria-label="`Digit ${index + 1} of ${length}`"
                :value="digits[index]"
                :disabled="disabled"
                @input="(e: any) => handleInput(index, e)"
                @keydown="(e: any) => handleKeydown(index, e)"
            />
    </div>
</template>
