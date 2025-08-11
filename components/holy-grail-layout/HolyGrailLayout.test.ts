import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";
import Subject from "./HolyGrailLayout.svelte";
function textSnippet(text: string) { return (($$anchor: Comment) => { const node = document.createTextNode(text); $$anchor.before(node); }) as any; }
describe("HolyGrailLayout", () => {
    test("renders children", () => { render(Subject, { props: { "data-testid": "hg", children: textSnippet("Layout content") } }); expect(screen.getByTestId("hg").textContent).toContain("Layout content"); });
    test("passes through attributes", () => { render(Subject, { props: { "data-testid": "hg", children: textSnippet("C") } }); expect(screen.getByTestId("hg")).toBeTruthy(); });
});
