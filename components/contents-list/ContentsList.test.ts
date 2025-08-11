import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./ContentsList.svelte";

function textSnippet(text: string) {
    return (($$anchor: Comment) => {
        const node = document.createTextNode(text);
        $$anchor.before(node);
    }) as any;
}

describe("ContentsList", () => {
    test("renders as navigation", () => {
        render(Subject, { props: { label: "On this page", children: textSnippet("Items") } });
        expect(screen.getByRole("navigation", { name: "On this page" })).toBeTruthy();
    });

    test("contains ordered list", () => {
        render(Subject, { props: { label: "Contents", "data-testid": "nav", children: textSnippet("Items") } });
        expect(screen.getByTestId("nav").querySelector("ol")).toBeTruthy();
    });

    test("renders children", () => {
        render(Subject, { props: { label: "Contents", children: textSnippet("Section 1") } });
        expect(screen.getByRole("navigation").textContent).toContain("Section 1");
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "Contents", "data-testid": "cl", children: textSnippet("Items") } });
        expect(screen.getByTestId("cl")).toBeTruthy();
    });
});
