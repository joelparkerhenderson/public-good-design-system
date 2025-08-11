import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./PaginationList";

const pageItems = (
    <>
        <li><a href="/page/1">1</a></li>
        <li><a href="/page/2">2</a></li>
        <li><a href="/page/3">3</a></li>
    </>
);

describe("PaginationList", () => {
    test("renders a navigation", () => {
        render(<Subject label="Pagination">{pageItems}</Subject>);
        expect(screen.getByRole("navigation")).toBeTruthy();
    });

    test("has aria-label", () => {
        render(<Subject label="Pages">{pageItems}</Subject>);
        expect(screen.getByLabelText("Pages")).toBeTruthy();
    });

    test("contains a list", () => {
        render(<Subject label="Pagination">{pageItems}</Subject>);
        expect(screen.getByRole("list")).toBeTruthy();
    });

    test("renders children links", () => {
        render(<Subject label="Pagination">{pageItems}</Subject>);
        expect(screen.getByText("1")).toBeTruthy();
        expect(screen.getByText("2")).toBeTruthy();
    });

    test("passes through attributes", () => {
        render(<Subject label="P" data-testid="pg">{pageItems}</Subject>);
        expect(screen.getByTestId("pg")).toBeTruthy();
    });
});
