<script lang="ts">
    // BreadcrumbNavList component
    //
    // An ordered list that contains BreadcrumbNavListItem children, representing
    // the hierarchical trail in a breadcrumb navigation. Renders a semantic
    // <ol> element to convey the ordered relationship of pages. Must be placed
    // inside a BreadcrumbNav container.
    //
    // Props:
    //   className — string, optional. CSS class name.
    //   children — Snippet, required. BreadcrumbNavListItem elements.
    //   ...restProps — additional HTML attributes spread onto the <ol>.
    //
    // Syntax:
    //   <BreadcrumbNavList>
    //     <BreadcrumbNavListItem>...</BreadcrumbNavListItem>
    //   </BreadcrumbNavList>
    //
    // Examples:
    //   <!-- Breadcrumb list inside a nav -->
    //   <BreadcrumbNav label="Breadcrumb">
    //     <BreadcrumbNavList>
    //       <BreadcrumbNavListItem><a href="/">Home</a></BreadcrumbNavListItem>
    //       <BreadcrumbNavListItem><a href="/products">Products</a></BreadcrumbNavListItem>
    //       <BreadcrumbNavListItem current>Widget</BreadcrumbNavListItem>
    //     </BreadcrumbNavList>
    //   </BreadcrumbNav>
    //
    // Keyboard: None — passive container. Keyboard interactions are handled
    // by links within BreadcrumbNavListItem children.
    //
    // Accessibility:
    //   - <ol> conveys the ordered hierarchical relationship of the trail
    //   - Implicit list role allows screen readers to announce item count
    //
    // Internationalization:
    //   - No user-facing strings; all content comes through children
    //   - Separator characters (e.g. "/" or ">") should be added by the consumer
    //
    // Claude rules:
    //   - Compound component — used inside BreadcrumbNav, contains BreadcrumbNavListItem children
    //   - Headless: no CSS, no styles — consumer provides all styling
    //   - Separator characters between items are the consumer's responsibility
    //
    // References:
    //   - WAI-ARIA Breadcrumb Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/breadcrumb/

    import type { Snippet } from "svelte";

    let {
        class: className = "",
        children,
        ...restProps
    }: {
        /** BreadcrumbNavListItem elements. */
        children: Snippet;
        [key: string]: unknown;
    } = $props();
</script>

<!-- BreadcrumbNavList.svelte -->
<ol
    class={`breadcrumb-nav-list ${className}`}
    {...restProps}
>
    {@render children()}
</ol>
