# NHS UK Design System to Public Good Design System

Convert from "NHS UK Design System" with Nunjucks to "Public Good Design System" with TypeScript, HTML, CSS.

Create comprehensive project-level documentation explaining the conversion approach and component usage.

You are an expert HTML programmer, expert CSS designer, expert TypeScript programmer.

**Directories:**

- NHS UK Design System input directory is `./nhsuk-frontend`; this is already present on the system.
- Public Good Design System output directory is `./public-good-design-system-with-html-css-typescript`; create this TypeScript project in the specified directory.

**Fetch:**

- Fetch NHS UK Design System components content from `https://service-manual.nhs.uk/design-system/components`.
- Fetch NHS UK front end content from `https://github.com/nhsuk/nhsuk-frontend`.

**HTML:**

- Use vanilla HTML with best practices.
- No Svelte.
- No HTMLX.
- No React.
- No Vue.

**CSS:**

- Use vanilla CSS with best practices.
- CSS System: Complete color palette, typography scale, and utility classes
- Responsive Design: Mobile-first approach with breakpoint system.
- Accessibility: WCAG AA compliance built-in with focus management and screen reader support.
- No SCSS.
- No SASS.
- No PostCSS.
- No Tailwind.
- No React.
- No Vue.

**TypeScript:**

- Write clear, modular TypeScript code with proper type definitions
- Follow functional programming patterns; avoid classes
- Use descriptive variable names (e.g., isLoading, hasPermission)
- Structure files logically: popup, background, content scripts, utils
- Implement proper error handling and logging
- Document code with JSDoc comments
- Implement proper version control and change management
- Handle asynchronous operations with Promises
- Use Service Worker for background scripts
- Handle offline functionality gracefully

**Build tools**:

- Use modern build tools.
- Use PNPM. No NPM. No Yarn.
- Use Vite. No Webpack.

**Testing tools**:

- Use modern testing tools.
- Use Vitest for unit testing. No Jest.
- Use Playwright for end-to-end web application testing browser automation.
  
**UI UX User Experience:**

- Provide clear user feedback
- Support keyboard navigation
- Ensure proper loading states
- Add appropriate animations

**Internationalization:**

- Use localization, internationalization, translations
- Support multiple languages, including English, Welsh, Scots, Gaelic, Arabic, Chinese, Spanish
- Support RTL languages
- Handle regional formats

**Accessibility:**

- Implement ARIA labels
- Support screen readers
- Add keyboard shortcuts

**Security and Privacy:**

- Implement Content Security Policy (CSP)
- Handle user data securely
- Prevent XSS and injection attacks
- Use secure messaging between components
- Handle cross-origin requests safely
- Implement secure data encryption

**Testing and Debugging:**

- Write unit and integration tests
- Test cross-browser compatibility
- Monitor performance metrics
- Handle error scenarios

**Output Expectations:**

- Provide clear, working code examples
- Include necessary error handling
- Follow security best practices
- Ensure cross-browser compatibility
- Write maintainable and scalable code

**Branding:**

- Rename branding from "NHS UK" to "Public Good"
- Rename branding from "nhsuk" to "public-good"
- Rename branding prefix from "nhsuk-" to "public-good-"

**Components:**

- We need to convert ALL components from NHS UK Design System with Nunjucks to Public Good Design System with  HTML and CSS and TypeScript.
- Explore the directory `./nhsuk-frontend` to understand the existing components before starting the conversion.
- Analyze all NHS UK components to create a comprehensive plan to convert all components one by one in strict alphabetic order without any priority order.
- Change the styling and functionality from global Nunjucks style SCSS into local TypeScript style CSS.
- For each component, create a component folder, with a README file and example file and the relevant code.
- For each component, create a Vitest unit test, and a Playwright end-to-end application browser automation test.
- Preserve all the existing NHS UK components' functionality exactly, except migrate from global Nunjucks into local HTML CSS TypeScript best practices.

**Testing:**

- Testing approach: For Playwright tests, create unit tests for individual components, and also create integration tests.

**Deployment:**

**Timeline:**

- There is no specific deadline. There is no preferred timeline.

**Dependencies:**

- Directory exists: Verify the referenced directory (`./nhsuk-frontend`) exists.

- Directory permissions: verify I have write permissions to create the `public-good-design-system-with-html-css-typescript` directory before starting.

**Documentation**:

- Documentation level: For the component READMEs and examples, use extensive detail.

- Include usage guidelines, props documentation, accessibility notes, etc.

**Files:**

- Create file `plan.md` and file `tasks.md` in the root directory before starting any implementation work; include technical implementation details and anything helpful; do not include timelines.

- Create the file `plan.md` that has the complete plan; document everything, with all the key findings, context and information that might help with the implementation, which will be used as a reference while implementing.

- Create the file `tasks.md` that will track the tasks during the implementation, and that will reference the file `plan.md`.

IMPORTANT: Do you have any clarifying questions for me?
