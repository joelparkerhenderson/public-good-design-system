import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignHeartRateBeatsPerMinuteInput";

describe("VitalSignHeartRateBeatsPerMinuteInput", () => {
    test("renders input with type number", () => {
        render(<Subject label="Heart rate" />);
        expect((screen.getByLabelText("Heart rate") as HTMLInputElement).type).toBe("number");
    });

    test("has aria-label from label prop", () => {
        render(<Subject label="Heart rate" />);
        expect(screen.getByLabelText("Heart rate")).toBeTruthy();
    });

    test("has default min=0", () => {
        render(<Subject label="Heart rate" />);
        expect((screen.getByLabelText("Heart rate") as HTMLInputElement).min).toBe("0");
    });

    test("has default max=300", () => {
        render(<Subject label="Heart rate" />);
        expect((screen.getByLabelText("Heart rate") as HTMLInputElement).max).toBe("300");
    });

    test("has default step=1", () => {
        render(<Subject label="Heart rate" />);
        expect((screen.getByLabelText("Heart rate") as HTMLInputElement).step).toBe("1");
    });

    test("supports disabled", () => {
        render(<Subject label="Heart rate" disabled />);
        expect((screen.getByLabelText("Heart rate") as HTMLInputElement).disabled).toBe(true);
    });

    test("supports required", () => {
        render(<Subject label="Heart rate" required />);
        expect((screen.getByLabelText("Heart rate") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(<Subject label="Heart rate" data-testid="pr" />);
        expect(screen.getByTestId("pr")).toBeTruthy();
    });
});
