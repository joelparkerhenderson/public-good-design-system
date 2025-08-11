import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignHeartRateAsBeatsPerMinuteView.vue";

describe("VitalSignHeartRateAsBeatsPerMinuteView", () => {
    test("renders span with img role", () => {
        render(Subject, { props: { value: 72, label: "72 bpm" } });
        expect(screen.getByRole("img", { name: "72 bpm" })).toBeTruthy();
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { value: 80, label: "80 beats per minute" } });
        expect(screen.getByRole("img").getAttribute("aria-label")).toBe("80 beats per minute");
    });

    test("displays value as text content", () => {
        render(Subject, { props: { value: 72, label: "72 bpm" } });
        expect(screen.getByRole("img").textContent).toBe("72");
    });

    test("has data-value attribute", () => {
        render(Subject, { props: { value: 95, label: "95 bpm" } });
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("95");
    });

    test("passes through attributes", () => {
        render(Subject, { props: { value: 72, label: "72 bpm", "data-testid": "vs" } });
        expect(screen.getByTestId("vs")).toBeTruthy();
    });
});
