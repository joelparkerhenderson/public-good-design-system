import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";
import Subject from "./HolyGrailLayout";
function textSnippet(text: string) { return (($$anchor: Comment) => { const node = document.createTextNode(text); $$anchor.before(node); }) as any; }
describe("HolyGrailLayout", () => {
    test("renders children", () => { render(<Subject data-testid="hg">Layout content</Subject>); expect(screen.getByTestId("hg").textContent).toContain("Layout content"); });
    test("passes through attributes", () => { render(<Subject data-testid="hg">C</Subject>); expect(screen.getByTestId("hg")).toBeTruthy(); });
});
