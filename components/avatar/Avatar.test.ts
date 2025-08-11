import { render, screen } from "@testing-library/svelte";
import { describe, expect, test } from "vitest";

import Subject from "./Avatar.svelte";

describe("Avatar", () => {
    test("renders with img role and aria-label", () => {
        render(Subject, { props: {
            alt: "Jane Doe",
        }});

        const avatar: HTMLElement = screen.getByRole("img", { name: "Jane Doe" });
        expect(avatar).toBeTruthy();
    });

    test("renders image when src is provided", () => {
        render(Subject, { props: {
            src: "/photo.jpg",
            alt: "Jane Doe",
        }});

        const img: HTMLElement | null = screen.queryByAltText("Jane Doe");
        expect(img).toBeTruthy();
        expect(img!.getAttribute("src")).toBe("/photo.jpg");
    });

    test("renders initials when no src is provided", () => {
        render(Subject, { props: {
            alt: "Jane Doe",
            initials: "JD",
        }});

        const avatar: HTMLElement = screen.getByRole("img", { name: "Jane Doe" });
        expect(avatar.textContent).toContain("JD");
    });

    test("initials span is aria-hidden", () => {
        render(Subject, { props: {
            alt: "Jane Doe",
            initials: "JD",
        }});

        const avatar: HTMLElement = screen.getByRole("img", { name: "Jane Doe" });
        const initialsSpan: HTMLElement | null = avatar.querySelector("span[aria-hidden]");
        expect(initialsSpan).toBeTruthy();
        expect(initialsSpan!.getAttribute("aria-hidden")).toBe("true");
    });

    test("renders nothing inside when no src and no initials", () => {
        render(Subject, { props: {
            alt: "Unknown User",
        }});

        const avatar: HTMLElement = screen.getByRole("img", { name: "Unknown User" });
        expect(avatar.querySelector("img")).toBeNull();
        expect(avatar.querySelector("span")).toBeNull();
    });

    test("passes through additional HTML attributes", () => {
        render(Subject, { props: {
            alt: "User",
            "data-testid": "avatar",
        }});

        const avatar: HTMLElement = screen.getByTestId("avatar");
        expect(avatar).toBeTruthy();
    });
});
