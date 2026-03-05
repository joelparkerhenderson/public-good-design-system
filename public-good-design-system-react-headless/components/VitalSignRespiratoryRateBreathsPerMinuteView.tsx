// VitalSignRespiratoryRateBreathsPerMinuteView component
//
// A read-only display of a respiratory rate value in breaths per minute. This
// component renders the numeric value as text content inside a span element with
// appropriate ARIA attributes for accessibility. It is the display-only companion
// to VitalSignRespiratoryRateBreathsPerMinuteInput, used for showing respiratory
// rate readings in patient dashboards, medical records, and health monitoring
// displays.
//
// Props:
//   className — string, optional. CSS class name.
//   value — number, required. Respiratory rate value in breaths per minute.
//   label — string, required. Accessible description via aria-label (e.g., "16 breaths per minute").
//   ...restProps — additional HTML attributes spread onto the outer span.
//
// Syntax:
//   <VitalSignRespiratoryRateBreathsPerMinuteView value={16} label="16 breaths per minute" />
//
// Examples:
//
//   <VitalSignRespiratoryRateBreathsPerMinuteView value={16} label="16 breaths per minute" />
//
//
//   <VitalSignRespiratoryRateBreathsPerMinuteView value={20} label="20 breaths per minute" />
//
// Keyboard:
//   - None — this is a passive, read-only display element
//
// Accessibility:
//   - role="img" on the outer span indicates it represents a visual/graphic element
//   - aria-label provides the full respiratory rate description for screen readers
//   - data-value attribute enables consumer CSS styling based on the value
//
// Internationalization:
//   - The label prop allows localized respiratory rate descriptions
//   - No hardcoded user-facing strings
//
// Claude rules:
//   - Headless: no CSS, no styles — consumer provides all styling
//   - Companion to VitalSignRespiratoryRateBreathsPerMinuteInput for the Input/View pattern
//
// References:
//   - WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/

import React from "react";

export interface VitalSignRespiratoryRateBreathsPerMinuteViewProps {
    className?: string;
    /** Respiratory rate value in breaths per minute. */
    value: number;
    /** Accessible description. */
    label: string;
    [key: string]: unknown;
}

export default function VitalSignRespiratoryRateBreathsPerMinuteView({
    className = "",
    value,
    label,
    ...restProps
}: VitalSignRespiratoryRateBreathsPerMinuteViewProps) {
    return (
        <span
            className={`vital-sign-respiratory-rate-breaths-per-minute-view ${className}`}
            role="img"
            aria-label={label}
            data-value={value}
            {...restProps}
        >
            {value}
        </span>
    );
}
