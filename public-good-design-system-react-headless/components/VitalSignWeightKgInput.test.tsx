import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignWeightKgInput";

describe("VitalSignWeightKgInput", () => {
    test("renders input with type number", () => {
        render(<Subject label="Weight (kg)" />);
        expect((screen.getByLabelText("Weight (kg)") as HTMLInputElement).type).toBe("number");
    });

    test("has aria-label from label prop", () => {
        render(<Subject label="Weight (kg)" />);
        expect(screen.getByLabelText("Weight (kg)")).toBeTruthy();
    });

    test("has default min=0", () => {
        render(<Subject label="Weight (kg)" />);
        expect((screen.getByLabelText("Weight (kg)") as HTMLInputElement).min).toBe("0");
    });

    test("has default max=500", () => {
        render(<Subject label="Weight (kg)" />);
        expect((screen.getByLabelText("Weight (kg)") as HTMLInputElement).max).toBe("500");
    });

    test("has default step=1", () => {
        render(<Subject label="Weight (kg)" />);
        expect((screen.getByLabelText("Weight (kg)") as HTMLInputElement).step).toBe("1");
    });

    test("supports disabled", () => {
        render(<Subject label="Weight (kg)" disabled />);
        expect((screen.getByLabelText("Weight (kg)") as HTMLInputElement).disabled).toBe(true);
    });

    test("supports required", () => {
        render(<Subject label="Weight (kg)" required />);
        expect((screen.getByLabelText("Weight (kg)") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(<Subject label="Weight (kg)" data-testid="pr" />);
        expect(screen.getByTestId("pr")).toBeTruthy();
    });
});
