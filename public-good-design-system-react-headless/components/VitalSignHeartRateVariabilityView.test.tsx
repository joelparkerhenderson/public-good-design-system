import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignHeartRateVariabilityView";

describe("VitalSignHeartRateVariabilityView", () => {
    test("renders span with img role", () => {
        render(<Subject value={45} label="45 milliseconds HRV" />);
        expect(screen.getByRole("img")).toBeTruthy();
    });

    test("has aria-label from label prop", () => {
        render(<Subject value={45} label="45 milliseconds HRV" />);
        expect(screen.getByRole("img", { name: "45 milliseconds HRV" })).toBeTruthy();
    });

    test("displays value as text content", () => {
        render(<Subject value={45} label="45 milliseconds HRV" />);
        expect(screen.getByRole("img").textContent).toBe("45");
    });

    test("has data-value attribute", () => {
        render(<Subject value={45} label="45 milliseconds HRV" />);
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("45");
    });

    test("passes through attributes", () => {
        render(<Subject value={45} label="R" data-testid="rv" />);
        expect(screen.getByTestId("rv")).toBeTruthy();
    });
});
