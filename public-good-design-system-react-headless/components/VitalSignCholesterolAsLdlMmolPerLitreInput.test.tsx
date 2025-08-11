import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignCholesterolAsLdlMmolPerLitreInput";

describe("VitalSignCholesterolAsLdlMmolPerLitreInput", () => {
    test("renders input with type number", () => {
        render(<Subject label="LDL cholesterol" />);
        expect((screen.getByLabelText("LDL cholesterol") as HTMLInputElement).type).toBe("number");
    });

    test("has aria-label from label prop", () => {
        render(<Subject label="LDL cholesterol" />);
        expect(screen.getByLabelText("LDL cholesterol")).toBeTruthy();
    });

    test("has default min=0", () => {
        render(<Subject label="LDL cholesterol" />);
        expect((screen.getByLabelText("LDL cholesterol") as HTMLInputElement).min).toBe("0");
    });

    test("has default max=10", () => {
        render(<Subject label="LDL cholesterol" />);
        expect((screen.getByLabelText("LDL cholesterol") as HTMLInputElement).max).toBe("10");
    });

    test("has default step=0.1", () => {
        render(<Subject label="LDL cholesterol" />);
        expect((screen.getByLabelText("LDL cholesterol") as HTMLInputElement).step).toBe("0.1");
    });

    test("supports disabled", () => {
        render(<Subject label="LDL cholesterol" disabled />);
        expect((screen.getByLabelText("LDL cholesterol") as HTMLInputElement).disabled).toBe(true);
    });

    test("supports required", () => {
        render(<Subject label="LDL cholesterol" required />);
        expect((screen.getByLabelText("LDL cholesterol") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(<Subject label="LDL cholesterol" data-testid="bt" />);
        expect(screen.getByTestId("bt")).toBeTruthy();
    });
});
