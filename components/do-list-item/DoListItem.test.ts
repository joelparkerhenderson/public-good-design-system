import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./DoListItem.svelte";

function textSnippet(text: string) {
    return (($$anchor: Comment) => {
        const node = document.createTextNode(text);
        $$anchor.before(node);
    }) as any;
}

describe("DoListItem", () => {
    test("renders a list item element", () => {
        render(Subject, { props: {
            children: textSnippet("Write clear labels"),
        }});

        const item = screen.getByRole("listitem");
        expect(item.tagName).toBe("LI");
    });

    test("renders children content", () => {
        render(Subject, { props: {
            children: textSnippet("Use semantic HTML"),
        }});

        const item = screen.getByRole("listitem");
        expect(item.textContent).toContain("Use semantic HTML");
    });

    test("passes through additional HTML attributes", () => {
        render(Subject, { props: {
            "data-testid": "do-item",
            children: textSnippet("Provide alt text"),
        }});

        const item = screen.getByTestId("do-item");
        expect(item).toBeTruthy();
    });

    test("passes through id attribute", () => {
        render(Subject, { props: {
            id: "do-1",
            children: textSnippet("Test with keyboard"),
        }});

        const item = screen.getByRole("listitem");
        expect(item.getAttribute("id")).toBe("do-1");
    });
});
