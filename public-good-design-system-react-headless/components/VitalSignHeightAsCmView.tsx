// VitalSignHeightAsCmView component
//
// A read-only display of a height value in centimeters (cm). This
// component renders the numeric value as text content inside a span element with
// appropriate ARIA attributes for accessibility. It is the display-only companion
// to VitalSignHeightAsCmInput, used for showing height
// readings in patient dashboards, medical records, and health monitoring displays.
//
// Props:
//   className — string, optional. CSS class name.
//   value — number, required. Height value in centimeters.
//   label — string, required. Accessible description via aria-label (e.g., "175 cm height").
//   ...restProps — additional HTML attributes spread onto the outer span.
//
// Syntax:
//   <VitalSignHeightAsCmView value={175} label="175 cm height" />
//
// Examples:
//
//   <VitalSignHeightAsCmView value={175} label="175 cm height" />
//
//
//   <VitalSignHeightAsCmView value={160} label="160 cm height" />
//
// Keyboard:
//   - None — this is a passive, read-only display element
//
// Accessibility:
//   - role="img" on the outer span indicates it represents a visual/graphic element
//   - aria-label provides the full height description for screen readers
//   - data-value attribute enables consumer CSS styling based on the value
//
// Internationalization:
//   - The label prop allows localized height descriptions
//   - No hardcoded user-facing strings
//
// Claude rules:
//   - Headless: no CSS, no styles — consumer provides all styling
//   - Companion to VitalSignHeightAsCmInput for the Input/View pattern
//
// References:
//   - WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/

import React from "react";

export interface VitalSignHeightAsCmViewProps {
    className?: string;
    /** Height value in centimeters. */
    value: number;
    /** Accessible description. */
    label: string;
    [key: string]: unknown;
}

export default function VitalSignHeightAsCmView({
    className = "",
    value,
    label,
    ...restProps
}: VitalSignHeightAsCmViewProps) {
    return (
        <span
            className={`vital-sign-height-as-cm-view ${className}`}
            role="img"
            aria-label={label}
            data-value={value}
            {...restProps}
        >
            {value}
        </span>
    );
}
