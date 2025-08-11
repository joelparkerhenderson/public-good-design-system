import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./TimelineListItem.svelte";

function textSnippet(text: string) {
    return (($anchor: Comment) => {
        const node = document.createTextNode(text);
        $anchor.before(node);
    }) as any;
}

describe("TimelineListItem", () => {
    test("renders a list item element", () => {
        render(Subject, {
            props: {
                children: textSnippet("Event happened"),
            },
        });
        const item = screen.getByRole("listitem");
        expect(item.tagName).toBe("LI");
    });

    test("renders children content", () => {
        render(Subject, {
            props: {
                children: textSnippet("Order placed"),
            },
        });
        expect(screen.getByText("Order placed")).toBeTruthy();
    });

    test("passes through additional HTML attributes", () => {
        render(Subject, {
            props: {
                "data-testid": "timeline-item",
                children: textSnippet("event"),
            },
        });
        expect(screen.getByTestId("timeline-item")).toBeTruthy();
    });

    test("passes through id attribute", () => {
        render(Subject, {
            props: {
                id: "milestone-1",
                children: textSnippet("event"),
            },
        });
        const item = screen.getByRole("listitem");
        expect(item.getAttribute("id")).toBe("milestone-1");
    });
});
