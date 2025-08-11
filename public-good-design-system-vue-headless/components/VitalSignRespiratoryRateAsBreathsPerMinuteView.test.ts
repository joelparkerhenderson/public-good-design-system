import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignRespiratoryRateAsBreathsPerMinuteView.vue";

describe("VitalSignRespiratoryRateAsBreathsPerMinuteView", () => {
    test("renders span with img role", () => {
        render(Subject, { props: { value: 16, label: "16 breaths per minute" } });
        expect(screen.getByRole("img", { name: "16 breaths per minute" })).toBeTruthy();
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { value: 20, label: "20 breaths per minute" } });
        expect(screen.getByRole("img").getAttribute("aria-label")).toBe("20 breaths per minute");
    });

    test("displays value as text content", () => {
        render(Subject, { props: { value: 16, label: "16 breaths per minute" } });
        expect(screen.getByRole("img").textContent).toBe("16");
    });

    test("has data-value attribute", () => {
        render(Subject, { props: { value: 22, label: "22 breaths per minute" } });
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("22");
    });

    test("passes through attributes", () => {
        render(Subject, { props: { value: 16, label: "16 breaths per minute", "data-testid": "rr" } });
        expect(screen.getByTestId("rr")).toBeTruthy();
    });
});
