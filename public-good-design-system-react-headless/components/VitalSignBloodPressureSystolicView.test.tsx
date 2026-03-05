import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignBloodPressureSystolicView";

describe("VitalSignBloodPressureSystolicView", () => {
    test("renders span with img role", () => {
        render(<Subject value={120} label="120 mmHg systolic" />);
        expect(screen.getByRole("img")).toBeTruthy();
    });

    test("has aria-label from label prop", () => {
        render(<Subject value={120} label="120 mmHg systolic" />);
        expect(screen.getByRole("img", { name: "120 mmHg systolic" })).toBeTruthy();
    });

    test("displays value as text content", () => {
        render(<Subject value={120} label="120 mmHg systolic" />);
        expect(screen.getByRole("img").textContent).toBe("120");
    });

    test("has data-value attribute", () => {
        render(<Subject value={120} label="120 mmHg systolic" />);
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("120");
    });

    test("passes through attributes", () => {
        render(<Subject value={120} label="R" data-testid="rv" />);
        expect(screen.getByTestId("rv")).toBeTruthy();
    });
});
