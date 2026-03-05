import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignWaistCircumferenceCmInput.vue";

describe("VitalSignWaistCircumferenceCmInput", () => {
    test("renders a number input", () => {
        render(Subject, { props: { label: "Waist circumference (cm)" } });
        expect((screen.getByLabelText("Waist circumference (cm)") as HTMLInputElement).type).toBe("number");
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { label: "Waist circumference (cm)" } });
        expect(screen.getByLabelText("Waist circumference (cm)")).toBeTruthy();
    });

    test("default min=0, max=300, step=1", () => {
        render(Subject, { props: { label: "Waist circumference (cm)" } });
        const input = screen.getByLabelText("Waist circumference (cm)") as HTMLInputElement;
        expect(input.min).toBe("0");
        expect(input.max).toBe("300");
        expect(input.step).toBe("1");
    });

    test("disabled propagates", () => {
        render(Subject, { props: { label: "Waist circumference (cm)", disabled: true } });
        expect((screen.getByLabelText("Waist circumference (cm)") as HTMLInputElement).disabled).toBe(true);
    });

    test("required propagates", () => {
        render(Subject, { props: { label: "Waist circumference (cm)", required: true } });
        expect((screen.getByLabelText("Waist circumference (cm)") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "Waist circumference (cm)", "data-testid": "wc" } });
        expect(screen.getByTestId("wc")).toBeTruthy();
    });
});
