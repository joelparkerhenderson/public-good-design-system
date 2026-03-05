import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignBloodPressureSystolicInput.vue";

describe("VitalSignBloodPressureSystolicInput", () => {
    test("renders a number input", () => {
        render(Subject, { props: { label: "Systolic blood pressure" } });
        expect((screen.getByLabelText("Systolic blood pressure") as HTMLInputElement).type).toBe("number");
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { label: "Systolic blood pressure (mmHg)" } });
        expect(screen.getByLabelText("Systolic blood pressure (mmHg)")).toBeTruthy();
    });

    test("default min=0, max=300, step=1", () => {
        render(Subject, { props: { label: "Systolic blood pressure" } });
        const input = screen.getByLabelText("Systolic blood pressure") as HTMLInputElement;
        expect(input.min).toBe("0");
        expect(input.max).toBe("300");
        expect(input.step).toBe("1");
    });

    test("disabled propagates", () => {
        render(Subject, { props: { label: "Systolic blood pressure", disabled: true } });
        expect((screen.getByLabelText("Systolic blood pressure") as HTMLInputElement).disabled).toBe(true);
    });

    test("required propagates", () => {
        render(Subject, { props: { label: "Systolic blood pressure", required: true } });
        expect((screen.getByLabelText("Systolic blood pressure") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "Systolic blood pressure", "data-testid": "sbp" } });
        expect(screen.getByTestId("sbp")).toBeTruthy();
    });
});
