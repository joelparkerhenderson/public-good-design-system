// VitalSignHeartRateBeatsPerMinuteView component
//
// A read-only display of a heart rate value in beats per minute (BPM). This
// component renders the numeric value as text content inside a span element with
// appropriate ARIA attributes for accessibility. It is the display-only companion
// to VitalSignHeartRateBeatsPerMinuteInput, used for showing heart rate readings
// in patient dashboards, medical records, and health monitoring displays.
//
// Props:
//   className — string, optional. CSS class name.
//   value — number, required. Heart rate value in beats per minute.
//   label — string, required. Accessible description via aria-label (e.g., "Heart rate: 72 BPM").
//   ...restProps — additional HTML attributes spread onto the outer span.
//
// Syntax:
//   <VitalSignHeartRateBeatsPerMinuteView value={72} label="Heart rate: 72 BPM" />
//
// Examples:
//
//   <VitalSignHeartRateBeatsPerMinuteView value={72} label="Heart rate: 72 BPM" />
//
//
//   <VitalSignHeartRateBeatsPerMinuteView value={100} label="Heart rate: 100 BPM" />
//
// Keyboard:
//   - None — this is a passive, read-only display element
//
// Accessibility:
//   - role="img" on the outer span indicates it represents a visual/graphic element
//   - aria-label provides the full heart rate description for screen readers
//   - data-value attribute enables consumer CSS styling based on the value
//
// Internationalization:
//   - The label prop allows localized heart rate descriptions
//   - No hardcoded user-facing strings
//
// Claude rules:
//   - Headless: no CSS, no styles — consumer provides all styling
//   - Companion to VitalSignHeartRateBeatsPerMinuteInput for the Input/View pattern
//
// References:
//   - WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/

import React from "react";

export interface VitalSignHeartRateBeatsPerMinuteViewProps {
    className?: string;
    /** Heart rate value in beats per minute. */
    value: number;
    /** Accessible description. */
    label: string;
    [key: string]: unknown;
}

export default function VitalSignHeartRateBeatsPerMinuteView({
    className = "",
    value,
    label,
    ...restProps
}: VitalSignHeartRateBeatsPerMinuteViewProps) {
    return (
        <span
            className={`vital-sign-heart-rate-beats-per-minute-view ${className}`}
            role="img"
            aria-label={label}
            data-value={value}
            {...restProps}
        >
            {value}
        </span>
    );
}
