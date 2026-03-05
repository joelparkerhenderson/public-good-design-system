import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignBodyTemperatureCelciusView";

describe("VitalSignBodyTemperatureCelciusView", () => {
    test("renders span with img role", () => {
        render(<Subject value={37.0} label="37.0 degrees Celsius" />);
        expect(screen.getByRole("img")).toBeTruthy();
    });

    test("has aria-label from label prop", () => {
        render(<Subject value={37.0} label="37.0 degrees Celsius" />);
        expect(screen.getByRole("img", { name: "37.0 degrees Celsius" })).toBeTruthy();
    });

    test("displays value as text content", () => {
        render(<Subject value={37.0} label="37.0 degrees Celsius" />);
        expect(screen.getByRole("img").textContent).toBe("37");
    });

    test("has data-value attribute", () => {
        render(<Subject value={37.0} label="37.0 degrees Celsius" />);
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("37");
    });

    test("passes through attributes", () => {
        render(<Subject value={37.0} label="T" data-testid="tv" />);
        expect(screen.getByTestId("tv")).toBeTruthy();
    });
});
