import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignHeartRateBeatsPerMinuteInput.vue";

describe("VitalSignHeartRateBeatsPerMinuteInput", () => {
    test("renders a number input", () => {
        render(Subject, { props: { label: "Heart rate" } });
        expect((screen.getByLabelText("Heart rate") as HTMLInputElement).type).toBe("number");
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { label: "Heart rate (BPM)" } });
        expect(screen.getByLabelText("Heart rate (BPM)")).toBeTruthy();
    });

    test("default min=0, max=300, step=1", () => {
        render(Subject, { props: { label: "Heart rate" } });
        const input = screen.getByLabelText("Heart rate") as HTMLInputElement;
        expect(input.min).toBe("0");
        expect(input.max).toBe("300");
        expect(input.step).toBe("1");
    });

    test("disabled propagates", () => {
        render(Subject, { props: { label: "Heart rate", disabled: true } });
        expect((screen.getByLabelText("Heart rate") as HTMLInputElement).disabled).toBe(true);
    });

    test("required propagates", () => {
        render(Subject, { props: { label: "Heart rate", required: true } });
        expect((screen.getByLabelText("Heart rate") as HTMLInputElement).required).toBe(true);
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "Heart rate", "data-testid": "pr" } });
        expect(screen.getByTestId("pr")).toBeTruthy();
    });
});
