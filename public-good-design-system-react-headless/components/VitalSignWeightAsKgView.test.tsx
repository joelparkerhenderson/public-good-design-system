import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./VitalSignWeightAsKgView";

describe("VitalSignWeightAsKgView", () => {
    test("renders span with img role", () => {
        render(<Subject value={75} label="75 kg weight" />);
        expect(screen.getByRole("img")).toBeTruthy();
    });

    test("has aria-label from label prop", () => {
        render(<Subject value={75} label="75 kg weight" />);
        expect(screen.getByRole("img", { name: "75 kg weight" })).toBeTruthy();
    });

    test("displays value as text content", () => {
        render(<Subject value={75} label="75 kg weight" />);
        expect(screen.getByRole("img").textContent).toBe("75");
    });

    test("has data-value attribute", () => {
        render(<Subject value={75} label="75 kg weight" />);
        expect(screen.getByRole("img").getAttribute("data-value")).toBe("75");
    });

    test("passes through attributes", () => {
        render(<Subject value={75} label="R" data-testid="rv" />);
        expect(screen.getByTestId("rv")).toBeTruthy();
    });
});
