import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./TabBarButton.svelte";

// Helper to create a Svelte 5 snippet for children content.
function textSnippet(text: string) {
    return (($$anchor: Comment) => {
        const node = document.createTextNode(text);
        $$anchor.before(node);
    }) as any;
}

describe("TabBarButton", () => {
    test("renders a button with tab role", () => {
        render(Subject, { props: {
            controls: "panel-1",
            children: textSnippet("Dashboard"),
        }});

        const tab = screen.getByRole("tab");
        expect(tab.tagName).toBe("BUTTON");
    });

    test("displays children content", () => {
        render(Subject, { props: {
            controls: "panel-1",
            children: textSnippet("Settings"),
        }});

        const tab = screen.getByRole("tab");
        expect(tab.textContent).toContain("Settings");
    });

    test("is not selected by default", () => {
        render(Subject, { props: {
            controls: "panel-1",
            children: textSnippet("TabBarButton"),
        }});

        const tab = screen.getByRole("tab");
        expect(tab.getAttribute("aria-selected")).toBe("false");
    });

    test("reflects selected state when true", () => {
        render(Subject, { props: {
            selected: true,
            controls: "panel-1",
            children: textSnippet("TabBarButton"),
        }});

        const tab = screen.getByRole("tab");
        expect(tab.getAttribute("aria-selected")).toBe("true");
    });

    test("has aria-controls pointing to panel id", () => {
        render(Subject, { props: {
            controls: "settings-panel",
            children: textSnippet("Settings"),
        }});

        const tab = screen.getByRole("tab");
        expect(tab.getAttribute("aria-controls")).toBe("settings-panel");
    });

    test("has tabindex 0 when selected", () => {
        render(Subject, { props: {
            selected: true,
            controls: "panel-1",
            children: textSnippet("TabBarButton"),
        }});

        const tab = screen.getByRole("tab");
        expect(tab.getAttribute("tabindex")).toBe("0");
    });

    test("has tabindex -1 when not selected", () => {
        render(Subject, { props: {
            selected: false,
            controls: "panel-1",
            children: textSnippet("TabBarButton"),
        }});

        const tab = screen.getByRole("tab");
        expect(tab.getAttribute("tabindex")).toBe("-1");
    });

    test("passes through additional HTML attributes", () => {
        render(Subject, { props: {
            controls: "panel-1",
            "data-testid": "my-tab",
            children: textSnippet("TabBarButton"),
        }});

        const tab = screen.getByTestId("my-tab");
        expect(tab).toBeTruthy();
    });

    test("passes through id attribute", () => {
        render(Subject, { props: {
            controls: "panel-1",
            id: "tab-1",
            children: textSnippet("TabBarButton"),
        }});

        const tab = screen.getByRole("tab");
        expect(tab.getAttribute("id")).toBe("tab-1");
    });
});
