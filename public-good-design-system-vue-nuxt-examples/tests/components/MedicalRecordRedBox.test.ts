import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "../../components/MedicalRecordRedBox.vue";


describe("MedicalRecordRedBox", () => {
  test("renders with alert role", () => {
    render(Subject, { props: { label: "Danger" }, slots: { default: "Critical" } });
    expect(screen.getByRole("alert")).toBeTruthy();
  });

  test("has aria-label", () => {
    render(Subject, { props: { label: "Critical allergy" }, slots: { default: "Content" } });
    expect(screen.getByRole("alert").getAttribute("aria-label")).toBe(
      "Critical allergy",
    );
  });

  test("renders children", () => {
    render(Subject, { props: { label: "Danger" }, slots: { default: "Allergy to latex" } });
    expect(screen.getByRole("alert").textContent).toContain("Allergy to latex");
  });

  test("renders as aside element", () => {
    render(Subject, { props: { label: "Danger" }, slots: { default: "Content" } });
    expect(screen.getByRole("alert").tagName).toBe("ASIDE");
  });

  test("passes through attributes", () => {
    render(Subject, { props: { label: "D", "data-testid": "mpbdb" }, slots: { default: "C" } });
    expect(screen.getByTestId("mpbdb")).toBeTruthy();
  });
});
