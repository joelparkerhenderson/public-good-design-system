// BreadcrumbNavListItem component
//
// A single step in a breadcrumb navigation trail. Renders as a semantic <li>
// element designed to be placed inside a BreadcrumbNavList component. Supports
// aria-current="page" to indicate the user's current location. Typically
// contains a link for ancestor pages, or plain text for the current page.
//
// Props:
//   className — string, optional. CSS class name.
//   current — boolean, default false. Whether this item represents the current page.
//   children — ReactNode, required. Breadcrumb content, typically an <a> link or plain text.
//   ...restProps — additional HTML attributes spread onto the <li>.
//
// Syntax:
//   <BreadcrumbNavListItem><a href="/">Home</a></BreadcrumbNavListItem>
//
// Examples:
//   
//   <BreadcrumbNavListItem><a href="/products">Products</a></BreadcrumbNavListItem>
//
//   
//   <BreadcrumbNavListItem current>About</BreadcrumbNavListItem>
//
// Keyboard:
//   None directly — keyboard interaction is handled by the contained links.
//
// Accessibility:
//   - Implicit listitem role from the semantic <li> element
//   - aria-current="page" set when current is true, indicating the user's location
//
// Internationalization:
//   - All text comes through children prop; no hardcoded strings
//
// Claude rules:
//   - Headless: no CSS, no styles — consumer provides all styling
//   - Compound component: must be used inside a BreadcrumbNavList
//
// References:
//   - WAI-ARIA Breadcrumb Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/breadcrumb/

import React from "react";

export interface BreadcrumbNavListItemProps {
    className?: string;
    /** Whether this is the current page. */
    current?: boolean;
    /** Breadcrumb content. */
    children: React.ReactNode;
    [key: string]: unknown;
}

export default function BreadcrumbNavListItem({
    className = "",
    current = false,
    children,
    ...restProps
}: BreadcrumbNavListItemProps) {
    return (
        <li
        className={`breadcrumb-nav-list-item ${className}`}
        aria-current={current ? "page" : undefined}
        {...restProps}
        >
        {children}
        </li>
    );
}
