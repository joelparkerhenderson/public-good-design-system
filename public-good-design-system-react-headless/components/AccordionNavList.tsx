// AccordionNavList component
//
// AccordionNavList elements within an AccordionNav. Provides an optional
// accessible label for the list.
//
// Props:
//   className — string, optional. CSS class name.
//   label — string, optional. Accessible name for the group via aria-label.
//   children — ReactNode, required. AccordionNavListItem elements.
//   ...restProps — additional HTML attributes spread onto the <div>.
//
// Syntax:
//   <AccordionNav>
//     <AccordionNavList>
//       <AccordionNavListItem>...</AccordionNavListItem>
//     </AccordionNavList>
//   </AccordionNav>
//
// Examples:
//   <AccordionNav label="My Nav">
//     <AccordionNavList label="Questions">
//       <AccordionNavListItem>
//         <summary>What is this?</summary>
//         <p>A design system.</p>
//       </AccordionNavListItem>
//     </AccordionNavList>
//  </AccordionNav>
//
// Keyboard: None — passive container. Keyboard interactions are handled
// by AccordionNavListItem children.
//
// Accessibility:
//   - aria-label optionally provides an accessible name for the group
//
// Internationalization:
//   - The label prop accepts any translated string
//   - No hardcoded text
//
// Claude rules:
//   - Compound component — used inside AccordionNav, contains AccordionNavListItem children
//   - Headless: no CSS, no styles — consumer provides all styling
//
// References:
//   - WAI-ARIA group role: https://www.w3.org/TR/wai-aria-1.2/#group

import React from "react";

export interface AccordionNavListProps {
    className?: string;
    /** Optional accessible label for the group. */
    label?: string;
    /** AccordionNavListItem elements. */
    children: React.ReactNode;
    [key: string]: unknown;
}

export default function AccordionNavList({
    className = "",
    label = "",
    children,
    ...restProps
}: AccordionNavListProps) {
    return (
        <ol
        className={`accordion-nav-list ${className}`}
        role="group"
        aria-label={label || undefined}
        {...restProps}
        >
        {children}
        </ol>
    );
}
