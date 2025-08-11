import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./ThemeSelectOption.svelte";

function textSnippet(text: string) {
    return (($anchor: Comment) => {
        const node = document.createTextNode(text);
        $anchor.before(node);
    }) as any;
}

describe("ThemeSelectOption", () => {
    test("renders an option element", () => {
        render(Subject, {
            props: {
                value: "dark",
                children: textSnippet("Dark"),
            },
        });
        const option = screen.getByRole("option");
        expect(option.tagName).toBe("OPTION");
    });

    test("has correct value attribute", () => {
        render(Subject, {
            props: {
                value: "light",
                children: textSnippet("Light"),
            },
        });
        const option = screen.getByRole("option") as HTMLOptionElement;
        expect(option.value).toBe("light");
    });

    test("renders children text", () => {
        render(Subject, {
            props: {
                value: "dark",
                children: textSnippet("Dark Mode"),
            },
        });
        expect(screen.getByText("Dark Mode")).toBeTruthy();
    });

    test("supports disabled", () => {
        render(Subject, {
            props: {
                value: "",
                disabled: true,
                children: textSnippet("Choose..."),
            },
        });
        const option = screen.getByRole("option") as HTMLOptionElement;
        expect(option.disabled).toBe(true);
    });

    test("passes through additional attributes", () => {
        render(Subject, {
            props: {
                value: "dark",
                "data-testid": "theme-opt",
                children: textSnippet("Dark"),
            },
        });
        expect(screen.getByTestId("theme-opt")).toBeTruthy();
    });
});
