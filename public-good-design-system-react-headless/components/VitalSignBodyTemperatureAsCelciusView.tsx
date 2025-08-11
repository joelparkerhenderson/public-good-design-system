// VitalSignBodyTemperatureAsCelciusView component
//
// A read-only display of a body temperature value in degrees Celsius. This
// component renders the numeric value as text content inside a span element with
// appropriate ARIA attributes for accessibility. It is the display-only companion
// to VitalSignBodyTemperatureAsCelciusInput, used for showing body temperature
// readings in patient dashboards, medical records, and health monitoring displays.
//
// Props:
//   className — string, optional. CSS class name.
//   value — number, required. Body temperature value in degrees Celsius.
//   label — string, required. Accessible description via aria-label (e.g., "37.0 degrees Celsius").
//   ...restProps — additional HTML attributes spread onto the outer span.
//
// Syntax:
//   <VitalSignBodyTemperatureAsCelciusView value={37.0} label="37.0 degrees Celsius" />
//
// Examples:
//
//   <VitalSignBodyTemperatureAsCelciusView value={37.0} label="37.0 degrees Celsius" />
//
//
//   <VitalSignBodyTemperatureAsCelciusView value={38.5} label="38.5 degrees Celsius" />
//
// Keyboard:
//   - None — this is a passive, read-only display element
//
// Accessibility:
//   - role="img" on the outer span indicates it represents a visual/graphic element
//   - aria-label provides the full body temperature description for screen readers
//   - data-value attribute enables consumer CSS styling based on the value
//
// Internationalization:
//   - The label prop allows localized body temperature descriptions
//   - No hardcoded user-facing strings
//
// Claude rules:
//   - Headless: no CSS, no styles — consumer provides all styling
//   - Companion to VitalSignBodyTemperatureAsCelciusInput for the Input/View pattern
//
// References:
//   - WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/

import React from "react";

export interface VitalSignBodyTemperatureAsCelciusViewProps {
    className?: string;
    /** Body temperature value in degrees Celsius. */
    value: number;
    /** Accessible description. */
    label: string;
    [key: string]: unknown;
}

export default function VitalSignBodyTemperatureAsCelciusView({
    className = "",
    value,
    label,
    ...restProps
}: VitalSignBodyTemperatureAsCelciusViewProps) {
    return (
        <span
            className={`vital-sign-body-temperature-as-celcius-view ${className}`}
            role="img"
            aria-label={label}
            data-value={value}
            {...restProps}
        >
            {value}
        </span>
    );
}
