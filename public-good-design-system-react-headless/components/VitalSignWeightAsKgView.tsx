// VitalSignWeightAsKgView component
//
// A read-only display of a weight value in kilograms (kg). This
// component renders the numeric value as text content inside a span element with
// appropriate ARIA attributes for accessibility. It is the display-only companion
// to VitalSignWeightAsKgInput, used for showing weight
// readings in patient dashboards, medical records, and health monitoring displays.
//
// Props:
//   className — string, optional. CSS class name.
//   value — number, required. Weight value in kilograms.
//   label — string, required. Accessible description via aria-label (e.g., "75 kg weight").
//   ...restProps — additional HTML attributes spread onto the outer span.
//
// Syntax:
//   <VitalSignWeightAsKgView value={75} label="75 kg weight" />
//
// Examples:
//
//   <VitalSignWeightAsKgView value={75} label="75 kg weight" />
//
//
//   <VitalSignWeightAsKgView value={60} label="60 kg weight" />
//
// Keyboard:
//   - None — this is a passive, read-only display element
//
// Accessibility:
//   - role="img" on the outer span indicates it represents a visual/graphic element
//   - aria-label provides the full weight description for screen readers
//   - data-value attribute enables consumer CSS styling based on the value
//
// Internationalization:
//   - The label prop allows localized weight descriptions
//   - No hardcoded user-facing strings
//
// Claude rules:
//   - Headless: no CSS, no styles — consumer provides all styling
//   - Companion to VitalSignWeightAsKgInput for the Input/View pattern
//
// References:
//   - WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/

import React from "react";

export interface VitalSignWeightAsKgViewProps {
    className?: string;
    /** Weight value in kilograms. */
    value: number;
    /** Accessible description. */
    label: string;
    [key: string]: unknown;
}

export default function VitalSignWeightAsKgView({
    className = "",
    value,
    label,
    ...restProps
}: VitalSignWeightAsKgViewProps) {
    return (
        <span
            className={`vital-sign-weight-as-kg-view ${className}`}
            role="img"
            aria-label={label}
            data-value={value}
            {...restProps}
        >
            {value}
        </span>
    );
}
