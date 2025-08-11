import { render, screen } from "@testing-library/svelte";
import { userEvent, type UserEvent } from "@testing-library/user-event";
import { describe, expect, test } from "vitest";

import Subject from "./FiveFaceRatingInput.svelte";

describe("FiveFaceRatingInput", () => {
    test("renders as a radiogroup", () => {
        render(Subject, { props: { label: "Experience" } });
        expect(screen.getByRole("radiogroup", { name: "Experience" })).toBeTruthy();
    });

    test("has 5 radio buttons", () => {
        render(Subject, { props: { label: "Experience" } });
        expect(screen.getAllByRole("radio")).toHaveLength(5);
    });

    test("has default labels", () => {
        render(Subject, { props: { label: "Experience" } });
        expect(screen.getByText("Very bad")).toBeTruthy();
        expect(screen.getByText("Very good")).toBeTruthy();
    });

    test("supports custom labels", () => {
        render(Subject, { props: { label: "E", labels: ["1", "2", "3", "4", "5"] } });
        expect(screen.getByText("1")).toBeTruthy();
        expect(screen.getByText("5")).toBeTruthy();
    });

    test("clicking selects a face", async () => {
        const user: UserEvent = userEvent.setup();
        render(Subject, { props: { label: "Experience" } });
        const radios = screen.getAllByRole("radio") as HTMLInputElement[];
        await user.click(radios[3]);
        expect(radios[3].checked).toBe(true);
    });

    test("passes through attributes", () => {
        render(Subject, { props: { label: "E", "data-testid": "fr" } });
        expect(screen.getByTestId("fr")).toBeTruthy();
    });
});
