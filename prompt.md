# NHS UK Design System to Public Good Design System

Convert from "NHS UK Design System" with Nunjucks to "Public Good Design System" with Svelte 5 SvelteKit.

Create comprehensive project-level documentation explaining the conversion approach and component usage.

# Directories
- NHS UK Design System input directory is `./nhsuk-frontend`; this is already present on the system.
- Public Good Design System output directory is `./public-good-design-system-with-svelte`; create this SvelteKit project in the specified directory.

# Fetch
- Fetch NHS UK Design System components content from `https://service-manual.nhs.uk/design-system/components`.
- Fetch NHS UK front end content from `https://github.com/nhsuk/nhsuk-frontend`.
- Fetch Tailwind CSS documentation from `https://tailwindcss.com/docs/installation/using-vite`

# Svelte
- Use the Svelte documentation reference file `./svelte-documentation-llms-small.txt` as a reference for best practices when converting components; this file exists in the current directory.
- Create new SvelteKit project using the command `npx sv create public-good-design-system-with-svelte --template minimal --types ts --no-add-ons`; proceed with creating the SvelteKit project immediately.
- Prioritize creating a working SvelteKit foundation first (basic SvelteKit setup, Tailwind, DaisyUI)
- Convert from NHS UK Design System folder structure into SvelteKit best practices folder structure.

# Tailwind CSS
- For the Tailwind CSS conversion, set up Tailwind CSS in the SvelteKit project.
- For Tailwind CSS configuration preferences, use the default setup.

# DaisyUI
- For DaisyUI documentation use file `./daisyui-documentation-llms.txt` which already exists on the system.
- For DaisyUI CSS configuration preferences, use the default setup.

# Branding
- Rename branding from "NHS UK" to "Public Good"
- Rename branding from "nhsuk" to "public-good"
- Rename branding prefix from "nhsuk-" to "public-good-"

# Components
- We need to convert each component from NHS UK Design System with Nunjucks to Public Good Design System with Svelte.
- Explore the director `./nhsuk-frontend` to understand the existing components before starting the conversion.
- Analyze all NHS UK components to create a comprehensive plan to convert all components one by one in strict alphabetic order without any priority order.
- Change the styling and functionality from global Nunjucks style SCSS into local Svelte Tailwind CSS with DaisyUI.
- For each component, create a component folder, with a component folder file `README.md`, `+example.svelte`, `types.ts`, `config.ts`.
- For each component, create automated tests for the converted component using Playwright testing.
- Preserve all the existing NHS UK components' functionality exactly, except migrate from global Nunjucks into Svelte best practices.

# Testing
- Testing approach: For Playwright tests, create unit tests for individual components, and also create integration tests.

# Deployment
- Set up any deployment configuration using Svelte static site adapter `sveltejs/adapter-static`, as a static documentation site showcasing all the converted components.

# Timeline
- There is no specific deadline. There is no preferred timeline.

# Dependencies
- Existing dependencies: check if the referenced files (`svelte-documentation-llms-small.txt`, `daisyui-documentation-llms.txt`, `claude_desktop_config.json`) actually exist
  before proceeding.
- Directory permissions: verify I have write permissions to create the `public-good-design-system-with-svelte` directory before starting.

# Files
- Create file `plan.md` and file `tasks.md` before starting any implementation work; include technical implementation details and anything helpful; do not include timelines.
- Create the file `plan.md` that has the complete plan; document everything, with all the key findings, context and information that might help with the implementation, which will be used as a reference while implementing.
- Create the file `tasks.md` that will track the tasks during the implementation, and that will reference the file `plan.md`.

Do you have any clarifying questions for me?
