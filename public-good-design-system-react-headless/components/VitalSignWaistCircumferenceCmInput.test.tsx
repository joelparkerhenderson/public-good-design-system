import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignWaistCircumferenceCmInput";

describe("VitalSignWaistCircumferenceCmInput", () => {
    test("renders input with type number", () => {
        render(<Subject label="Waist circumference (cm)" />);
        expect((screen.getByLabelText("Waist circumference (cm)") as HTMLInputElement).type).toBe("number");
    });

    test("has aria-label from label prop", () => {
        render(<Subject label="Waist circumference (cm)" />);
        expect(screen.getByLabelText("Waist circumference (cm)")).toBeTruthy();
    });

    test("has default min=0", () => {
        render(<Subject label="Waist circumference (cm)" />);
        expect((screen.getByLabelText("Waist circumference (cm)") as HTMLInputElement).min).toBe("0");
    });

    test("has default max=300", () => {
        render(<Subject label="Waist circumference (cm)" />);
        expect((screen.getByLabelText("Waist circumference (cm)") as HTMLInputElement).max).toBe("300");
    });

    test("has default step=1", () => {
        render(<Subject label="Waist circumference (cm)" />);
        expect((screen.getByLabelText("Waist circumference (cm)") as HTMLInputElement).step).toBe("1");
    });

    test("supports disabled", () => {
        render(<Subject label="Waist circumference (cm)" disabled />);
        expect((screen.getByLabelText("Waist circumference (cm)") as HTMLInputElement).disabled).toBe(true);
    });

    test("supports required", () => {
        render(<Subject label="Waist circumference (cm)" required />);
        expect((screen.getByLabelText("Waist circumference (cm)") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(<Subject label="Waist circumference (cm)" data-testid="pr" />);
        expect(screen.getByTestId("pr")).toBeTruthy();
    });
});
