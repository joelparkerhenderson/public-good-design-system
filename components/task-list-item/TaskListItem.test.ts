import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./TaskListItem.svelte";

function textSnippet(text: string) {
    return (($$anchor: Comment) => {
        const node = document.createTextNode(text);
        $$anchor.before(node);
    }) as any;
}

describe("TaskListItem", () => {
    test("renders a list item element", () => {
        render(Subject, { props: {
            children: textSnippet("Review code"),
        }});

        const item = screen.getByRole("listitem");
        expect(item.tagName).toBe("LI");
    });

    test("renders children content", () => {
        render(Subject, { props: {
            children: textSnippet("Update documentation"),
        }});

        const item = screen.getByRole("listitem");
        expect(item.textContent).toContain("Update documentation");
    });

    test("defaults completed to false", () => {
        render(Subject, { props: {
            children: textSnippet("Deploy"),
        }});

        const item = screen.getByRole("listitem");
        expect(item.getAttribute("data-completed")).toBe("false");
    });

    test("sets data-completed=true when completed", () => {
        render(Subject, { props: {
            completed: true,
            children: textSnippet("Review code"),
        }});

        const item = screen.getByRole("listitem");
        expect(item.getAttribute("data-completed")).toBe("true");
    });

    test("sets data-completed=false when not completed", () => {
        render(Subject, { props: {
            completed: false,
            children: textSnippet("Deploy"),
        }});

        const item = screen.getByRole("listitem");
        expect(item.getAttribute("data-completed")).toBe("false");
    });

    test("passes through additional HTML attributes", () => {
        render(Subject, { props: {
            "data-testid": "task-item",
            children: textSnippet("Write tests"),
        }});

        const item = screen.getByTestId("task-item");
        expect(item).toBeTruthy();
    });

    test("passes through id attribute", () => {
        render(Subject, { props: {
            id: "task-1",
            children: textSnippet("Fix bug"),
        }});

        const item = screen.getByRole("listitem");
        expect(item.getAttribute("id")).toBe("task-1");
    });
});
