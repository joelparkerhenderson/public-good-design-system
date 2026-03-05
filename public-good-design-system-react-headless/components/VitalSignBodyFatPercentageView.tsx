// VitalSignBodyFatPercentageView component
//
// A read-only display of a body fat percentage value. This component renders the
// numeric value as text content inside a span element with appropriate ARIA
// attributes for accessibility. It is the display-only companion to
// VitalSignBodyFatPercentageInput, used for showing body fat percentage readings
// in patient dashboards, fitness tracking applications, and health monitoring displays.
//
// Props:
//   className — string, optional. CSS class name.
//   value — number, required. Body fat percentage value.
//   label — string, required. Accessible description via aria-label (e.g., "22.5 percent body fat").
//   ...restProps — additional HTML attributes spread onto the outer span.
//
// Syntax:
//   <VitalSignBodyFatPercentageView value={22.5} label="22.5 percent body fat" />
//
// Examples:
//
//   <VitalSignBodyFatPercentageView value={22.5} label="22.5 percent body fat" />
//
//
//   <VitalSignBodyFatPercentageView value={15.0} label="15.0 percent body fat" />
//
// Keyboard:
//   - None — this is a passive, read-only display element
//
// Accessibility:
//   - role="img" on the outer span indicates it represents a visual/graphic element
//   - aria-label provides the full body fat percentage description for screen readers
//   - data-value attribute enables consumer CSS styling based on the value
//
// Internationalization:
//   - The label prop allows localized body fat percentage descriptions
//   - No hardcoded user-facing strings
//
// Claude rules:
//   - Headless: no CSS, no styles — consumer provides all styling
//   - Companion to VitalSignBodyFatPercentageInput for the Input/View pattern
//
// References:
//   - WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/

import React from "react";

export interface VitalSignBodyFatPercentageViewProps {
    className?: string;
    /** Body fat percentage value. */
    value: number;
    /** Accessible description. */
    label: string;
    [key: string]: unknown;
}

export default function VitalSignBodyFatPercentageView({
    className = "",
    value,
    label,
    ...restProps
}: VitalSignBodyFatPercentageViewProps) {
    return (
        <span
            className={`vital-sign-body-fat-percentage-view ${className}`}
            role="img"
            aria-label={label}
            data-value={value}
            {...restProps}
        >
            {value}
        </span>
    );
}
