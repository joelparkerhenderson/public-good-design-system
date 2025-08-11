import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignBodyFatAsPercentageView";

describe("VitalSignBodyFatAsPercentageView", () => {
    test("renders span with img role", () => {
        render(<Subject value={22.5} label="22.5 percent body fat" />);
        expect(screen.getByRole("img")).toBeTruthy();
    });

    test("has aria-label from label prop", () => {
        render(<Subject value={22.5} label="22.5 percent body fat" />);
        expect(screen.getByRole("img", { name: "22.5 percent body fat" })).toBeTruthy();
    });

    test("displays value as text content", () => {
        render(<Subject value={22.5} label="22.5 percent body fat" />);
        expect(screen.getByRole("img").textContent).toBe("22.5");
    });

    test("has data-value attribute", () => {
        render(<Subject value={22.5} label="22.5 percent body fat" />);
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("22.5");
    });

    test("passes through attributes", () => {
        render(<Subject value={22.5} label="T" data-testid="tv" />);
        expect(screen.getByTestId("tv")).toBeTruthy();
    });
});
