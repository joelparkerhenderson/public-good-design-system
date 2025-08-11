import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignRespiratoryRateAsBreathsPerMinuteView";

describe("VitalSignRespiratoryRateAsBreathsPerMinuteView", () => {
    test("renders span with img role", () => {
        render(<Subject value={16} label="16 breaths per minute" />);
        expect(screen.getByRole("img")).toBeTruthy();
    });

    test("has aria-label from label prop", () => {
        render(<Subject value={16} label="16 breaths per minute" />);
        expect(screen.getByRole("img", { name: "16 breaths per minute" })).toBeTruthy();
    });

    test("displays value as text content", () => {
        render(<Subject value={16} label="16 breaths per minute" />);
        expect(screen.getByRole("img").textContent).toBe("16");
    });

    test("has data-value attribute", () => {
        render(<Subject value={16} label="16 breaths per minute" />);
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("16");
    });

    test("passes through attributes", () => {
        render(<Subject value={16} label="R" data-testid="rv" />);
        expect(screen.getByTestId("rv")).toBeTruthy();
    });
});
