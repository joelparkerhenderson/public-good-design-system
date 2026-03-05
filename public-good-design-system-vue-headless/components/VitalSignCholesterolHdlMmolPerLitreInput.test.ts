import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignCholesterolHdlMmolPerLitreInput.vue";

describe("VitalSignCholesterolHdlMmolPerLitreInput", () => {
    test("renders a number input", () => {
        render(Subject, { props: { label: "HDL cholesterol" } });
        expect((screen.getByLabelText("HDL cholesterol") as HTMLInputElement).type).toBe("number");
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { label: "HDL cholesterol (mmol/L)" } });
        expect(screen.getByLabelText("HDL cholesterol (mmol/L)")).toBeTruthy();
    });

    test("default min=0, max=10, step=0.1", () => {
        render(Subject, { props: { label: "HDL cholesterol" } });
        const input = screen.getByLabelText("HDL cholesterol") as HTMLInputElement;
        expect(input.min).toBe("0");
        expect(input.max).toBe("10");
        expect(input.step).toBe("0.1");
    });

    test("disabled propagates", () => {
        render(Subject, { props: { label: "HDL cholesterol", disabled: true } });
        expect((screen.getByLabelText("HDL cholesterol") as HTMLInputElement).disabled).toBe(true);
    });

    test("required propagates", () => {
        render(Subject, { props: { label: "HDL cholesterol", required: true } });
        expect((screen.getByLabelText("HDL cholesterol") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "HDL cholesterol", "data-testid": "hdl" } });
        expect(screen.getByTestId("hdl")).toBeTruthy();
    });
});
