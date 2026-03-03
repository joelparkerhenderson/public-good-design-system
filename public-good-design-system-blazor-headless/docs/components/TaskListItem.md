# TaskListItem

A single task item within a task list, rendering a semantic `<li>` element containing a checkbox input and label. Supports checked and disabled states for to-do lists, CheckLists, and task trackers. The checked state is bindable for reactive completion tracking.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Checked` | `bool` | `—` | The checked value |
| `CheckedChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Checked |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
@code {

    private bool termsAccepted = false;;
}

<ul aria-label="Today's tasks" role="list">
    <TaskListItem label="Review pull request" />
    <TaskListItem label="Update documentation" checked />
    <TaskListItem label="Deploy to staging" />
</ul>

<!-- Bindable checked state -->
<TaskListItem label="Accept terms" @bind-Checked="termsAccepted" />
```


