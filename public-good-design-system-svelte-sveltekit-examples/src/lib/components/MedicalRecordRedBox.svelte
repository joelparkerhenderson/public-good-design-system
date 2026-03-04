<script lang="ts">
    // MedicalRecordRedBox component
    //
    // A headless container for critical patient danger information in healthcare
    // applications. It renders an <aside> with role="alert" to immediately announce
    // urgent content to screen readers via an assertive live region. Used for
    // life-threatening allergies, critical safety warnings, and other patient
    // information requiring maximum urgency.
    //
    // Props:
    //   className — string, optional. CSS class name.
    //   label — string, required. Accessible name for the danger box via aria-label.
    //   children — Snippet, required. The danger box content.
    //   ...restProps — additional HTML attributes spread onto the <aside>.
    //
    // Syntax:
    //   <MedicalRecordRedBox label="Critical allergy">...</MedicalRecordRedBox>
    //
    // Examples:
    //   <!-- Life-threatening allergy alert -->
    //   <MedicalRecordRedBox label="Critical allergy">
    //     <p>Patient has a life-threatening allergy to latex.</p>
    //   </MedicalRecordRedBox>
    //
    // Keyboard:
    //   - None — alerts are passive announcements, not interactive elements.
    //     Content within the danger box retains its own keyboard behavior.
    //
    // Accessibility:
    //   - role="alert" creates an assertive live region (equivalent to aria-live="assertive")
    //   - Screen readers immediately interrupt to announce the content
    //   - aria-label provides an accessible name for the alert region
    //
    // Internationalization:
    //   - The label prop accepts any translated string
    //   - All content comes through the children snippet
    //   - No hardcoded user-facing strings
    //
    // Claude rules:
    //   - Headless: no CSS, no styles — consumer provides all styling
    //   - Designed for healthcare applications with critical patient safety data
    //
    // References:
    //   - WAI-ARIA alert role: https://www.w3.org/TR/wai-aria-1.2/#alert
    //   - WAI-ARIA Alert Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/alert/

    import type { Snippet } from "svelte";

    let {
        class: className = "",
        label,
        children,
        ...restProps
    }: {
        /** Accessible name for the danger box */
        label: string;
        /** The danger box content */
        children: Snippet;
        [key: string]: unknown;
    } = $props();
</script>

<!-- MedicalRecordRedBox.svelte -->
<aside
    class={`medica-record-red-box ${className}`}
    role="alert"
    aria-label={label}
    {...restProps}
>
    {@render children()}
</aside>
