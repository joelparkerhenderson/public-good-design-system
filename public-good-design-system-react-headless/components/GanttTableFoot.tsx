// GanttTableFoot component
//
// The footer section of a GanttTable, rendered as a <tfoot> element.
// Contains GanttTableRow elements with summary or aggregate data cells.
//
// Props:
//   className — string, optional. CSS class name.
//   children — ReactNode, required. GanttTableRow elements with footer cells.
//   ...restProps — additional HTML attributes spread onto the <tfoot>.
//
// Syntax:
//   <GanttTableFoot>
//     <GanttTableRow>
//       <GanttTableData>Total: 12 tasks</GanttTableData>
//     </GanttTableRow>
//   </GanttTableFoot>
//
// Keyboard:
//   None built-in — keyboard navigation handled at the GanttTable grid level.
//
// Accessibility:
//   - <tfoot> provides structural footer semantics for the table
//
// Claude rules:
//   - Headless: no CSS, no styles — consumer provides all styling
//   - Must be used inside a GanttTable
//   - No internal state — purely a structural wrapper
//
// References:
//   - HTML tfoot element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/tfoot

import React from "react";

export interface GanttTableFootProps {
    className?: string;
    /** GanttTableRow elements with footer cells. */
    children: React.ReactNode;
    [key: string]: unknown;
}

export default function GanttTableFoot({
    className = "",
    children,
    ...restProps
}: GanttTableFootProps) {
    return (
        <tfoot
        className={`gantt-table-foot ${className}`}
        {...restProps}
        >
        {children}
        </tfoot>
    );
}
