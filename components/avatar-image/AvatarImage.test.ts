import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./AvatarImage.svelte";

describe("AvatarImage", () => {
    test("renders an img element", () => {
        render(Subject, { props: { src: "/photo.jpg", alt: "Jane Doe" } });
        const img = screen.getByRole("img");
        expect(img.tagName).toBe("IMG");
    });

    test("has correct src attribute", () => {
        render(Subject, { props: { src: "/photo.jpg", alt: "Jane Doe" } });
        const img = screen.getByRole("img") as HTMLImageElement;
        expect(img.getAttribute("src")).toBe("/photo.jpg");
    });

    test("has correct alt attribute", () => {
        render(Subject, { props: { src: "/photo.jpg", alt: "Jane Doe" } });
        const img = screen.getByAltText("Jane Doe");
        expect(img).toBeTruthy();
    });

    test("passes through additional HTML attributes", () => {
        render(Subject, { props: { src: "/photo.jpg", alt: "Jane Doe", "data-testid": "avatar-img" } });
        expect(screen.getByTestId("avatar-img")).toBeTruthy();
    });

    test("passes through width and height", () => {
        render(Subject, { props: { src: "/photo.jpg", alt: "Jane Doe", width: "48", height: "48" } });
        const img = screen.getByRole("img") as HTMLImageElement;
        expect(img.getAttribute("width")).toBe("48");
        expect(img.getAttribute("height")).toBe("48");
    });
});
