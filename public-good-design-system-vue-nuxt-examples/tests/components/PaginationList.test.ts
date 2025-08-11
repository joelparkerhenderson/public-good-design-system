import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "../../components/PaginationList.vue";


describe("PaginationList", () => {
    test("renders a navigation", () => {
        render(Subject, { props: { label: "Pagination" }, slots: { default: "<a>1</a><a>2</a>" } });
        expect(screen.getByRole("navigation")).toBeTruthy();
    });

    test("has aria-label", () => {
        render(Subject, { props: { label: "Pages" }, slots: { default: "<a>1</a><a>2</a>" } });
        expect(screen.getByLabelText("Pages")).toBeTruthy();
    });

    test("contains a list", () => {
        render(Subject, { props: { label: "Pagination" }, slots: { default: "<a>1</a><a>2</a>" } });
        expect(screen.getByRole("list")).toBeTruthy();
    });

    test("renders children links", () => {
        render(Subject, { props: { label: "Pagination" }, slots: { default: "<a>1</a><a>2</a>" } });
        expect(screen.getByText("1")).toBeTruthy();
        expect(screen.getByText("2")).toBeTruthy();
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "P", "data-testid": "pg" }, slots: { default: "<a>1</a><a>2</a>" } });
        expect(screen.getByTestId("pg")).toBeTruthy();
    });
});
