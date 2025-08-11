import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignRespiratoryRateAsBreathsPerMinuteInput.vue";

describe("VitalSignRespiratoryRateAsBreathsPerMinuteInput", () => {
    test("renders a number input", () => {
        render(Subject, { props: { label: "Respiratory rate" } });
        expect((screen.getByLabelText("Respiratory rate") as HTMLInputElement).type).toBe("number");
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { label: "Respiratory rate (breaths/min)" } });
        expect(screen.getByLabelText("Respiratory rate (breaths/min)")).toBeTruthy();
    });

    test("default min=0, max=100, step=1", () => {
        render(Subject, { props: { label: "Respiratory rate" } });
        const input = screen.getByLabelText("Respiratory rate") as HTMLInputElement;
        expect(input.min).toBe("0");
        expect(input.max).toBe("100");
        expect(input.step).toBe("1");
    });

    test("disabled propagates", () => {
        render(Subject, { props: { label: "Respiratory rate", disabled: true } });
        expect((screen.getByLabelText("Respiratory rate") as HTMLInputElement).disabled).toBe(true);
    });

    test("required propagates", () => {
        render(Subject, { props: { label: "Respiratory rate", required: true } });
        expect((screen.getByLabelText("Respiratory rate") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "Respiratory rate", "data-testid": "rr" } });
        expect(screen.getByTestId("rr")).toBeTruthy();
    });
});
