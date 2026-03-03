import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./DoList";

describe("DoList", () => {
    test("renders as a list", () => {
        render(<Subject>Items</Subject>);
        expect(screen.getByRole("list", { name: "Do" })).toBeTruthy();
    });

    test("has default label", () => {
        render(<Subject>Items</Subject>);
        expect(screen.getByRole("list").getAttribute("aria-label")).toBe("Do");
    });

    test("accepts custom label", () => {
        render(<Subject label="Recommended">Items</Subject>);
        expect(screen.getByRole("list").getAttribute("aria-label")).toBe("Recommended");
    });

    test("renders children", () => {
        render(<Subject>Use alt text</Subject>);
        expect(screen.getByRole("list").textContent).toContain("Use alt text");
    });

    test("passes through attributes", () => {
        render(<Subject data-testid="dl">C</Subject>);
        expect(screen.getByTestId("dl")).toBeTruthy();
    });
});
