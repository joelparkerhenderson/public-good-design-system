import { render, screen } from "@testing-library/react";
import { describe, expect, test } from "vitest";

import Subject from "./MedicalRecordRedBox";

describe("MedicalRecordRedBox", () => {
  test("renders with alert role", () => {
    render(<Subject label="Danger">Critical</Subject>);
    expect(screen.getByRole("alert")).toBeTruthy();
  });

  test("has aria-label", () => {
    render(<Subject label="Critical allergy">Content</Subject>);
    expect(screen.getByRole("alert").getAttribute("aria-label")).toBe(
      "Critical allergy",
    );
  });

  test("renders children", () => {
    render(<Subject label="Danger">Allergy to latex</Subject>);
    expect(screen.getByRole("alert").textContent).toContain("Allergy to latex");
  });

  test("renders as aside element", () => {
    render(<Subject label="Danger">Content</Subject>);
    expect(screen.getByRole("alert").tagName).toBe("ASIDE");
  });

  test("passes through attributes", () => {
    render(<Subject label="D" data-testid="mpbdb">C</Subject>);
    expect(screen.getByTestId("mpbdb")).toBeTruthy();
  });
});
