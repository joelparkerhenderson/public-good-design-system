import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./TelInput.vue";

describe("TelInput", () => {
    test("renders a tel input", () => {
        render(Subject, { props: { label: "Phone" } });
        expect((screen.getByLabelText("Phone") as HTMLInputElement).type).toBe("tel");
    });

    test("has autocomplete tel", () => {
        render(Subject, { props: { label: "Phone" } });
        expect(screen.getByLabelText("Phone").getAttribute("autocomplete")).toBe("tel");
    });

    test("supports required", () => {
        render(Subject, { props: { label: "Phone", required: true } });
        expect((screen.getByLabelText("Phone") as HTMLInputElement).required).toBe(true);
    });

    test("supports disabled", () => {
        render(Subject, { props: { label: "Phone", disabled: true } });
        expect((screen.getByLabelText("Phone") as HTMLInputElement).disabled).toBe(true);
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "P", "data-testid": "ti" } });
        expect(screen.getByTestId("ti")).toBeTruthy();
    });
});
