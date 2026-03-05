// VitalSignWaistCircumferenceCmView component
//
// A read-only display of a waist circumference value in centimeters (cm). This
// component renders the numeric value as text content inside a span element with
// appropriate ARIA attributes for accessibility. It is the display-only companion
// to VitalSignWaistCircumferenceCmInput, used for showing waist circumference
// readings in patient dashboards, medical records, and health monitoring displays.
//
// Props:
//   className — string, optional. CSS class name.
//   value — number, required. Waist circumference value in centimeters.
//   label — string, required. Accessible description via aria-label (e.g., "94 cm waist circumference").
//   ...restProps — additional HTML attributes spread onto the outer span.
//
// Syntax:
//   <VitalSignWaistCircumferenceCmView value={94} label="94 cm waist circumference" />
//
// Examples:
//
//   <VitalSignWaistCircumferenceCmView value={94} label="94 cm waist circumference" />
//
//
//   <VitalSignWaistCircumferenceCmView value={80} label="80 cm waist circumference" />
//
// Keyboard:
//   - None — this is a passive, read-only display element
//
// Accessibility:
//   - role="img" on the outer span indicates it represents a visual/graphic element
//   - aria-label provides the full waist circumference description for screen readers
//   - data-value attribute enables consumer CSS styling based on the value
//
// Internationalization:
//   - The label prop allows localized waist circumference descriptions
//   - No hardcoded user-facing strings
//
// Claude rules:
//   - Headless: no CSS, no styles — consumer provides all styling
//   - Companion to VitalSignWaistCircumferenceCmInput for the Input/View pattern
//
// References:
//   - WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/

import React from "react";

export interface VitalSignWaistCircumferenceCmViewProps {
    className?: string;
    /** Waist circumference value in centimeters. */
    value: number;
    /** Accessible description. */
    label: string;
    [key: string]: unknown;
}

export default function VitalSignWaistCircumferenceCmView({
    className = "",
    value,
    label,
    ...restProps
}: VitalSignWaistCircumferenceCmViewProps) {
    return (
        <span
            className={`vital-sign-waist-circumference-cm-view ${className}`}
            role="img"
            aria-label={label}
            data-value={value}
            {...restProps}
        >
            {value}
        </span>
    );
}
