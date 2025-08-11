import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";
import Subject from "./TimePicker.svelte";
describe("TimePicker", () => {
    test("renders a time input", () => { render(Subject, { props: { label: "Time" } }); expect((screen.getByLabelText("Time") as HTMLInputElement).type).toBe("time"); });
    test("has aria-label", () => { render(Subject, { props: { label: "Start time" } }); expect(screen.getByLabelText("Start time")).toBeTruthy(); });
    test("supports disabled", () => { render(Subject, { props: { label: "Time", disabled: true } }); expect((screen.getByLabelText("Time") as HTMLInputElement).disabled).toBe(true); });
    test("passes through attributes", () => { render(Subject, { props: { label: "T", "data-testid": "tp" } }); expect(screen.getByTestId("tp")).toBeTruthy(); });
});
