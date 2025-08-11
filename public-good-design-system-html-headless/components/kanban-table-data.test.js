// kanban-table-data.test.js
// KanbanTableData component test

const path = require('path');

describe('KanbanTableData', function() {
  beforeEach(async function() {
    await browser.url('file://' + path.resolve(__dirname, 'kanban-table-data.html'));
  });

  it('should render the td element with correct class', async function() {
    const el = await $('td.kanban-table-data');
    await expect(el).toExist();
    const className = await el.getAttribute('class');
    expect(className).toContain('kanban-table-data');
  });

  it('should have an aria-label attribute', async function() {
    const el = await $('td.kanban-table-data');
    const label = await el.getAttribute('aria-label');
    expect(label).not.toBeNull();
  });
});
