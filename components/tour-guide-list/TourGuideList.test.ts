import { render, screen } from "@testing-library/svelte";
import { describe, expect, test, vi } from "vitest";

import Subject from "./TourGuideList.svelte";

function textSnippet(text: string) {
  return (($anchor: Comment) => {
    const node = document.createTextNode(text);
    $anchor.before(node);
  }) as any;
}

describe("TourGuideList", () => {
  test("not visible when inactive", () => {
    render(Subject, {
      props: {
        label: "TourGuideList",
        active: false,
        children: textSnippet("content"),
      },
    });
    expect(screen.queryByRole("dialog")).toBeNull();
  });

  test("visible when active", () => {
    render(Subject, {
      props: {
        label: "TourGuideList",
        active: true,
        children: textSnippet("content"),
      },
    });
    expect(screen.getByRole("dialog")).toBeTruthy();
  });

  test("has aria-label", () => {
    render(Subject, {
      props: {
        label: "Getting started",
        active: true,
        children: textSnippet("content"),
      },
    });
    expect(screen.getByLabelText("Getting started")).toBeTruthy();
  });

  test("closes on Escape", async () => {
    render(Subject, {
      props: {
        label: "TourGuideList",
        active: true,
        children: textSnippet("content"),
      },
    });
    const dialog = screen.getByRole("dialog");
    dialog.focus();
    dialog.dispatchEvent(
      new KeyboardEvent("keydown", { key: "Escape", bubbles: true }),
    );
    await vi.waitFor(() => expect(screen.queryByRole("dialog")).toBeNull());
  });

  test("passes through attributes", () => {
    render(Subject, {
      props: {
        label: "T",
        active: true,
        "data-testid": "tour-guide",
        children: textSnippet("x"),
      },
    });
    expect(screen.getByTestId("tour-guide")).toBeTruthy();
  });
});
