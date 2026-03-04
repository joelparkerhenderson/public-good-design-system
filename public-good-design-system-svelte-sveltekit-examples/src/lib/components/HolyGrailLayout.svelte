<script lang="ts">
    // HolyGrailLayout component
    //
    // The Holy Grail layout is a classic web design pattern featuring a header, footer,
    // main content area, and two sidebars. This component provides a minimal wrapper <div>
    // that expects consumers to supply semantic HTML landmark elements as children. All
    // layout positioning and visual arrangement is the consumer's responsibility via CSS.
    //
    // Props:
    //   className — string, optional. CSS class name.
    //   children — Snippet, required. Layout content, typically header, nav, main, aside, and footer elements.
    //   ...restProps — additional HTML attributes spread onto the wrapper div.
    //
    // Syntax:
    //   <HolyGrailLayout>{children}</HolyGrailLayout>
    //
    // Examples:
    //   <!-- Standard holy grail layout with semantic landmarks -->
    //   <HolyGrailLayout>
    //     <header>Site Header</header>
    //     <nav>Navigation</nav>
    //     <main>Main Content</main>
    //     <aside>Sidebar</aside>
    //     <footer>Site Footer</footer>
    //   </HolyGrailLayout>
    //
    // Keyboard:
    //   - None — this is a passive container; navigation between landmarks is handled by assistive technology
    //
    // Accessibility:
    //   - No explicit ARIA attributes added by this component
    //   - Accessibility is achieved through semantic HTML landmark elements provided by the consumer
    //   - Consumer should use <header>, <nav>, <main>, <aside>, and <footer> for proper landmark navigation
    //
    // Internationalization:
    //   - No user-facing strings; all content comes through the children snippet
    //
    // Claude rules:
    //   - Headless: no CSS, no styles — consumer provides all styling and layout (CSS Grid, Flexbox, etc.)
    //   - Intentionally minimal; serves as a structural container only
    //   - Consumer must supply semantic HTML landmark elements as children
    //
    // References:
    //   - WAI-ARIA Landmark Regions: https://www.w3.org/WAI/ARIA/apd/practices/landmark-regions/
    //   - HTML Landmarks: https://www.w3.org/WAI/tutorials/page-structure/regions/

    import type { Snippet } from "svelte";

    let {
        class: className = "",
        children,
        ...restProps
    }: {
        children: Snippet;
        [key: string]: unknown;
    } = $props();
</script>

<!-- HolyGrailLayout.svelte -->
<div
    class={`holy-grail-layout ${className}`}
    {...restProps}
>
    {@render children()}
</div>
