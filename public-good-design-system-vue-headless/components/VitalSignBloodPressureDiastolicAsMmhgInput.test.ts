import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignBloodPressureDiastolicAsMmhgInput.vue";

describe("VitalSignBloodPressureDiastolicAsMmhgInput", () => {
    test("renders a number input", () => {
        render(Subject, { props: { label: "Diastolic blood pressure" } });
        expect((screen.getByLabelText("Diastolic blood pressure") as HTMLInputElement).type).toBe("number");
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { label: "Diastolic blood pressure (mmHg)" } });
        expect(screen.getByLabelText("Diastolic blood pressure (mmHg)")).toBeTruthy();
    });

    test("default min=0, max=200, step=1", () => {
        render(Subject, { props: { label: "Diastolic blood pressure" } });
        const input = screen.getByLabelText("Diastolic blood pressure") as HTMLInputElement;
        expect(input.min).toBe("0");
        expect(input.max).toBe("200");
        expect(input.step).toBe("1");
    });

    test("disabled propagates", () => {
        render(Subject, { props: { label: "Diastolic blood pressure", disabled: true } });
        expect((screen.getByLabelText("Diastolic blood pressure") as HTMLInputElement).disabled).toBe(true);
    });

    test("required propagates", () => {
        render(Subject, { props: { label: "Diastolic blood pressure", required: true } });
        expect((screen.getByLabelText("Diastolic blood pressure") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "Diastolic blood pressure", "data-testid": "dbp" } });
        expect(screen.getByTestId("dbp")).toBeTruthy();
    });
});
