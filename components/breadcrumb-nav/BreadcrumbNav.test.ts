import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./BreadcrumbList.svelte";

function textSnippet(text: string) {
    return (($anchor: Comment) => {
        const node = document.createTextNode(text);
        $anchor.before(node);
    }) as any;
}

function itemsSnippet() {
    return (($anchor: Comment) => {
        const li1 = document.createElement("li");
        const a1 = document.createElement("a");
        a1.href = "/";
        a1.textContent = "Home";
        li1.appendChild(a1);
        const li2 = document.createElement("li");
        li2.textContent = "Current";
        li2.setAttribute("aria-current", "page");
        $anchor.before(li1, li2);
    }) as any;
}

describe("BreadcrumbList", () => {
    test("renders a navigation landmark", () => {
        render(Subject, { props: { label: "Breadcrumb", children: textSnippet("Items") } });
        expect(screen.getByRole("navigation")).toBeTruthy();
    });

    test("has aria-label", () => {
        render(Subject, { props: { label: "Breadcrumb", children: textSnippet("Items") } });
        expect(screen.getByRole("navigation", { name: "Breadcrumb" })).toBeTruthy();
    });

    test("contains an ordered list", () => {
        render(Subject, { props: { label: "Breadcrumb", "data-testid": "nav", children: textSnippet("Items") } });
        expect(screen.getByTestId("nav").querySelector("ol")).toBeTruthy();
    });

    test("renders children inside the list", () => {
        render(Subject, { props: { label: "Breadcrumb", children: itemsSnippet() } });
        expect(screen.getByText("Home")).toBeTruthy();
        expect(screen.getByText("Current")).toBeTruthy();
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "Breadcrumb", "data-testid": "bc", children: textSnippet("x") } });
        expect(screen.getByTestId("bc")).toBeTruthy();
    });
});
