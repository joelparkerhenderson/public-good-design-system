// VitalSignBloodPressureDiastolicAsMmhgView component
//
// A read-only display of a diastolic blood pressure value in millimeters of
// mercury (mmHg). This component renders the numeric value as text content
// inside a span element with appropriate ARIA attributes for accessibility. It
// is the display-only companion to VitalSignBloodPressureDiastolicAsMmhgInput, used
// for showing diastolic blood pressure readings in patient dashboards, medical
// records, and health monitoring displays.
//
// Props:
//   className — string, optional. CSS class name.
//   value — number, required. Diastolic blood pressure value in mmHg.
//   label — string, required. Accessible description via aria-label (e.g., "80 mmHg diastolic").
//   ...restProps — additional HTML attributes spread onto the outer span.
//
// Syntax:
//   <VitalSignBloodPressureDiastolicAsMmhgView value={80} label="80 mmHg diastolic" />
//
// Examples:
//
//   <VitalSignBloodPressureDiastolicAsMmhgView value={80} label="80 mmHg diastolic" />
//
//
//   <VitalSignBloodPressureDiastolicAsMmhgView value={90} label="90 mmHg diastolic" />
//
// Keyboard:
//   - None — this is a passive, read-only display element
//
// Accessibility:
//   - role="img" on the outer span indicates it represents a visual/graphic element
//   - aria-label provides the full diastolic blood pressure description for screen readers
//   - data-value attribute enables consumer CSS styling based on the value
//
// Internationalization:
//   - The label prop allows localized diastolic blood pressure descriptions
//   - No hardcoded user-facing strings
//
// Claude rules:
//   - Headless: no CSS, no styles — consumer provides all styling
//   - Companion to VitalSignBloodPressureDiastolicAsMmhgInput for the Input/View pattern
//
// References:
//   - WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/

import React from "react";

export interface VitalSignBloodPressureDiastolicAsMmhgViewProps {
    className?: string;
    /** Diastolic blood pressure value in mmHg. */
    value: number;
    /** Accessible description. */
    label: string;
    [key: string]: unknown;
}

export default function VitalSignBloodPressureDiastolicAsMmhgView({
    className = "",
    value,
    label,
    ...restProps
}: VitalSignBloodPressureDiastolicAsMmhgViewProps) {
    return (
        <span
            className={`vital-sign-blood-pressure-diastolic-as-mmhg-view ${className}`}
            role="img"
            aria-label={label}
            data-value={value}
            {...restProps}
        >
            {value}
        </span>
    );
}
