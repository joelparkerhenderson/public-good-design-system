import { describe, expect, test } from "vitest";
import { render } from "@testing-library/react";

import Subject from "./KanbanTableCol";

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

describe("KanbanTableCol", () => {
    test("renders a col element", () => {
        renderInColgroup();
        const col = document.querySelector("col");
        expect(col).toBeTruthy();
    });

    test("supports span attribute", () => {
        renderInColgroup({ span: 2 });
        const col = document.querySelector("col");
        expect(col?.getAttribute("span")).toBe("2");
    });

    test("has no span by default", () => {
        renderInColgroup();
        const col = document.querySelector("col");
        expect(col?.getAttribute("span")).toBeNull();
    });

    test("passes through attributes", () => {
        renderInColgroup({ "data-stage": "todo" });
        const col = document.querySelector("col");
        expect(col?.getAttribute("data-stage")).toBe("todo");
    });
});
