import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./AccordionListItem.svelte";

function textSnippet(text: string) {
    return (($anchor: Comment) => {
        const node = document.createTextNode(text);
        $anchor.before(node);
    }) as any;
}

describe("AccordionListItem", () => {
    test("renders a details element", () => {
        render(Subject, { props: { summary: "Q1", "data-testid": "aai", children: textSnippet("A1") } });
        expect(screen.getByTestId("aai").tagName).toBe("DETAILS");
    });

    test("renders summary text", () => {
        render(Subject, { props: { summary: "Question 1", children: textSnippet("Answer") } });
        expect(screen.getByText("Question 1")).toBeTruthy();
    });

    test("renders children content", () => {
        render(Subject, { props: { summary: "Q", children: textSnippet("Answer 1") } });
        expect(screen.getByText("Answer 1")).toBeTruthy();
    });

    test("passes through attributes", () => {
        render(Subject, { props: { summary: "Q", "data-testid": "item", children: textSnippet("A") } });
        expect(screen.getByTestId("item")).toBeTruthy();
    });
});
