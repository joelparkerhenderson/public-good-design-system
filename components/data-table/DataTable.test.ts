import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./DataTable.svelte";

function textSnippet(text: string) {
    return (($$anchor: Comment) => {
        const node = document.createTextNode(text);
        $$anchor.before(node);
    }) as any;
}

function rowSnippet() {
    return (($$anchor: Comment) => {
        const tbody = document.createElement("tbody");
        const tr = document.createElement("tr");
        const td = document.createElement("td");
        td.textContent = "Alice";
        tr.appendChild(td);
        tbody.appendChild(tr);
        $$anchor.before(tbody);
    }) as any;
}

describe("DataTable", () => {
    test("renders as a table", () => {
        render(Subject, { props: { label: "Users", children: rowSnippet() } });
        expect(screen.getByRole("table", { name: "Users" })).toBeTruthy();
    });

    test("has aria-label when no caption", () => {
        render(Subject, { props: { label: "Accounts", children: rowSnippet() } });
        expect(screen.getByRole("table").getAttribute("aria-label")).toBe("Accounts");
    });

    test("renders caption when provided", () => {
        render(Subject, { props: { caption: "User list", children: rowSnippet() } });
        const table = screen.getByRole("table");
        const cap = table.querySelector("caption");
        expect(cap).toBeTruthy();
        expect(cap?.textContent).toBe("User list");
    });

    test("omits aria-label when caption is present", () => {
        render(Subject, { props: { caption: "Users", label: "Fallback", children: rowSnippet() } });
        expect(screen.getByRole("table").getAttribute("aria-label")).toBeNull();
    });

    test("renders children", () => {
        render(Subject, { props: { label: "T", children: rowSnippet() } });
        expect(screen.getByRole("table").textContent).toContain("Alice");
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "T", "data-testid": "dt", children: rowSnippet() } });
        expect(screen.getByTestId("dt")).toBeTruthy();
    });
});
