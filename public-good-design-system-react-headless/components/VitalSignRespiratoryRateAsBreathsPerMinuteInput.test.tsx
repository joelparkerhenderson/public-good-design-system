import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignRespiratoryRateAsBreathsPerMinuteInput";

describe("VitalSignRespiratoryRateAsBreathsPerMinuteInput", () => {
    test("renders input with type number", () => {
        render(<Subject label="Respiratory rate" />);
        expect((screen.getByLabelText("Respiratory rate") as HTMLInputElement).type).toBe("number");
    });

    test("has aria-label from label prop", () => {
        render(<Subject label="Respiratory rate" />);
        expect(screen.getByLabelText("Respiratory rate")).toBeTruthy();
    });

    test("has default min=0", () => {
        render(<Subject label="Respiratory rate" />);
        expect((screen.getByLabelText("Respiratory rate") as HTMLInputElement).min).toBe("0");
    });

    test("has default max=100", () => {
        render(<Subject label="Respiratory rate" />);
        expect((screen.getByLabelText("Respiratory rate") as HTMLInputElement).max).toBe("100");
    });

    test("has default step=1", () => {
        render(<Subject label="Respiratory rate" />);
        expect((screen.getByLabelText("Respiratory rate") as HTMLInputElement).step).toBe("1");
    });

    test("supports disabled", () => {
        render(<Subject label="Respiratory rate" disabled />);
        expect((screen.getByLabelText("Respiratory rate") as HTMLInputElement).disabled).toBe(true);
    });

    test("supports required", () => {
        render(<Subject label="Respiratory rate" required />);
        expect((screen.getByLabelText("Respiratory rate") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(<Subject label="Respiratory rate" data-testid="rr" />);
        expect(screen.getByTestId("rr")).toBeTruthy();
    });
});
