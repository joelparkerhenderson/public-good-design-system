import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./AvatarCircleText.svelte";

function textSnippet(text: string) {
    return (($anchor: Comment) => {
        const node = document.createTextNode(text);
        $anchor.before(node);
    }) as any;
}

describe("AvatarCircleText", () => {
    test("renders a span element", () => {
        render(Subject, { props: { "data-testid": "initials", children: textSnippet("JD") } });
        const el = screen.getByTestId("initials");
        expect(el.tagName).toBe("SPAN");
    });

    test("renders children text", () => {
        render(Subject, { props: { children: textSnippet("JD") } });
        expect(screen.getByText("JD")).toBeTruthy();
    });

    test("supports aria-hidden attribute", () => {
        render(Subject, { props: { "aria-hidden": "true", "data-testid": "initials", children: textSnippet("JD") } });
        const el = screen.getByTestId("initials");
        expect(el.getAttribute("aria-hidden")).toBe("true");
    });

    test("passes through additional HTML attributes", () => {
        render(Subject, { props: { "data-testid": "avatar-text", children: textSnippet("AB") } });
        expect(screen.getByTestId("avatar-text")).toBeTruthy();
    });

    test("passes through class attribute", () => {
        render(Subject, { props: { class: "initials-style", "data-testid": "styled", children: textSnippet("XY") } });
        const el = screen.getByTestId("styled");
        expect(el.getAttribute("class")).toContain("initials-style");
    });
});
