import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "../../components/BreadcrumbNavListItem.vue";


describe("BreadcrumbNavListItem", () => {
  test("renders a list item", () => {
    render(Subject, { props: { "data-testid": "bli" }, slots: { default: "Home" } });
    expect(screen.getByTestId("bli").tagName).toBe("LI");
  });

  test("renders children", () => {
    render(Subject, { slots: { default: "About" } });
    expect(screen.getByText("About")).toBeTruthy();
  });

  test("sets aria-current for current page", () => {
    render(Subject, { props: { current: true,
        "data-testid": "c" }, slots: { default: "Here" } });
    expect(screen.getByTestId("c").getAttribute("aria-current")).toBe("page");
  });

  test("no aria-current when not current", () => {
    render(Subject, { props: { "data-testid": "nc" }, slots: { default: "Link" } });
    expect(screen.getByTestId("nc").getAttribute("aria-current")).toBeNull();
  });

  test("passes through attributes", () => {
    render(Subject, { props: { "data-testid": "item" }, slots: { default: "X" } });
    expect(screen.getByTestId("item")).toBeTruthy();
  });
});
