import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignHeartRateAsBeatsPerMinuteView";

describe("VitalSignHeartRateAsBeatsPerMinuteView", () => {
    test("renders span with img role", () => {
        render(<Subject value={72} label="Heart rate: 72 BPM" />);
        expect(screen.getByRole("img")).toBeTruthy();
    });

    test("has aria-label from label prop", () => {
        render(<Subject value={72} label="Heart rate: 72 BPM" />);
        expect(screen.getByRole("img", { name: "Heart rate: 72 BPM" })).toBeTruthy();
    });

    test("displays value as text content", () => {
        render(<Subject value={72} label="Heart rate: 72 BPM" />);
        expect(screen.getByRole("img").textContent).toBe("72");
    });

    test("has data-value attribute", () => {
        render(<Subject value={72} label="Heart rate: 72 BPM" />);
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("72");
    });

    test("passes through attributes", () => {
        render(<Subject value={72} label="R" data-testid="rv" />);
        expect(screen.getByTestId("rv")).toBeTruthy();
    });
});
