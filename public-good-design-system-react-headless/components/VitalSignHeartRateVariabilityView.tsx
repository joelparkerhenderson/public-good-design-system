// VitalSignHeartRateVariabilityView component
//
// A read-only display of a heart rate variability (HRV) value in milliseconds.
// This component renders the numeric value as text content inside a span element
// with appropriate ARIA attributes for accessibility. It is the display-only
// companion to VitalSignHeartRateVariabilityInput, used for showing HRV readings
// in patient dashboards, medical records, and health monitoring displays.
//
// Props:
//   className — string, optional. CSS class name.
//   value — number, required. Heart rate variability value in milliseconds.
//   label — string, required. Accessible description via aria-label (e.g., "45 milliseconds HRV").
//   ...restProps — additional HTML attributes spread onto the outer span.
//
// Syntax:
//   <VitalSignHeartRateVariabilityView value={45} label="45 milliseconds HRV" />
//
// Examples:
//
//   <VitalSignHeartRateVariabilityView value={45} label="45 milliseconds HRV" />
//
//
//   <VitalSignHeartRateVariabilityView value={100} label="100 milliseconds HRV" />
//
// Keyboard:
//   - None — this is a passive, read-only display element
//
// Accessibility:
//   - role="img" on the outer span indicates it represents a visual/graphic element
//   - aria-label provides the full HRV description for screen readers
//   - data-value attribute enables consumer CSS styling based on the value
//
// Internationalization:
//   - The label prop allows localized HRV descriptions
//   - No hardcoded user-facing strings
//
// Claude rules:
//   - Headless: no CSS, no styles — consumer provides all styling
//   - Companion to VitalSignHeartRateVariabilityInput for the Input/View pattern
//
// References:
//   - WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/

import React from "react";

export interface VitalSignHeartRateVariabilityViewProps {
    className?: string;
    /** Heart rate variability value in milliseconds. */
    value: number;
    /** Accessible description. */
    label: string;
    [key: string]: unknown;
}

export default function VitalSignHeartRateVariabilityView({
    className = "",
    value,
    label,
    ...restProps
}: VitalSignHeartRateVariabilityViewProps) {
    return (
        <span
            className={`vital-sign-heart-rate-variability-view ${className}`}
            role="img"
            aria-label={label}
            data-value={value}
            {...restProps}
        >
            {value}
        </span>
    );
}
