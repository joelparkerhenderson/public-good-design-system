import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";
import Subject from "../../components/HolyGrailLayout.vue";
describe("HolyGrailLayout", () => {
    test("renders children", () => { render(Subject, { props: { "data-testid": "hg" }, slots: { default: "Layout content" } }); expect(screen.getByTestId("hg").textContent).toContain("Layout content"); });
    test("passes through attributes", () => { render(Subject, { props: { "data-testid": "hg" }, slots: { default: "C" } }); expect(screen.getByTestId("hg")).toBeTruthy(); });
});
