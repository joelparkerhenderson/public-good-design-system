import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignHeightCmInput";

describe("VitalSignHeightCmInput", () => {
    test("renders input with type number", () => {
        render(<Subject label="Height (cm)" />);
        expect((screen.getByLabelText("Height (cm)") as HTMLInputElement).type).toBe("number");
    });

    test("has aria-label from label prop", () => {
        render(<Subject label="Height (cm)" />);
        expect(screen.getByLabelText("Height (cm)")).toBeTruthy();
    });

    test("has default min=0", () => {
        render(<Subject label="Height (cm)" />);
        expect((screen.getByLabelText("Height (cm)") as HTMLInputElement).min).toBe("0");
    });

    test("has default max=300", () => {
        render(<Subject label="Height (cm)" />);
        expect((screen.getByLabelText("Height (cm)") as HTMLInputElement).max).toBe("300");
    });

    test("has default step=1", () => {
        render(<Subject label="Height (cm)" />);
        expect((screen.getByLabelText("Height (cm)") as HTMLInputElement).step).toBe("1");
    });

    test("supports disabled", () => {
        render(<Subject label="Height (cm)" disabled />);
        expect((screen.getByLabelText("Height (cm)") as HTMLInputElement).disabled).toBe(true);
    });

    test("supports required", () => {
        render(<Subject label="Height (cm)" required />);
        expect((screen.getByLabelText("Height (cm)") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(<Subject label="Height (cm)" data-testid="pr" />);
        expect(screen.getByTestId("pr")).toBeTruthy();
    });
});
