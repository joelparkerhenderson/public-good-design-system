import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignBodyTemperatureCelciusInput.vue";

describe("VitalSignBodyTemperatureCelciusInput", () => {
    test("renders a number input", () => {
        render(Subject, { props: { label: "Body temperature" } });
        expect((screen.getByLabelText("Body temperature") as HTMLInputElement).type).toBe("number");
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { label: "Body temperature (°C)" } });
        expect(screen.getByLabelText("Body temperature (°C)")).toBeTruthy();
    });

    test("default min=30, max=45, step=0.1", () => {
        render(Subject, { props: { label: "Body temperature" } });
        const input = screen.getByLabelText("Body temperature") as HTMLInputElement;
        expect(input.min).toBe("30");
        expect(input.max).toBe("45");
        expect(input.step).toBe("0.1");
    });

    test("disabled propagates", () => {
        render(Subject, { props: { label: "Body temperature", disabled: true } });
        expect((screen.getByLabelText("Body temperature") as HTMLInputElement).disabled).toBe(true);
    });

    test("required propagates", () => {
        render(Subject, { props: { label: "Body temperature", required: true } });
        expect((screen.getByLabelText("Body temperature") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "Body temperature", "data-testid": "bt" } });
        expect(screen.getByTestId("bt")).toBeTruthy();
    });
});
