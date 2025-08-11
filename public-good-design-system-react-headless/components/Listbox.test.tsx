import { render, screen } from "@testing-library/react";
import userEvent from "@testing-library/user-event";
import { describe, expect, test } from "vitest";

import Subject from "./Listbox";

const options = (
    <>
        <div role="option" tabIndex={-1}>Apple</div>
        <div role="option" tabIndex={-1}>Banana</div>
    </>
);

describe("Listbox", () => {
    test("renders a listbox", () => {
        render(<Subject label="Fruits">{options}</Subject>);
        expect(screen.getByRole("listbox")).toBeTruthy();
    });

    test("has aria-label", () => {
        render(<Subject label="Fruits">{options}</Subject>);
        expect(screen.getByLabelText("Fruits")).toBeTruthy();
    });

    test("renders option children", () => {
        render(<Subject label="Fruits">{options}</Subject>);
        expect(screen.getAllByRole("option").length).toBe(2);
    });

    test("arrow down navigates to next option", async () => {
        const user = userEvent.setup();
        render(<Subject label="Fruits">{options}</Subject>);
        const opts = screen.getAllByRole("option");
        opts[0].focus();
        await user.keyboard("{ArrowDown}");
        expect(document.activeElement).toBe(opts[1]);
    });

    test("passes through attributes", () => {
        render(<Subject label="F" data-testid="lb">{options}</Subject>);
        expect(screen.getByTestId("lb")).toBeTruthy();
    });
});
