import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignHeartRateVariabilityInput";

describe("VitalSignHeartRateVariabilityInput", () => {
    test("renders input with type number", () => {
        render(<Subject label="HRV" />);
        expect((screen.getByLabelText("HRV") as HTMLInputElement).type).toBe("number");
    });

    test("has aria-label from label prop", () => {
        render(<Subject label="HRV" />);
        expect(screen.getByLabelText("HRV")).toBeTruthy();
    });

    test("has default min=0", () => {
        render(<Subject label="HRV" />);
        expect((screen.getByLabelText("HRV") as HTMLInputElement).min).toBe("0");
    });

    test("has default max=500", () => {
        render(<Subject label="HRV" />);
        expect((screen.getByLabelText("HRV") as HTMLInputElement).max).toBe("500");
    });

    test("has default step=1", () => {
        render(<Subject label="HRV" />);
        expect((screen.getByLabelText("HRV") as HTMLInputElement).step).toBe("1");
    });

    test("supports disabled", () => {
        render(<Subject label="HRV" disabled />);
        expect((screen.getByLabelText("HRV") as HTMLInputElement).disabled).toBe(true);
    });

    test("supports required", () => {
        render(<Subject label="HRV" required />);
        expect((screen.getByLabelText("HRV") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(<Subject label="HRV" data-testid="pr" />);
        expect(screen.getByTestId("pr")).toBeTruthy();
    });
});
