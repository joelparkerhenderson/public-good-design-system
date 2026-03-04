import { render, screen } from "@testing-library/vue";
import { describe, expect, test } from "vitest";

import Subject from "./GrailLayoutRightAside.vue";

describe("GrailLayoutRightAside", () => {
    test("renders a div", () => {
        render(Subject, { slots: { default: "Content" } });
        expect(document.querySelector(".grail-layout-right-aside")).toBeTruthy();
    });

    test("renders children", () => {
        render(Subject, { slots: { default: "Content" } });
        expect(screen.getByText("Content")).toBeTruthy();
    });

    test("passes through attributes", () => {
        render(Subject, { props: { "data-testid": "test" }, slots: { default: "Content" } });
        expect(screen.getByTestId("test")).toBeTruthy();
    });
});
