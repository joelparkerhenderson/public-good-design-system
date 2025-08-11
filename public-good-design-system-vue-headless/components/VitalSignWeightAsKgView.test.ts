import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignWeightAsKgView.vue";

describe("VitalSignWeightAsKgView", () => {
    test("renders span with img role", () => {
        render(Subject, { props: { value: 75, label: "75 kg weight" } });
        expect(screen.getByRole("img", { name: "75 kg weight" })).toBeTruthy();
    });

    test("aria-label from label prop", () => {
        render(Subject, { props: { value: 60, label: "60 kg weight" } });
        expect(screen.getByRole("img").getAttribute("aria-label")).toBe("60 kg weight");
    });

    test("displays value as text content", () => {
        render(Subject, { props: { value: 75, label: "75 kg weight" } });
        expect(screen.getByRole("img").textContent).toBe("75");
    });

    test("has data-value attribute", () => {
        render(Subject, { props: { value: 80, label: "80 kg weight" } });
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("80");
    });

    test("passes through attributes", () => {
        render(Subject, { props: { value: 75, label: "75 kg weight", "data-testid": "vs" } });
        expect(screen.getByTestId("vs")).toBeTruthy();
    });
});
