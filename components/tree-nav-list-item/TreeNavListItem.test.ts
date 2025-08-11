import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./TreeNavListItem.svelte";

function textSnippet(text: string) {
    return (($anchor: Comment) => {
        const node = document.createTextNode(text);
        $anchor.before(node);
    }) as any;
}

describe("TreeNavListItem", () => {
    test("renders a list item element", () => {
        render(Subject, {
            props: {
                children: textSnippet("Documents"),
            },
        });
        const item = screen.getByRole("treeitem");
        expect(item.tagName).toBe("LI");
    });

    test("has role treeitem", () => {
        render(Subject, {
            props: {
                children: textSnippet("Documents"),
            },
        });
        expect(screen.getByRole("treeitem")).toBeTruthy();
    });

    test("renders children content", () => {
        render(Subject, {
            props: {
                children: textSnippet("Photos"),
            },
        });
        expect(screen.getByText("Photos")).toBeTruthy();
    });

    test("supports tabindex attribute", () => {
        render(Subject, {
            props: {
                tabindex: 0,
                children: textSnippet("Documents"),
            },
        });
        const item = screen.getByRole("treeitem");
        expect(item.getAttribute("tabindex")).toBe("0");
    });

    test("supports aria-expanded attribute", () => {
        render(Subject, {
            props: {
                "aria-expanded": "true",
                children: textSnippet("Documents"),
            },
        });
        const item = screen.getByRole("treeitem");
        expect(item.getAttribute("aria-expanded")).toBe("true");
    });

    test("passes through additional attributes", () => {
        render(Subject, {
            props: {
                "data-testid": "tree-item",
                children: textSnippet("Documents"),
            },
        });
        expect(screen.getByTestId("tree-item")).toBeTruthy();
    });
});
