import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./CalendarTable.svelte";

function cellsSnippet() {
    return (($anchor: Comment) => {
        const tbody = document.createElement("tbody");
        const tr = document.createElement("tr");
        const td = document.createElement("td");
        td.textContent = "1";
        tr.appendChild(td);
        tbody.appendChild(tr);
        $anchor.before(tbody);
    }) as any;
}

describe("CalendarTable", () => {
    test("renders a grid", () => {
        render(Subject, { props: { label: "January", children: cellsSnippet() } });
        expect(screen.getByRole("grid")).toBeTruthy();
    });

    test("has aria-label", () => {
        render(Subject, { props: { label: "January 2025", children: cellsSnippet() } });
        expect(screen.getByLabelText("January 2025")).toBeTruthy();
    });

    test("uses table element", () => {
        render(Subject, { props: { label: "January", children: cellsSnippet() } });
        expect(screen.getByRole("grid").tagName).toBe("TABLE");
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "J", "data-testid": "cb", children: cellsSnippet() } });
        expect(screen.getByTestId("cb")).toBeTruthy();
    });
});
