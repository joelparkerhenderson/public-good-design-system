import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignWeightKgInput.vue";

describe("VitalSignWeightKgInput", () => {
    test("renders a number input", () => {
        render(Subject, { props: { label: "Weight (kg)" } });
        expect((screen.getByLabelText("Weight (kg)") as HTMLInputElement).type).toBe("number");
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { label: "Weight (kg)" } });
        expect(screen.getByLabelText("Weight (kg)")).toBeTruthy();
    });

    test("default min=0, max=500, step=1", () => {
        render(Subject, { props: { label: "Weight (kg)" } });
        const input = screen.getByLabelText("Weight (kg)") as HTMLInputElement;
        expect(input.min).toBe("0");
        expect(input.max).toBe("500");
        expect(input.step).toBe("1");
    });

    test("disabled propagates", () => {
        render(Subject, { props: { label: "Weight (kg)", disabled: true } });
        expect((screen.getByLabelText("Weight (kg)") as HTMLInputElement).disabled).toBe(true);
    });

    test("required propagates", () => {
        render(Subject, { props: { label: "Weight (kg)", required: true } });
        expect((screen.getByLabelText("Weight (kg)") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "Weight (kg)", "data-testid": "wk" } });
        expect(screen.getByTestId("wk")).toBeTruthy();
    });
});
