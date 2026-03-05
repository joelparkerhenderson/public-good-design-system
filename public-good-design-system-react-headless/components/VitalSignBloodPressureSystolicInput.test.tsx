import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignBloodPressureSystolicInput";

describe("VitalSignBloodPressureSystolicInput", () => {
    test("renders input with type number", () => {
        render(<Subject label="Systolic blood pressure" />);
        expect((screen.getByLabelText("Systolic blood pressure") as HTMLInputElement).type).toBe("number");
    });

    test("has aria-label from label prop", () => {
        render(<Subject label="Systolic blood pressure" />);
        expect(screen.getByLabelText("Systolic blood pressure")).toBeTruthy();
    });

    test("has default min=0", () => {
        render(<Subject label="Systolic blood pressure" />);
        expect((screen.getByLabelText("Systolic blood pressure") as HTMLInputElement).min).toBe("0");
    });

    test("has default max=300", () => {
        render(<Subject label="Systolic blood pressure" />);
        expect((screen.getByLabelText("Systolic blood pressure") as HTMLInputElement).max).toBe("300");
    });

    test("has default step=1", () => {
        render(<Subject label="Systolic blood pressure" />);
        expect((screen.getByLabelText("Systolic blood pressure") as HTMLInputElement).step).toBe("1");
    });

    test("supports disabled", () => {
        render(<Subject label="Systolic blood pressure" disabled />);
        expect((screen.getByLabelText("Systolic blood pressure") as HTMLInputElement).disabled).toBe(true);
    });

    test("supports required", () => {
        render(<Subject label="Systolic blood pressure" required />);
        expect((screen.getByLabelText("Systolic blood pressure") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(<Subject label="Systolic blood pressure" data-testid="pr" />);
        expect(screen.getByTestId("pr")).toBeTruthy();
    });
});
