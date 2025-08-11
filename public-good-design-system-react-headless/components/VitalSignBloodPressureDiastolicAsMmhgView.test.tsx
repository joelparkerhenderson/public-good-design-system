import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignBloodPressureDiastolicAsMmhgView";

describe("VitalSignBloodPressureDiastolicAsMmhgView", () => {
    test("renders span with img role", () => {
        render(<Subject value={80} label="80 mmHg diastolic" />);
        expect(screen.getByRole("img")).toBeTruthy();
    });

    test("has aria-label from label prop", () => {
        render(<Subject value={80} label="80 mmHg diastolic" />);
        expect(screen.getByRole("img", { name: "80 mmHg diastolic" })).toBeTruthy();
    });

    test("displays value as text content", () => {
        render(<Subject value={80} label="80 mmHg diastolic" />);
        expect(screen.getByRole("img").textContent).toBe("80");
    });

    test("has data-value attribute", () => {
        render(<Subject value={80} label="80 mmHg diastolic" />);
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("80");
    });

    test("passes through attributes", () => {
        render(<Subject value={80} label="R" data-testid="rv" />);
        expect(screen.getByTestId("rv")).toBeTruthy();
    });
});
