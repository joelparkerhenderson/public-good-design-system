import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "../../components/ContentsNav.vue";


describe("ContentsNav", () => {
    test("renders as navigation landmark", () => {
        render(Subject, { props: { label: "On this page" }, slots: { default: "Items" } });
        expect(screen.getByRole("navigation", { name: "On this page" })).toBeTruthy();
    });

    test("applies aria-label", () => {
        render(Subject, { props: { label: "Contents" }, slots: { default: "Items" } });
        expect(screen.getByRole("navigation").getAttribute("aria-label")).toBe("Contents");
    });

    test("renders children", () => {
        render(Subject, { props: { label: "Contents" }, slots: { default: "Section 1" } });
        expect(screen.getByRole("navigation").textContent).toContain("Section 1");
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "Contents", "data-testid": "cn" }, slots: { default: "Items" } });
        expect(screen.getByTestId("cn")).toBeTruthy();
    });
});
