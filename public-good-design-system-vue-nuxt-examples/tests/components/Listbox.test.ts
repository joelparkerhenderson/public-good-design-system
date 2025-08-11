import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "../../components/Listbox.vue";


describe("Listbox", () => {
    test("renders a listbox", () => {
        render(Subject, { props: { label: "Fruits" }, slots: { default: "<div role='option' tabindex='-1'>Apple</div><div role='option' tabindex='-1'>Banana</div>" } });
        expect(screen.getByRole("listbox")).toBeTruthy();
    });

    test("has aria-label", () => {
        render(Subject, { props: { label: "Fruits" }, slots: { default: "<div role='option' tabindex='-1'>Apple</div><div role='option' tabindex='-1'>Banana</div>" } });
        expect(screen.getByLabelText("Fruits")).toBeTruthy();
    });

    test("renders option children", () => {
        render(Subject, { props: { label: "Fruits" }, slots: { default: "<div role='option' tabindex='-1'>Apple</div><div role='option' tabindex='-1'>Banana</div>" } });
        expect(screen.getAllByRole("option").length).toBe(2);
    });

    test("arrow down navigates to next option", () => {
        render(Subject, { props: { label: "Fruits" }, slots: { default: "<div role='option' tabindex='-1'>Apple</div><div role='option' tabindex='-1'>Banana</div>" } });
        const options = screen.getAllByRole("option");
        options[0].focus();
        options[0].dispatchEvent(new KeyboardEvent("keydown", { key: "ArrowDown", bubbles: true }));
        expect(document.activeElement).toBe(options[1]);
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "F", "data-testid": "lb" }, slots: { default: "<div role='option' tabindex='-1'>Apple</div><div role='option' tabindex='-1'>Banana</div>" } });
        expect(screen.getByTestId("lb")).toBeTruthy();
    });
});
