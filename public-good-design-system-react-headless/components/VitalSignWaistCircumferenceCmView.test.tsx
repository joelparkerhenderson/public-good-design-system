import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignWaistCircumferenceCmView";

describe("VitalSignWaistCircumferenceCmView", () => {
    test("renders span with img role", () => {
        render(<Subject value={94} label="94 cm waist circumference" />);
        expect(screen.getByRole("img")).toBeTruthy();
    });

    test("has aria-label from label prop", () => {
        render(<Subject value={94} label="94 cm waist circumference" />);
        expect(screen.getByRole("img", { name: "94 cm waist circumference" })).toBeTruthy();
    });

    test("displays value as text content", () => {
        render(<Subject value={94} label="94 cm waist circumference" />);
        expect(screen.getByRole("img").textContent).toBe("94");
    });

    test("has data-value attribute", () => {
        render(<Subject value={94} label="94 cm waist circumference" />);
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("94");
    });

    test("passes through attributes", () => {
        render(<Subject value={94} label="R" data-testid="rv" />);
        expect(screen.getByTestId("rv")).toBeTruthy();
    });
});
