import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignWaistCircumferenceCmView.vue";

describe("VitalSignWaistCircumferenceCmView", () => {
    test("renders span with img role", () => {
        render(Subject, { props: { value: 94, label: "94 cm waist circumference" } });
        expect(screen.getByRole("img", { name: "94 cm waist circumference" })).toBeTruthy();
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { value: 80, label: "80 cm waist circumference" } });
        expect(screen.getByRole("img").getAttribute("aria-label")).toBe("80 cm waist circumference");
    });

    test("displays value as text content", () => {
        render(Subject, { props: { value: 94, label: "94 cm waist circumference" } });
        expect(screen.getByRole("img").textContent).toBe("94");
    });

    test("has data-value attribute", () => {
        render(Subject, { props: { value: 95, label: "95 cm waist circumference" } });
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("95");
    });

    test("passes through attributes", () => {
        render(Subject, { props: { value: 94, label: "94 cm waist circumference", "data-testid": "vs" } });
        expect(screen.getByTestId("vs")).toBeTruthy();
    });
});
