import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./MenuBarItem.svelte";

function textSnippet(text: string) {
    return (($anchor: Comment) => {
        const node = document.createTextNode(text);
        $anchor.before(node);
    }) as any;
}

describe("MenuBarItem", () => {
    test("renders a menuitem", () => {
        render(Subject, { props: { children: textSnippet("File") } });
        expect(screen.getByRole("menuitem")).toBeTruthy();
    });

    test("has tabindex -1", () => {
        render(Subject, { props: { children: textSnippet("File") } });
        expect(screen.getByRole("menuitem").getAttribute("tabindex")).toBe("-1");
    });

    test("renders children", () => {
        render(Subject, { props: { children: textSnippet("Edit") } });
        expect(screen.getByText("Edit")).toBeTruthy();
    });

    test("passes through attributes", () => {
        render(Subject, { props: { "data-testid": "mbi", children: textSnippet("X") } });
        expect(screen.getByTestId("mbi")).toBeTruthy();
    });
});
