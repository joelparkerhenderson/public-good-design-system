import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./MedicalRecordRedBox.svelte";

// Helper to create a Svelte 5 snippet for children content.
function textSnippet(text: string) {
  return (($$anchor: Comment) => {
    const node = document.createTextNode(text);
    $$anchor.before(node);
  }) as any;
}

describe("MedicalRecordRedBox", () => {
  test("renders with alert role", () => {
    render(Subject, {
      props: { label: "Danger", children: textSnippet("Critical") },
    });
    expect(screen.getByRole("alert")).toBeTruthy();
  });

  test("has aria-label", () => {
    render(Subject, {
      props: { label: "Critical allergy", children: textSnippet("Content") },
    });
    expect(screen.getByRole("alert").getAttribute("aria-label")).toBe(
      "Critical allergy",
    );
  });

  test("renders children", () => {
    render(Subject, {
      props: { label: "Danger", children: textSnippet("Allergy to latex") },
    });
    expect(screen.getByRole("alert").textContent).toContain("Allergy to latex");
  });

  test("renders as aside element", () => {
    render(Subject, {
      props: { label: "Danger", children: textSnippet("Content") },
    });
    expect(screen.getByRole("alert").tagName).toBe("ASIDE");
  });

  test("passes through attributes", () => {
    render(Subject, {
      props: { label: "D", "data-testid": "mpbdb", children: textSnippet("C") },
    });
    expect(screen.getByTestId("mpbdb")).toBeTruthy();
  });
});
