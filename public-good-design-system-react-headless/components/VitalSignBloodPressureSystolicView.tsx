// VitalSignBloodPressureSystolicView component
//
// A read-only display of a systolic blood pressure value in millimeters of
// mercury (mmHg). This component renders the numeric value as text content
// inside a span element with appropriate ARIA attributes for accessibility. It
// is the display-only companion to VitalSignBloodPressureSystolicInput, used
// for showing systolic blood pressure readings in patient dashboards, medical
// records, and health monitoring displays.
//
// Props:
//   className — string, optional. CSS class name.
//   value — number, required. Systolic blood pressure value in mmHg.
//   label — string, required. Accessible description via aria-label (e.g., "120 mmHg systolic").
//   ...restProps — additional HTML attributes spread onto the outer span.
//
// Syntax:
//   <VitalSignBloodPressureSystolicView value={120} label="120 mmHg systolic" />
//
// Examples:
//
//   <VitalSignBloodPressureSystolicView value={120} label="120 mmHg systolic" />
//
//
//   <VitalSignBloodPressureSystolicView value={140} label="140 mmHg systolic" />
//
// Keyboard:
//   - None — this is a passive, read-only display element
//
// Accessibility:
//   - role="img" on the outer span indicates it represents a visual/graphic element
//   - aria-label provides the full systolic blood pressure description for screen readers
//   - data-value attribute enables consumer CSS styling based on the value
//
// Internationalization:
//   - The label prop allows localized systolic blood pressure descriptions
//   - No hardcoded user-facing strings
//
// Claude rules:
//   - Headless: no CSS, no styles — consumer provides all styling
//   - Companion to VitalSignBloodPressureSystolicInput for the Input/View pattern
//
// References:
//   - WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/

import React from "react";

export interface VitalSignBloodPressureSystolicViewProps {
    className?: string;
    /** Systolic blood pressure value in mmHg. */
    value: number;
    /** Accessible description. */
    label: string;
    [key: string]: unknown;
}

export default function VitalSignBloodPressureSystolicView({
    className = "",
    value,
    label,
    ...restProps
}: VitalSignBloodPressureSystolicViewProps) {
    return (
        <span
            className={`vital-sign-blood-pressure-systolic-view ${className}`}
            role="img"
            aria-label={label}
            data-value={value}
            {...restProps}
        >
            {value}
        </span>
    );
}
