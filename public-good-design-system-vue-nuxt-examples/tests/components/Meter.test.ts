import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "../../components/Meter.vue";

describe("Meter", () => {
    test("renders as a meter", () => {
        render(Subject, { props: { label: "Disk", value: 50, "data-testid": "meter" } });
        expect(screen.getByTestId("meter").tagName.toLowerCase()).toBe("meter");
    });

    test("has aria-label", () => {
        render(Subject, { props: { label: "Memory", value: 60, "data-testid": "meter" } });
        expect(screen.getByTestId("meter").getAttribute("aria-label")).toBe("Memory");
    });

    test("has correct value", () => {
        render(Subject, { props: { label: "M", value: 42, "data-testid": "m" } });
        expect((screen.getByTestId("m") as HTMLMeterElement).value).toBe(42);
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "M", value: 10, "data-testid": "m" } });
        expect(screen.getByTestId("m")).toBeTruthy();
    });
});
