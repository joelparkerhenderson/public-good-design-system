// VitalSignCholesterolAsHdlMmolPerLitreView component
//
// A read-only display of an HDL cholesterol value in millimoles per litre. This
// component renders the numeric value as text content inside a span element with
// appropriate ARIA attributes for accessibility. It is the display-only companion
// to VitalSignCholesterolAsHdlMmolPerLitreInput, used for showing HDL cholesterol
// readings in patient dashboards, medical records, and health monitoring displays.
//
// Props:
//   className — string, optional. CSS class name.
//   value — number, required. HDL cholesterol value in mmol/L.
//   label — string, required. Accessible description via aria-label (e.g., "1.5 mmol/L HDL cholesterol").
//   ...restProps — additional HTML attributes spread onto the outer span.
//
// Syntax:
//   <VitalSignCholesterolAsHdlMmolPerLitreView value={1.5} label="1.5 mmol/L HDL cholesterol" />
//
// Examples:
//
//   <VitalSignCholesterolAsHdlMmolPerLitreView value={1.5} label="1.5 mmol/L HDL cholesterol" />
//
//
//   <VitalSignCholesterolAsHdlMmolPerLitreView value={2.0} label="2.0 mmol/L HDL cholesterol" />
//
// Keyboard:
//   - None — this is a passive, read-only display element
//
// Accessibility:
//   - role="img" on the outer span indicates it represents a visual/graphic element
//   - aria-label provides the full HDL cholesterol description for screen readers
//   - data-value attribute enables consumer CSS styling based on the value
//
// Internationalization:
//   - The label prop allows localized HDL cholesterol descriptions
//   - No hardcoded user-facing strings
//
// Claude rules:
//   - Headless: no CSS, no styles — consumer provides all styling
//   - Companion to VitalSignCholesterolAsHdlMmolPerLitreInput for the Input/View pattern
//
// References:
//   - WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/

import React from "react";

export interface VitalSignCholesterolAsHdlMmolPerLitreViewProps {
    className?: string;
    /** HDL cholesterol value in mmol/L. */
    value: number;
    /** Accessible description. */
    label: string;
    [key: string]: unknown;
}

export default function VitalSignCholesterolAsHdlMmolPerLitreView({
    className = "",
    value,
    label,
    ...restProps
}: VitalSignCholesterolAsHdlMmolPerLitreViewProps) {
    return (
        <span
            className={`vital-sign-cholesterol-as-hdl-mmol-per-litre-view ${className}`}
            role="img"
            aria-label={label}
            data-value={value}
            {...restProps}
        >
            {value}
        </span>
    );
}
