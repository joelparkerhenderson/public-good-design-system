import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./TaskBar.svelte";

function textSnippet(text: string) {
    return (($anchor: Comment) => {
        const node = document.createTextNode(text);
        $anchor.before(node);
    }) as any;
}

describe("TaskBar", () => {
    test("renders a toolbar", () => {
        render(Subject, { props: { label: "Tasks", children: textSnippet("content") } });
        expect(screen.getByRole("toolbar")).toBeTruthy();
    });

    test("has aria-label", () => {
        render(Subject, { props: { label: "Task actions", children: textSnippet("content") } });
        expect(screen.getByLabelText("Task actions")).toBeTruthy();
    });

    test("renders children", () => {
        render(Subject, { props: { label: "Tasks", children: textSnippet("New") } });
        expect(screen.getByText("New")).toBeTruthy();
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "T", "data-testid": "tb", children: textSnippet("x") } });
        expect(screen.getByTestId("tb")).toBeTruthy();
    });
});
