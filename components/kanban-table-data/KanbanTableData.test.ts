import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";
import Subject from "./KanbanTableData.svelte";
function textSnippet(text: string) { return (($anchor: Comment) => { $anchor.before(document.createTextNode(text)); }) as any; }
describe("KanbanTableData", () => {
    test("renders a listitem", () => { render(Subject, { props: { children: textSnippet("Task") } }); expect(screen.getByRole("listitem")).toBeTruthy(); });
    test("supports aria-label", () => { render(Subject, { props: { label: "Bug fix", children: textSnippet("content") } }); expect(screen.getByLabelText("Bug fix")).toBeTruthy(); });
    test("passes through attributes", () => { render(Subject, { props: { "data-testid": "ki", children: textSnippet("x") } }); expect(screen.getByTestId("ki")).toBeTruthy(); });
});
