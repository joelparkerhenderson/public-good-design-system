<script setup lang="ts">

    // AccordionNavList component
    //
    // AccordionNavList elements within an AccordionNav. Provides an optional
    // accessible label for the list.
    //
    // Props:
    //   className — string, optional. CSS class name.
    //   label — string, optional. Accessible name for the group via aria-label.
    //   default slot. AccordionNavListItem elements.
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

    withDefaults(defineProps<{
        /** Optional accessible label for the group. */
        label?: string;
    }>(), {
        label: "",
    });

</script>

<template>
    <!-- AccordionNavList.vue -->
    <ol
        class="accordion-nav-list"
        role="group"
        :aria-label="label || undefined"
    >
        <slot />
    </ol>
</template>
