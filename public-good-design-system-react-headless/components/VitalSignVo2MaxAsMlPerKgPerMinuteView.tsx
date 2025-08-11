// VitalSignVO2MaxMlPerKgPerMinuteView component
//
// A read-only display of a VO2 max value in milliliters per kilogram per minute
// (ml/kg/min). This component renders the numeric value as text content inside a
// span element with appropriate ARIA attributes for accessibility. It is the
// display-only companion to VitalSignVO2MaxMlPerKgPerMinuteInput, used for
// showing VO2 max readings in patient dashboards, fitness assessments, and
// health monitoring displays.
//
// Props:
//   className — string, optional. CSS class name.
//   value — number, required. VO2 max value in ml/kg/min.
//   label — string, required. Accessible description via aria-label (e.g., "42 ml/kg/min VO2 max").
//   ...restProps — additional HTML attributes spread onto the outer span.
//
// Syntax:
//   <VitalSignVO2MaxMlPerKgPerMinuteView value={42} label="42 ml/kg/min VO2 max" />
//
// Examples:
//
//   <VitalSignVO2MaxMlPerKgPerMinuteView value={42} label="42 ml/kg/min VO2 max" />
//
//
//   <VitalSignVO2MaxMlPerKgPerMinuteView value={55} label="55 ml/kg/min VO2 max" />
//
// Keyboard:
//   - None — this is a passive, read-only display element
//
// Accessibility:
//   - role="img" on the outer span indicates it represents a visual/graphic element
//   - aria-label provides the full VO2 max description for screen readers
//   - data-value attribute enables consumer CSS styling based on the value
//
// Internationalization:
//   - The label prop allows localized VO2 max descriptions
//   - No hardcoded user-facing strings
//
// Claude rules:
//   - Headless: no CSS, no styles — consumer provides all styling
//   - Companion to VitalSignVO2MaxMlPerKgPerMinuteInput for the Input/View pattern
//
// References:
//   - WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/

import React from "react";

export interface VitalSignVO2MaxMlPerKgPerMinuteViewProps {
    className?: string;
    /** VO2 max value in ml/kg/min. */
    value: number;
    /** Accessible description. */
    label: string;
    [key: string]: unknown;
}

export default function VitalSignVO2MaxMlPerKgPerMinuteView({
    className = "",
    value,
    label,
    ...restProps
}: VitalSignVO2MaxMlPerKgPerMinuteViewProps) {
    return (
        <span
            className={`vital-sign-vo2-max-as-ml-per-kg-per-minute-view ${className}`}
            role="img"
            aria-label={label}
            data-value={value}
            {...restProps}
        >
            {value}
        </span>
    );
}
