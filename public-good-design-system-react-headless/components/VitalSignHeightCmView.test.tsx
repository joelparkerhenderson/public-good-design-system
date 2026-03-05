import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignHeightCmView";

describe("VitalSignHeightCmView", () => {
    test("renders span with img role", () => {
        render(<Subject value={175} label="175 cm height" />);
        expect(screen.getByRole("img")).toBeTruthy();
    });

    test("has aria-label from label prop", () => {
        render(<Subject value={175} label="175 cm height" />);
        expect(screen.getByRole("img", { name: "175 cm height" })).toBeTruthy();
    });

    test("displays value as text content", () => {
        render(<Subject value={175} label="175 cm height" />);
        expect(screen.getByRole("img").textContent).toBe("175");
    });

    test("has data-value attribute", () => {
        render(<Subject value={175} label="175 cm height" />);
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("175");
    });

    test("passes through attributes", () => {
        render(<Subject value={175} label="R" data-testid="rv" />);
        expect(screen.getByTestId("rv")).toBeTruthy();
    });
});
