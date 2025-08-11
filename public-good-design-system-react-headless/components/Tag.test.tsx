import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./Tag";

describe("Tag", () => {
    test("renders with status role", () => {
        render(<Subject label="Category">Design</Subject>);

        const tag = screen.getByRole("status");
        expect(tag).toBeTruthy();
    });

    test("renders as a span element", () => {
        render(<Subject label="Category">Design</Subject>);

        const tag = screen.getByRole("status");
        expect(tag.tagName).toBe("SPAN");
    });

    test("displays children content", () => {
        render(<Subject label="Status">Active</Subject>);

        const tag = screen.getByRole("status");
        expect(tag.textContent).toContain("Active");
    });

    test("has aria-label from label prop", () => {
        render(<Subject label="Priority: High">High</Subject>);

        const tag = screen.getByRole("status");
        expect(tag.getAttribute("aria-label")).toBe("Priority: High");
    });

    test("passes through additional HTML attributes", () => {
        render(<Subject label="Tag" data-testid="my-tag">Label</Subject>);

        const tag = screen.getByTestId("my-tag");
        expect(tag).toBeTruthy();
    });

    test("passes through id attribute", () => {
        render(<Subject label="Tag" id="tag-1">Label</Subject>);

        const tag = screen.getByRole("status");
        expect(tag.getAttribute("id")).toBe("tag-1");
    });
});
