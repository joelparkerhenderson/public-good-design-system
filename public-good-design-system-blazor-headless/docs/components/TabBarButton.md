# TabBarButton

A tab bar button is a single tab within a tabbed interface. It renders a `<button>` with `role="tab"` and appropriate ARIA attributes for tab selection and panel association. It follows the roving tabindex pattern where only the selected tab participates in the tab order.

Compound component: must be placed inside a TabBar container with `role="tablist"`.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Selected` | `bool` | `—` | The selected value |
| `Controls` | `string` | `—` | The controls value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<TabBar label="Settings">
  <TabBarButton
    selected={activeTab === "general"}
    controls="panel-general"
    @onclick="HandleClick"
  >General</TabBarButton>
  <TabBarButton
    selected={activeTab === "advanced"}
    controls="panel-advanced"
    @onclick="HandleClick"
  >Advanced</TabBarButton>
</TabBar>
```


## Keyboard Interactions

- ArrowLeft/ArrowRight: Focus movement managed by parent TabBar
- Enter/Space: Activate the tab (native button behavior)

## ARIA Attributes

- `role="tab"` -- identifies this as a tab
- `aria-selected` -- communicates selection state
- `aria-controls` -- links to the corresponding tabpanel
- Roving `tabindex` (0 for selected, -1 for unselected)

## References

- WAI-ARIA Tabs Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/tabs/
