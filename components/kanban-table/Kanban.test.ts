import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";
import Subject from "./Kanban.svelte";
function textSnippet(text: string) { return (($anchor: Comment) => { $anchor.before(document.createTextNode(text)); }) as any; }
describe("Kanban", () => {
    test("renders a region", () => { render(Subject, { props: { label: "Board", children: textSnippet("cols") } }); expect(screen.getByRole("region")).toBeTruthy(); });
    test("has aria-label", () => { render(Subject, { props: { label: "Project board", children: textSnippet("cols") } }); expect(screen.getByLabelText("Project board")).toBeTruthy(); });
    test("passes through attributes", () => { render(Subject, { props: { label: "K", "data-testid": "kb", children: textSnippet("x") } }); expect(screen.getByTestId("kb")).toBeTruthy(); });
});
