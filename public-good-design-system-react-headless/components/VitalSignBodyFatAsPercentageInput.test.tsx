import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignBodyFatAsPercentageInput";

describe("VitalSignBodyFatAsPercentageInput", () => {
    test("renders input with type number", () => {
        render(<Subject label="Body fat percentage" />);
        expect((screen.getByLabelText("Body fat percentage") as HTMLInputElement).type).toBe("number");
    });

    test("has aria-label from label prop", () => {
        render(<Subject label="Body fat percentage" />);
        expect(screen.getByLabelText("Body fat percentage")).toBeTruthy();
    });

    test("has default min=0", () => {
        render(<Subject label="Body fat percentage" />);
        expect((screen.getByLabelText("Body fat percentage") as HTMLInputElement).min).toBe("0");
    });

    test("has default max=100", () => {
        render(<Subject label="Body fat percentage" />);
        expect((screen.getByLabelText("Body fat percentage") as HTMLInputElement).max).toBe("100");
    });

    test("has default step=0.1", () => {
        render(<Subject label="Body fat percentage" />);
        expect((screen.getByLabelText("Body fat percentage") as HTMLInputElement).step).toBe("0.1");
    });

    test("supports disabled", () => {
        render(<Subject label="Body fat percentage" disabled />);
        expect((screen.getByLabelText("Body fat percentage") as HTMLInputElement).disabled).toBe(true);
    });

    test("supports required", () => {
        render(<Subject label="Body fat percentage" required />);
        expect((screen.getByLabelText("Body fat percentage") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(<Subject label="Body fat percentage" data-testid="bt" />);
        expect(screen.getByTestId("bt")).toBeTruthy();
    });
});
