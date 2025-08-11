// VitalSignWaistCircumferenceAsCmInput component
//
// A headless numeric input for entering a waist circumference value in
// centimeters (cm). Wraps a native <input type="number"> element with accessible
// labelling and physiologically appropriate min, max, and step constraints. It
// provides a controlled numeric value for two-way data flow. Commonly used in
// patient intake forms, health monitoring applications, and medical record entry.
//
// Props:
//   className — string, optional. CSS class name.
//   label — string, required. Accessible name for the input via aria-label.
//   value — number | undefined, default undefined. Current waist circumference value; controlled.
//   min — number, default 0. Minimum allowed value.
//   max — number, default 300. Maximum allowed value.
//   step — number, default 1. Increment/decrement step size.
//   required — boolean, default false. Whether the input is required.
//   disabled — boolean, default false. Whether the input is disabled.
//   onChange — callback, optional. Called with the new numeric value on change.
//   ...restProps — additional HTML attributes spread onto the <input>.
//
// Syntax:
//   <VitalSignWaistCircumferenceAsCmInput label="Waist circumference (cm)" value={value} onChange={setValue} />
//
// Examples:
//
//   <VitalSignWaistCircumferenceAsCmInput label="Waist circumference (cm)" value={value} onChange={setValue} />
//
//
//   <VitalSignWaistCircumferenceAsCmInput label="Waist circumference (cm)" value={value} onChange={setValue} required />
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
//   - Uses controlled pattern for value
//   - Do not wrap in a <div> — renders a bare <input> element
//
// References:
//   - HTML number input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number
//   - WAI-ARIA spinbutton role: https://www.w3.org/TR/wai-aria-1.2/#spinbutton

import React from "react";

export interface VitalSignWaistCircumferenceAsCmInputProps {
    className?: string;
    label: string;
    value?: number | undefined;
    min?: number;
    max?: number;
    step?: number;
    required?: boolean;
    disabled?: boolean;
    /** Callback when value changes. */
    onChange?: (value: number | undefined) => void;
    [key: string]: unknown;
}

export default function VitalSignWaistCircumferenceAsCmInput({
    className = "",
    label,
    value = undefined,
    min = 0,
    max = 300,
    step = 1,
    required = false,
    disabled = false,
    onChange,
    ...restProps
}: VitalSignWaistCircumferenceAsCmInputProps) {
    return (
        <input
            className={`vital-sign-waist-circumference-as-cm-input ${className}`}
            type="number"
            aria-label={label}
            value={value}
            onChange={(e) => onChange?.(Number(e.target.value))}
            min={min}
            max={max}
            step={step}
            required={required}
            disabled={disabled}
            {...restProps}
        />
    );
}
