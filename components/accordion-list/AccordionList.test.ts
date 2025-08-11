import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./AccordionList.svelte";

function textSnippet(text: string) {
    return (($anchor: Comment) => {
        const node = document.createTextNode(text);
        $anchor.before(node);
    }) as any;
}

describe("AccordionList", () => {
    test("renders an ordered list element", () => {
        render(Subject, { props: { children: textSnippet("items") } });
        const list = screen.getByRole("list");
        expect(list.tagName).toBe("OL");
    });

    test("renders children content", () => {
        render(Subject, { props: { children: textSnippet("Accordion items here") } });
        const list = screen.getByRole("list");
        expect(list.textContent).toContain("Accordion items here");
    });

    test("passes through additional HTML attributes", () => {
        render(Subject, { props: { "data-testid": "acc-list", children: textSnippet("items") } });
        expect(screen.getByTestId("acc-list")).toBeTruthy();
    });

    test("passes through id attribute", () => {
        render(Subject, { props: { id: "faq-list", children: textSnippet("items") } });
        const list = screen.getByRole("list");
        expect(list.getAttribute("id")).toBe("faq-list");
    });
});
