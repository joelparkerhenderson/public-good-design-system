import { describe, expect, test } from "vitest";
import { render } from "@testing-library/react";

import Subject from "./DataTableCol";

function renderInColgroup(props: Record<string, unknown> = {}) {
    return render(
        <table>
            <colgroup>
                <Subject {...props} />
            </colgroup>
            <tbody><tr><td>cell</td></tr></tbody>
        </table>
    );
}

describe("DataTableCol", () => {
    test("renders a col element", () => {
        renderInColgroup();
        const col = document.querySelector("col");
        expect(col).toBeTruthy();
    });

    test("supports span attribute", () => {
        renderInColgroup({ span: 3 });
        const col = document.querySelector("col");
        expect(col?.getAttribute("span")).toBe("3");
    });

    test("has no span by default", () => {
        renderInColgroup();
        const col = document.querySelector("col");
        expect(col?.getAttribute("span")).toBeNull();
    });

    test("passes through attributes", () => {
        renderInColgroup({ "data-testid": "col" });
        const col = document.querySelector("col");
        expect(col?.getAttribute("data-testid")).toBe("col");
    });
});
