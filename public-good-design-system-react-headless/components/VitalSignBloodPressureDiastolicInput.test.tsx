import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignBloodPressureDiastolicInput";

describe("VitalSignBloodPressureDiastolicInput", () => {
    test("renders input with type number", () => {
        render(<Subject label="Diastolic blood pressure" />);
        expect((screen.getByLabelText("Diastolic blood pressure") as HTMLInputElement).type).toBe("number");
    });

    test("has aria-label from label prop", () => {
        render(<Subject label="Diastolic blood pressure" />);
        expect(screen.getByLabelText("Diastolic blood pressure")).toBeTruthy();
    });

    test("has default min=0", () => {
        render(<Subject label="Diastolic blood pressure" />);
        expect((screen.getByLabelText("Diastolic blood pressure") as HTMLInputElement).min).toBe("0");
    });

    test("has default max=200", () => {
        render(<Subject label="Diastolic blood pressure" />);
        expect((screen.getByLabelText("Diastolic blood pressure") as HTMLInputElement).max).toBe("200");
    });

    test("has default step=1", () => {
        render(<Subject label="Diastolic blood pressure" />);
        expect((screen.getByLabelText("Diastolic blood pressure") as HTMLInputElement).step).toBe("1");
    });

    test("supports disabled", () => {
        render(<Subject label="Diastolic blood pressure" disabled />);
        expect((screen.getByLabelText("Diastolic blood pressure") as HTMLInputElement).disabled).toBe(true);
    });

    test("supports required", () => {
        render(<Subject label="Diastolic blood pressure" required />);
        expect((screen.getByLabelText("Diastolic blood pressure") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(<Subject label="Diastolic blood pressure" data-testid="pr" />);
        expect(screen.getByTestId("pr")).toBeTruthy();
    });
});
