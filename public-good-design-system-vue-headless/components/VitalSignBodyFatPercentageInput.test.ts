import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignBodyFatPercentageInput.vue";

describe("VitalSignBodyFatPercentageInput", () => {
    test("renders a number input", () => {
        render(Subject, { props: { label: "Body fat percentage" } });
        expect((screen.getByLabelText("Body fat percentage") as HTMLInputElement).type).toBe("number");
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { label: "Body fat percentage (%)" } });
        expect(screen.getByLabelText("Body fat percentage (%)")).toBeTruthy();
    });

    test("default min=0, max=100, step=0.1", () => {
        render(Subject, { props: { label: "Body fat percentage" } });
        const input = screen.getByLabelText("Body fat percentage") as HTMLInputElement;
        expect(input.min).toBe("0");
        expect(input.max).toBe("100");
        expect(input.step).toBe("0.1");
    });

    test("disabled propagates", () => {
        render(Subject, { props: { label: "Body fat percentage", disabled: true } });
        expect((screen.getByLabelText("Body fat percentage") as HTMLInputElement).disabled).toBe(true);
    });

    test("required propagates", () => {
        render(Subject, { props: { label: "Body fat percentage", required: true } });
        expect((screen.getByLabelText("Body fat percentage") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "Body fat percentage", "data-testid": "bfp" } });
        expect(screen.getByTestId("bfp")).toBeTruthy();
    });
});
