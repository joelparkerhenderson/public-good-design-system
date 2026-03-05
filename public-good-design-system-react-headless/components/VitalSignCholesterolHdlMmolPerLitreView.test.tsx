import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignCholesterolHdlMmolPerLitreView";

describe("VitalSignCholesterolHdlMmolPerLitreView", () => {
    test("renders span with img role", () => {
        render(<Subject value={1.5} label="1.5 mmol/L HDL cholesterol" />);
        expect(screen.getByRole("img")).toBeTruthy();
    });

    test("has aria-label from label prop", () => {
        render(<Subject value={1.5} label="1.5 mmol/L HDL cholesterol" />);
        expect(screen.getByRole("img", { name: "1.5 mmol/L HDL cholesterol" })).toBeTruthy();
    });

    test("displays value as text content", () => {
        render(<Subject value={1.5} label="1.5 mmol/L HDL cholesterol" />);
        expect(screen.getByRole("img").textContent).toBe("1.5");
    });

    test("has data-value attribute", () => {
        render(<Subject value={1.5} label="1.5 mmol/L HDL cholesterol" />);
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("1.5");
    });

    test("passes through attributes", () => {
        render(<Subject value={1.5} label="T" data-testid="tv" />);
        expect(screen.getByTestId("tv")).toBeTruthy();
    });
});
