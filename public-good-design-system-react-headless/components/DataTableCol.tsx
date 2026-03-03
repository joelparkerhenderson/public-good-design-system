// DataTableCol component
//
// A column definition within a DataTable, rendered as a <col> element.
// Used inside a <colgroup> to define column properties such as span.
// Useful for styling entire columns of the data table.
//
// Props:
//   className — string, optional. CSS class name.
//   span — number, optional. Number of columns this <col> spans.
//   ...restProps — additional HTML attributes spread onto the <col>.
//
// Syntax:
//   <colgroup>
//     <DataTableCol />
//     <DataTableCol span={3} />
//   </colgroup>
//
// Keyboard:
//   None — <col> is not interactive.
//
// Accessibility:
//   - <col> provides structural column semantics for the table
//
// Claude rules:
//   - Headless: no CSS, no styles — consumer provides all styling
//   - Must be used inside a <colgroup> within a DataTable
//   - No internal state — purely a structural element
//
// References:
//   - HTML col element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/col

import React from "react";

export interface DataTableColProps {
    className?: string;
    /** Number of columns this col spans. */
    span?: number;
    [key: string]: unknown;
}

export default function DataTableCol({
    className = "",
    span,
    ...restProps
}: DataTableColProps) {
    return (
        <col
        className={`data-table-col ${className}`}
        span={span || undefined}
        {...restProps}
        />
    );
}
