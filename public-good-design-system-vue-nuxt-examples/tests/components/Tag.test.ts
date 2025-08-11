import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "../../components/Tag.vue";


describe("Tag", () => {
    test("renders with status role", () => {
        render(Subject, { props: { label: "Category" }, slots: { default: "Design" } });

        const tag = screen.getByRole("status");
        expect(tag).toBeTruthy();
    });

    test("renders as a span element", () => {
        render(Subject, { props: { label: "Category" }, slots: { default: "Design" } });

        const tag = screen.getByRole("status");
        expect(tag.tagName).toBe("SPAN");
    });

    test("displays children content", () => {
        render(Subject, { props: { label: "Status" }, slots: { default: "Active" } });

        const tag = screen.getByRole("status");
        expect(tag.textContent).toContain("Active");
    });

    test("has aria-label from label prop", () => {
        render(Subject, { props: { label: "Priority: High" }, slots: { default: "High" } });

        const tag = screen.getByRole("status");
        expect(tag.getAttribute("aria-label")).toBe("Priority: High");
    });

    test("passes through additional HTML attributes", () => {
        render(Subject, { props: { label: "Tag",
            "data-testid": "my-tag" }, slots: { default: "Label" } });

        const tag = screen.getByTestId("my-tag");
        expect(tag).toBeTruthy();
    });

    test("passes through id attribute", () => {
        render(Subject, { props: { label: "Tag",
            id: "tag-1" }, slots: { default: "Label" } });

        const tag = screen.getByRole("status");
        expect(tag.getAttribute("id")).toBe("tag-1");
    });
});
