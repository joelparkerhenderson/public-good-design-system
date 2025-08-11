import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignHeartRateVariabilityView.vue";

describe("VitalSignHeartRateVariabilityView", () => {
    test("renders span with img role", () => {
        render(Subject, { props: { value: 45, label: "45 milliseconds HRV" } });
        expect(screen.getByRole("img", { name: "45 milliseconds HRV" })).toBeTruthy();
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { value: 60, label: "60 milliseconds HRV" } });
        expect(screen.getByRole("img").getAttribute("aria-label")).toBe("60 milliseconds HRV");
    });

    test("displays value as text content", () => {
        render(Subject, { props: { value: 45, label: "45 milliseconds HRV" } });
        expect(screen.getByRole("img").textContent).toBe("45");
    });

    test("has data-value attribute", () => {
        render(Subject, { props: { value: 80, label: "80 milliseconds HRV" } });
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("80");
    });

    test("passes through attributes", () => {
        render(Subject, { props: { value: 45, label: "45 milliseconds HRV", "data-testid": "vs" } });
        expect(screen.getByTestId("vs")).toBeTruthy();
    });
});
