# Tab Bar Button

A tab is a UI/UX component that allows users to navigate between different
sections of content within a single interface by clicking or tapping on labeled
tabs, typically displayed horizontally at the top of a content area. Each tab
represents a distinct section, and only the content related to the active tab is
displayed at a time, keeping the interface clean and organized. TabBarButtons help group
similar information in a compact and accessible way, allowing users to switch
between views without reloading or navigating away from the page. They enhance
usability by providing an intuitive, quick way to explore different content or
options within the same context.

This component renders an individual tab button with proper ARIA attributes
including role="tab", aria-selected for the active state, and aria-controls to
associate the tab with its corresponding tabpanel. It follows the roving
tabindex pattern where only the selected tab participates in the tab order.

## Implementation Notes

- Renders as `<button role="tab">` for proper tab semantics
- `aria-selected` reflects active/inactive state
- `aria-controls` links to the associated tabpanel id
- Roving tabindex: selected tab has tabindex=0, others have tabindex=-1
- Should be placed within a `role="tablist"` container

## Props

- `selected`: boolean (default: false) -- whether this tab is active
- `controls`: string (required) -- id of the associated tabpanel
- `children`: slot -- tab label content
- `...restProps`: Any additional HTML attributes

## Usage

Basic tab within a tablist:

```html
<div role="tablist" aria-label="Main navigation">
  <TabBarButton
    selected={activeTabBarButton === "dashboard"}
    controls="panel-dashboard"
    onclick={() => activeTabBarButton = "dashboard"}
  >
    Dashboard
  </TabBarButton>
  <TabBarButton
    selected={activeTabBarButton === "settings"}
    controls="panel-settings"
    onclick={() => activeTabBarButton = "settings"}
  >
    Settings
  </TabBarButton>
  <TabBarButton
    selected={activeTabBarButton === "reports"}
    controls="panel-reports"
    onclick={() => activeTabBarButton = "reports"}
  >
    Reports
  </TabBarButton>
</div>

<div id="panel-dashboard" role="tabpanel" hidden={activeTabBarButton !== "dashboard"}>
  Dashboard content
</div>
<div id="panel-settings" role="tabpanel" hidden={activeTabBarButton !== "settings"}>
  Settings content
</div>
<div id="panel-reports" role="tabpanel" hidden={activeTabBarButton !== "reports"}>
  Reports content
</div>
```

## Keyboard Interactions

- TabBarButton: moves focus to the selected tab in the tablist
- ArrowLeft/ArrowRight: moves between tabs (handled by parent tablist)
- Enter/Space: activates the tab (native button behavior)

## ARIA

- `role="tab"` identifies this as a tab
- `aria-selected` communicates selection state
- `aria-controls` links to the corresponding tabpanel
- Roving `tabindex` (0 for selected, -1 for unselected)

## References

- WAI-ARIA TabBarButtons Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/tabs/
- WAI-ARIA TabBarButton Role: https://www.w3.org/TR/wai-aria-1.2/#tab
