import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./CalendarTableCell.svelte";

function textSnippet(text: string) {
    return (($anchor: Comment) => {
        const node = document.createTextNode(text);
        $anchor.before(node);
    }) as any;
}

describe("CalendarTableCell", () => {
    test("renders a gridcell", () => {
        render(Subject, { props: { children: textSnippet("15") } });
        expect(screen.getByRole("gridcell")).toBeTruthy();
    });

    test("renders children", () => {
        render(Subject, { props: { children: textSnippet("20") } });
        expect(screen.getByText("20")).toBeTruthy();
    });

    test("sets aria-selected when selected", () => {
        render(Subject, { props: { selected: true, children: textSnippet("1") } });
        expect(screen.getByRole("gridcell").getAttribute("aria-selected")).toBe("true");
    });

    test("sets aria-current date when today", () => {
        render(Subject, { props: { today: true, children: textSnippet("1") } });
        expect(screen.getByRole("gridcell").getAttribute("aria-current")).toBe("date");
    });

    test("passes through attributes", () => {
        render(Subject, { props: { "data-testid": "cbi", children: textSnippet("1") } });
        expect(screen.getByTestId("cbi")).toBeTruthy();
    });
});
