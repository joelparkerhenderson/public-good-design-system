import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignBodyFatPercentageView.vue";

describe("VitalSignBodyFatPercentageView", () => {
    test("renders span with img role", () => {
        render(Subject, { props: { value: 22.5, label: "22.5 percent body fat" } });
        expect(screen.getByRole("img", { name: "22.5 percent body fat" })).toBeTruthy();
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { value: 22.5, label: "22.5 percent body fat" } });
        expect(screen.getByRole("img").getAttribute("aria-label")).toBe("22.5 percent body fat");
    });

    test("displays value as text content", () => {
        render(Subject, { props: { value: 22.5, label: "22.5 percent body fat" } });
        expect(screen.getByRole("img").textContent).toBe("22.5");
    });

    test("has data-value attribute", () => {
        render(Subject, { props: { value: 22.5, label: "22.5 percent body fat" } });
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("22.5");
    });

    test("passes through attributes", () => {
        render(Subject, { props: { value: 22.5, label: "22.5 percent body fat", "data-testid": "bfp" } });
        expect(screen.getByTestId("bfp")).toBeTruthy();
    });
});
