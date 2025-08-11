import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./DontList";

describe("DontList", () => {
    test("renders as a list", () => {
        render(<Subject>Items</Subject>);
        expect(screen.getByRole("list", { name: "Don't" })).toBeTruthy();
    });

    test("has default label", () => {
        render(<Subject>Items</Subject>);
        expect(screen.getByRole("list").getAttribute("aria-label")).toBe("Don't");
    });

    test("accepts custom label", () => {
        render(<Subject label="Avoid">Items</Subject>);
        expect(screen.getByRole("list").getAttribute("aria-label")).toBe("Avoid");
    });

    test("renders children", () => {
        render(<Subject>Skip tests</Subject>);
        expect(screen.getByRole("list").textContent).toContain("Skip tests");
    });

    test("passes through attributes", () => {
        render(<Subject data-testid="dnl">C</Subject>);
        expect(screen.getByTestId("dnl")).toBeTruthy();
    });
});
