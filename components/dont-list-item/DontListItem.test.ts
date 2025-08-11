import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./DontListItem.svelte";

function textSnippet(text: string) {
    return (($$anchor: Comment) => {
        const node = document.createTextNode(text);
        $$anchor.before(node);
    }) as any;
}

describe("DontListItem", () => {
    test("renders a list item element", () => {
        render(Subject, { props: {
            children: textSnippet("Skip alt text"),
        }});

        const item = screen.getByRole("listitem");
        expect(item.tagName).toBe("LI");
    });

    test("renders children content", () => {
        render(Subject, { props: {
            children: textSnippet("Use only color for meaning"),
        }});

        const item = screen.getByRole("listitem");
        expect(item.textContent).toContain("Use only color for meaning");
    });

    test("passes through additional HTML attributes", () => {
        render(Subject, { props: {
            "data-testid": "dont-item",
            children: textSnippet("Remove focus indicators"),
        }});

        const item = screen.getByTestId("dont-item");
        expect(item).toBeTruthy();
    });

    test("passes through id attribute", () => {
        render(Subject, { props: {
            id: "dont-1",
            children: textSnippet("Hard-code strings"),
        }});

        const item = screen.getByRole("listitem");
        expect(item.getAttribute("id")).toBe("dont-1");
    });
});
