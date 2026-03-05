import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignBodyTemperatureCelciusInput";

describe("VitalSignBodyTemperatureCelciusInput", () => {
    test("renders input with type number", () => {
        render(<Subject label="Body temperature" />);
        expect((screen.getByLabelText("Body temperature") as HTMLInputElement).type).toBe("number");
    });

    test("has aria-label from label prop", () => {
        render(<Subject label="Body temperature" />);
        expect(screen.getByLabelText("Body temperature")).toBeTruthy();
    });

    test("has default min=30", () => {
        render(<Subject label="Body temperature" />);
        expect((screen.getByLabelText("Body temperature") as HTMLInputElement).min).toBe("30");
    });

    test("has default max=45", () => {
        render(<Subject label="Body temperature" />);
        expect((screen.getByLabelText("Body temperature") as HTMLInputElement).max).toBe("45");
    });

    test("has default step=0.1", () => {
        render(<Subject label="Body temperature" />);
        expect((screen.getByLabelText("Body temperature") as HTMLInputElement).step).toBe("0.1");
    });

    test("supports disabled", () => {
        render(<Subject label="Body temperature" disabled />);
        expect((screen.getByLabelText("Body temperature") as HTMLInputElement).disabled).toBe(true);
    });

    test("supports required", () => {
        render(<Subject label="Body temperature" required />);
        expect((screen.getByLabelText("Body temperature") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(<Subject label="Body temperature" data-testid="bt" />);
        expect(screen.getByTestId("bt")).toBeTruthy();
    });
});
