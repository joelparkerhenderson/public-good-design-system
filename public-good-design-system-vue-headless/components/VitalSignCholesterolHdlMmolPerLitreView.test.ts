import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignCholesterolHdlMmolPerLitreView.vue";

describe("VitalSignCholesterolHdlMmolPerLitreView", () => {
    test("renders span with img role", () => {
        render(Subject, { props: { value: 1.5, label: "1.5 mmol/L HDL cholesterol" } });
        expect(screen.getByRole("img", { name: "1.5 mmol/L HDL cholesterol" })).toBeTruthy();
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { value: 1.5, label: "1.5 mmol/L HDL cholesterol" } });
        expect(screen.getByRole("img").getAttribute("aria-label")).toBe("1.5 mmol/L HDL cholesterol");
    });

    test("displays value as text content", () => {
        render(Subject, { props: { value: 1.5, label: "1.5 mmol/L HDL cholesterol" } });
        expect(screen.getByRole("img").textContent).toBe("1.5");
    });

    test("has data-value attribute", () => {
        render(Subject, { props: { value: 1.5, label: "1.5 mmol/L HDL cholesterol" } });
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("1.5");
    });

    test("passes through attributes", () => {
        render(Subject, { props: { value: 1.5, label: "1.5 mmol/L HDL cholesterol", "data-testid": "hdl" } });
        expect(screen.getByTestId("hdl")).toBeTruthy();
    });
});
