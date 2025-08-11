import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignHeartRateVariabilityInput.vue";

describe("VitalSignHeartRateVariabilityInput", () => {
    test("renders a number input", () => {
        render(Subject, { props: { label: "HRV" } });
        expect((screen.getByLabelText("HRV") as HTMLInputElement).type).toBe("number");
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { label: "HRV (ms)" } });
        expect(screen.getByLabelText("HRV (ms)")).toBeTruthy();
    });

    test("default min=0, max=500, step=1", () => {
        render(Subject, { props: { label: "HRV" } });
        const input = screen.getByLabelText("HRV") as HTMLInputElement;
        expect(input.min).toBe("0");
        expect(input.max).toBe("500");
        expect(input.step).toBe("1");
    });

    test("disabled propagates", () => {
        render(Subject, { props: { label: "HRV", disabled: true } });
        expect((screen.getByLabelText("HRV") as HTMLInputElement).disabled).toBe(true);
    });

    test("required propagates", () => {
        render(Subject, { props: { label: "HRV", required: true } });
        expect((screen.getByLabelText("HRV") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "HRV", "data-testid": "pr" } });
        expect(screen.getByTestId("pr")).toBeTruthy();
    });
});
