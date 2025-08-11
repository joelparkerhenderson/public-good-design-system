import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";
import Subject from "./GanttChart.svelte";
function textSnippet(text: string) { return (($anchor: Comment) => { $anchor.before(document.createTextNode(text)); }) as any; }
describe("GanttChart", () => {
    test("renders a grid", () => { render(Subject, { props: { label: "Project", children: textSnippet("tasks") } }); expect(screen.getByRole("grid")).toBeTruthy(); });
    test("has aria-label", () => { render(Subject, { props: { label: "Project timeline", children: textSnippet("tasks") } }); expect(screen.getByLabelText("Project timeline")).toBeTruthy(); });
    test("passes through attributes", () => { render(Subject, { props: { label: "G", "data-testid": "gc", children: textSnippet("x") } }); expect(screen.getByTestId("gc")).toBeTruthy(); });
});
