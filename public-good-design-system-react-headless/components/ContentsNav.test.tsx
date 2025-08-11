import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./ContentsNav";

describe("ContentsNav", () => {
    test("renders as navigation landmark", () => {
        render(<Subject label="On this page">Items</Subject>);
        expect(screen.getByRole("navigation", { name: "On this page" })).toBeTruthy();
    });

    test("applies aria-label", () => {
        render(<Subject label="Contents">Items</Subject>);
        expect(screen.getByRole("navigation").getAttribute("aria-label")).toBe("Contents");
    });

    test("renders children", () => {
        render(<Subject label="Contents">Section 1</Subject>);
        expect(screen.getByRole("navigation").textContent).toContain("Section 1");
    });

    test("passes through attributes", () => {
        render(<Subject label="Contents" data-testid="cn">Items</Subject>);
        expect(screen.getByTestId("cn")).toBeTruthy();
    });
});
