import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignCholesterolAsHdlMmolPerLitreInput";

describe("VitalSignCholesterolAsHdlMmolPerLitreInput", () => {
    test("renders input with type number", () => {
        render(<Subject label="HDL cholesterol" />);
        expect((screen.getByLabelText("HDL cholesterol") as HTMLInputElement).type).toBe("number");
    });

    test("has aria-label from label prop", () => {
        render(<Subject label="HDL cholesterol" />);
        expect(screen.getByLabelText("HDL cholesterol")).toBeTruthy();
    });

    test("has default min=0", () => {
        render(<Subject label="HDL cholesterol" />);
        expect((screen.getByLabelText("HDL cholesterol") as HTMLInputElement).min).toBe("0");
    });

    test("has default max=10", () => {
        render(<Subject label="HDL cholesterol" />);
        expect((screen.getByLabelText("HDL cholesterol") as HTMLInputElement).max).toBe("10");
    });

    test("has default step=0.1", () => {
        render(<Subject label="HDL cholesterol" />);
        expect((screen.getByLabelText("HDL cholesterol") as HTMLInputElement).step).toBe("0.1");
    });

    test("supports disabled", () => {
        render(<Subject label="HDL cholesterol" disabled />);
        expect((screen.getByLabelText("HDL cholesterol") as HTMLInputElement).disabled).toBe(true);
    });

    test("supports required", () => {
        render(<Subject label="HDL cholesterol" required />);
        expect((screen.getByLabelText("HDL cholesterol") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(<Subject label="HDL cholesterol" data-testid="bt" />);
        expect(screen.getByTestId("bt")).toBeTruthy();
    });
});
